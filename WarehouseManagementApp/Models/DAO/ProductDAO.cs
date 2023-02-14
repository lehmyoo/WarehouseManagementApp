using WarehouseManagementApp.Models.Context;
using WarehouseManagementApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Manager
{
    public class ProductDAO
    {
        private static ProjectContext _context = new ProjectContext();

        public static List<Product> GetAll()
        {
            return _context.products.ToList();
        }

        public static Product GetByID(int id)
        {
            return _context.products.Single(product => product.ID == id);
        }

        public static void Create(Product product)
        {
            _context.products.Add(product);
            _context.SaveChanges();
        }

        public static void Update(Product product)
        {
            _context.products.Update(product);
            _context.SaveChanges();
        }

        public static void Delete(Product product)
        {
            _context.products.Remove(product);
            _context.SaveChanges();
        }
    }
}
