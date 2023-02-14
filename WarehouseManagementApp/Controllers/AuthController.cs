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
    public class AuthController
    {

        public static void AuthenticateStore(Dictionary<string, string> formData) 
        {
            Store? store = AuthDAO.AuthenticateStore(formData);

            if (store != null)
            {
                StoreForm storeForm = new StoreForm(store);
                storeForm.ShowDialog();
            }
        }

        public static void AuthenticateAdmin(Dictionary<string, string> formData)
        {

            if (AuthDAO.AuthenticateAdmin(formData) == true)
            {
                new AdminForm().ShowDialog();
            }

        }
    }
}
