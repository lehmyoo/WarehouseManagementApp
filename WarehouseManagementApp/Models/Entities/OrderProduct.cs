using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class OrderProduct
    {
        public int ID { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; } = null!;

        public int OrderID { get; set; }
        public Order Order { get; set; } = null!;

        public int Quantity { get; set; } = 0;

        public OrderProduct(int productID, int orderID, int quantity)
        {
            ProductID = productID;
            OrderID = orderID;
            Quantity = quantity;
        }
    }
}
