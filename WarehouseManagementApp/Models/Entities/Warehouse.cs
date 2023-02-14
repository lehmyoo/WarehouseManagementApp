using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class Warehouse
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public List<WarehouseProduct> WarehouseProducts { get; set; } = null!;

        public Warehouse(string name)
        {
            Name = name;
        }
    }
}
