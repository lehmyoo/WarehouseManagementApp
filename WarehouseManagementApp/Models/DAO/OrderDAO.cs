using WarehouseManagementApp.Models.Context;
using WarehouseManagementApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.DAO
{
    public class OrderDAO
    {
        private static ProjectContext _context = new ProjectContext();

        public static void PlaceOrder(Store store, ListView listViewStoreOrder, ListView listViewWarehouseProducts)
        {
           
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    // Get total
                    double total = 0;

                    for (int i = 0; i < listViewStoreOrder.Items.Count; i++)
                    {

                        int quantity = Convert.ToInt32(listViewStoreOrder.Items[i].SubItems[1].Text);
                        double price = Convert.ToDouble(listViewStoreOrder.Items[i].SubItems[2].Text);

                        total += quantity * price;

                    }

                    Order Order = new Order(store.ID, total, false);

                    _context.orders.Add(Order);
                    _context.SaveChanges();

                    // Adding to orderProduct
                    for (int i = 0; i < listViewStoreOrder.Items.Count; i++)
                    {

                        int id = Order.ID;
                        int productId = Convert.ToInt32(listViewStoreOrder.Items[i].Name);
                        int quantity = Convert.ToInt32(listViewStoreOrder.Items[i].SubItems[1].Text);

                        _context.order_products.Add(new(productId, id, quantity));
                        _context.SaveChanges();

                    }

                    transaction.Commit();

                }
                catch (Exception)
                {
                    transaction.Rollback();
                }
            }
            
        }


        public static void ApproveOrder(int orderID, Store store, ListView listViewPendingOrderDetails, ListView listViewWarehouseProducts)
        {

            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {

                    // Adding to storeProducts and removing from warehouseProducts
                    for (int i = 0; i < listViewPendingOrderDetails.Items.Count; i++)
                    {

                        // store to storeProduct
                        int storeId = store.ID;
                        int productId = Convert.ToInt32(listViewPendingOrderDetails.Items[i].Name);
                        int quantity = Convert.ToInt32(listViewPendingOrderDetails.Items[i].SubItems[1].Text);

                        _context.store_products.Add(new(productId, storeId, quantity));
                        _context.SaveChanges();

                        int orderProductQty = Convert.ToInt32(listViewPendingOrderDetails.Items[i].SubItems[1].Text);

                        WarehouseProduct wp = _context.warehouse_products.Single(wp => wp.ProductID == productId && wp.WarehouseID == store.WarehouseID);

                        wp.Quantity -= orderProductQty;

                        if (wp.Quantity < 0) {
                            throw new Exception();
                        }

                        _context.warehouse_products.Update(wp);
                        _context.SaveChanges();

                    }

                    //order complete = true
                    Order order = _context.orders.Single(order => order.ID == orderID);
                    order.completed = true;
                    _context.orders.Update(order);
                    _context.SaveChanges();


                    transaction.Commit();

                }
                catch (Exception)
                {
                    transaction.Rollback();
                    MessageBox.Show("Unable to approve order / Limited quantity in warehouse");
                }
            }

        }


        public static Order GetPendingOrderByID(int orderID)
        {
            return _context.orders
                .Where(order => order.ID == orderID)
                .Include(order => order.OrderProducts)
                .ThenInclude(orderProduct => orderProduct.Product)
                .Single();
        }

        public static List<Order> GetPendingOrders(int storeID)
        {
            return _context.orders.Where(order => order.StoreID == storeID && order.completed != true).ToList();
        }

        public static void Delete(int orderID)
        {
            _context.orders.Remove(_context.orders.Where(order => order.ID == orderID).Single());
            _context.SaveChanges();
        }
    }
}
