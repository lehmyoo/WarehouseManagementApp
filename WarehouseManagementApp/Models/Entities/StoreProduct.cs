using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class StoreProduct
    {
        public int ID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; } = null!;

        public int StoreID { get; set; }
        public Store Store { get; set; } = null!;
        
        public int Quantity { get; set; }

        public StoreProduct(int productID, int storeID, int quantity)
        {
            ProductID = productID;
            StoreID = storeID;
            Quantity = quantity;
        }
    }
}
