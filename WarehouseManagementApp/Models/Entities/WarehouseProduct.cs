using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class WarehouseProduct
    {
        public int ID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; } = null!;

        public int WarehouseID { get; set; }
        public Warehouse Warehouse { get; set; } = null!;

        public int Quantity { get; set; } = 0;

        public WarehouseProduct(int productID, int warehouseID, int quantity)
        {
            ProductID = productID;
            WarehouseID = warehouseID;
            Quantity = quantity;
        }
    }
}
