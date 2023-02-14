using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class Order
    {
        public int ID { get; set; }

        public int StoreID { get; set; }
        public Store Store { get; set; } = null!;

        public double Total { get; set; } = 0;

        public bool completed { get; set; } = false;

        public List<OrderProduct> OrderProducts { get; set; } = null!;

        public Order(int storeID, double total, bool completed)
        {
            StoreID = storeID;
            Total = total;
            this.completed = completed;
        }
    }
}
