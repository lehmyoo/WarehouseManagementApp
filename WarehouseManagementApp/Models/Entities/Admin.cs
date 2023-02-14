using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementApp.Models.Entities
{
    public class Admin
    {
        public int ID { get; set; }

        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;

        public Admin(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
