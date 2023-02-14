using WarehouseManagementApp.Models.DAO;
using WarehouseManagementApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Controllers
{
    public class WarehouseController
    {
        public static List<Warehouse> GetAll()
        {
            return WarehouseDAO.GetAll();
        }

        public static Warehouse EagerByID(int warehouseID)
        {
            return WarehouseDAO.EagerByID(warehouseID);
        }
    }
}
