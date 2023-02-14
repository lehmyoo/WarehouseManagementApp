using WarehouseManagementApp.Controllers;
using WarehouseManagementApp.Models.Entities;
using WarehouseManagementApp.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManagementApp.Views
{
    public partial class CreateStoreForm : Form
    {
        public CreateStoreForm()
        {
            InitializeComponent();
            (new Shadow()).ApplyShadows(this);
        }

        private void CreateStoreForm_Load(object sender, EventArgs e)
        {
            List<Warehouse> warehouses = WarehouseController.GetAll();

            warehouses.ForEach(w =>
            {
                comboBox1.Items.Add(w.ID);
            });
        }

        private void btnCreateStore_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else if (!textBox3.Text.Equals(textBox4.Text))
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {

                Dictionary<string, string> formData = new Dictionary<string, string>(){
                    {"name", textBox1.Text},
                    {"email",textBox2.Text },
                    {"password", textBox3.Text},
                    {"warehouseID", comboBox1.SelectedItem.ToString() }
                };

                StoreController.Create(formData);

                Close();

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
