using WarehouseManagementApp.Controllers;
using System.Xml.Serialization;

namespace WarehouseManagementApp
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            new MainController();
        }
    }
}