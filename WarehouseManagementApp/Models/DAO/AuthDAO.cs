using WarehouseManagementApp.Models.Context;
using WarehouseManagementApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.DAO
{
    public class AuthDAO
    {
        private static ProjectContext _context = new ProjectContext();

        public static Store? AuthenticateStore(Dictionary<string, string> formData)
        {

            try
            {

                Store store = _context.stores
                    .Where(store => store.Email.Equals(formData["email"]))
                    .Include(store => store.Orders)
                    .ThenInclude(order => order.OrderProducts)
                    .ThenInclude(orderProduct => orderProduct.Product)
                    .Include(store => store.StoreProducts)
                    .ThenInclude(storeProduct => storeProduct.Product)
                    .Single();

                if (store.Password != formData["password"]) { throw new Exception(); }

                return store;

            }
            catch
            {
                MessageBox.Show("Credentials could not be verified");
            }

            return null;
        }

        public static bool? AuthenticateAdmin(Dictionary<string, string> formData)
        {
            try
            {
                Admin admin = _context.admins.Single(admin => admin.Email.Equals(formData["email"]));
                if (admin.Password != formData["password"])
                {
                    throw new Exception();
                }
                else {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Credentials could not be verified");
            }

            return false;

        }
    }
}
