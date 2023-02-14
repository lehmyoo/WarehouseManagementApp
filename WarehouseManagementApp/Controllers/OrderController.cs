using WarehouseManagementApp.Models.DAO;
using WarehouseManagementApp.Models.Entities;
using WarehouseManagementApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Controllers
{
    public class OrderController
    {
        public static void ShowOrderForm(Store store)
        { 
            new OrderForm(store).ShowDialog();
        }

        public static Warehouse PopulateInventory(int id)
        {
            return WarehouseDAO.EagerByID(id);
        }

        public static void PlaceOrder(Store store, ListView listViewStoreOrder, ListView listViewWarehouseProducts)
        {
            OrderDAO.PlaceOrder(store, listViewStoreOrder, listViewWarehouseProducts);
        }

        public static void ApproveOrder(int orderID, Store store, ListView listViewPendingOrderDetails, ListView listViewWarehouseProducts)
        {
            OrderDAO.ApproveOrder(orderID, store, listViewPendingOrderDetails, listViewWarehouseProducts);
        }

        public static List<Order> GetPendingOrders(int storeID)
        {
            return OrderDAO.GetPendingOrders(storeID);
        }

        public static Order GetPendingOrderByID(int orderID)
        {
            return OrderDAO.GetPendingOrderByID(orderID);
        }

        public static void Delete(string orderID)
        {
            try {

                if (orderID == "")
                {
                    throw new Exception();
                }

                OrderDAO.Delete(Convert.ToInt32(orderID));

            } catch (Exception)
            {
                MessageBox.Show("No Pending order is selected / Invalid choice");
            }
            
        }
    }
}
