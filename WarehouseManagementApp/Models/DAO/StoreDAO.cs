using WarehouseManagementApp.Models.Context;
using WarehouseManagementApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.DAO
{
    public class StoreDAO
    {
        private static ProjectContext _context = new ProjectContext();

        public static List<Store> GetAll()
        {
            return _context.stores.ToList();
        }

        public static List<Store> GetAllStoresWithPendingOrders()
        {
            return _context.stores
                .Include(store => store.Orders)
                .ThenInclude(order => order.OrderProducts)
                .ThenInclude(orderProduct => orderProduct.Product)
                .ToList();
        }

        public static Store GetStoreWithPendingOrders(int storeID)
        {
            return _context.stores
                .Where(store => store.ID == storeID)
                .Include(store => store.Orders)
                .ThenInclude(order => order.OrderProducts)
                .ThenInclude(orderProduct => orderProduct.Product)
                .Single();
        }

        public static Store GetByID(int id)
        {
            return _context.stores.Single(store => store.ID == id);
        }

        public static List<Store> EagerByID(int id)
        {
            return _context.stores
                .Where(store => store.ID == id)
                .Include(store => store.StoreProducts)
                .ThenInclude(storeProduct => storeProduct.Product)
                .ToList();
        }

        public static void Create(Dictionary<string, string> formData)
        {

            Store store = new(Convert.ToInt32(formData["warehouseID"]), formData["name"], formData["email"], formData["password"]);
            _context.stores.Add(store);
            _context.SaveChanges();
        }

        public static void Update(Store store)
        {
            _context.stores.Update(store);
            _context.SaveChanges();
        }

        public static void Delete(Store store)
        {
            _context.stores.Remove(store);
            _context.SaveChanges();
        }
    }
}
