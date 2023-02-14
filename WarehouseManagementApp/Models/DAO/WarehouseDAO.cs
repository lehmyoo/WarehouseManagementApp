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
    public class WarehouseDAO
    {

        private static ProjectContext _context = new ProjectContext();

        public static List<Warehouse> GetAll()
        {
            return _context.warehouses.ToList();
        }

        public static Warehouse GetByID(int id)
        {
            return _context.warehouses.Single(warehouse => warehouse.ID == id);
        }

        public static Warehouse EagerByID(int warehouseID)
        {
            return _context.warehouses
                .Where(warehouse => warehouse.ID == warehouseID)
                .Include(warehouse => warehouse.WarehouseProducts)
                .ThenInclude(warehouseProduct => warehouseProduct.Product)
                .Single();
        }

    }
}
