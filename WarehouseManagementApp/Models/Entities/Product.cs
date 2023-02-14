using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public double Price { get; set; }

        public Product(string name, string? description, string? category, double price)
        {
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}
