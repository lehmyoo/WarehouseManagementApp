using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class Store
    {
        public int ID { get; set; }

        public int WarehouseID { get; set; }
        public Warehouse Warehouse { get; set; } = null!;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public List<Order> Orders { get; set; } = null!;
        public List<StoreProduct> StoreProducts { get; set; } = null!;

        public Store(int warehouseID, string name, string email, string password)
        {
            WarehouseID = warehouseID;
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
