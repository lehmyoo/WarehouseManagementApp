using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementApp.Models.DAO;
using WarehouseManagementApp.Models.Entities;
using WarehouseManagementApp.Views;

namespace WarehouseManagementApp.Controllers
{
    public class StoreController
    {

        public static List<Store> PopulateInventory(int id) 
        {
            return StoreDAO.EagerByID(id);
        }

        public static void Create(Dictionary<string, string> formData)
        {
            StoreDAO.Create(formData);
        }

        public static List<Store> GetAllStoresWithPendingOrders()
        {
            return StoreDAO.GetAllStoresWithPendingOrders();
        }

        public static Store GetStoreWithPendingOrders(int storeID)
        {
            return StoreDAO.GetStoreWithPendingOrders(storeID);
        }

        public static void ShowCreateStoreForm()
        {
            new CreateStoreForm().ShowDialog();
        }
    }
}
