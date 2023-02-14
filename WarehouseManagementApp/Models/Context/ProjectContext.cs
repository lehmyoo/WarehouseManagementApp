using WarehouseManagementApp.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Context
{
    public class ProjectContext : DbContext
    {

        //entities
        public DbSet<Warehouse> warehouses { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<WarehouseProduct> warehouse_products { get; set; }
        public DbSet<StoreProduct> store_products { get; set; }
        public DbSet<OrderProduct> order_products { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Order> orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQL2019EXPRESS;" +
                @"Database = warehouse_management_db;" +
                @"Integrated security = true;" +
                @"TrustServerCertificate = true;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
