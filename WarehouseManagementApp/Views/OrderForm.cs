using WarehouseManagementApp.Controllers;
using WarehouseManagementApp.Models.Entities;
using WarehouseManagementApp.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarehouseManagementApp.Views
{
    public partial class OrderForm : Form
    {
        private Store _store;

        public OrderForm(Store store)
        {
            _store = store;

            InitializeComponent();
            new Shadow().ApplyShadows(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

            OrderController.PopulateInventory(_store.WarehouseID).WarehouseProducts.ForEach(wp => {
                ListViewItem item = new ListViewItem();

                item.Tag = wp.Product;
                item.Name = wp.Product.ID.ToString();
                item.Text = wp.Product.Name;
                item.SubItems.Add(wp.Quantity.ToString());
                item.SubItems.Add(wp.Product.Price.ToString());

                listViewWarehouseProducts.Items.Add(item);
                resizeColumns(listViewWarehouseProducts);

            });

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            ListViewItem item = new ListViewItem();

            String currentItemSelected = listViewWarehouseProducts.SelectedItems[0].Name.ToString();

            if (Convert.ToInt32(listViewWarehouseProducts.SelectedItems[0].SubItems[1].Text) == 0) {

                MessageBox.Show("Quantity of the item chosen is 0, choose another product to add");

            } else if ( ! listViewStoreOrder.Items.ContainsKey(currentItemSelected)) {

                // decrement quantity from warehouse inventory
                listViewWarehouseProducts.SelectedItems[0].SubItems[1].Text = (Convert.ToInt32(listViewWarehouseProducts.SelectedItems[0].SubItems[1].Text) - 1).ToString();


                // add to store order
                item.Name = listViewWarehouseProducts.SelectedItems[0].Name.ToString();
                item.Tag = listViewWarehouseProducts.SelectedItems[0].Tag;
                item.Text = listViewWarehouseProducts.SelectedItems[0].SubItems[0].Text;
                item.SubItems.Add("1");
                item.SubItems.Add(listViewWarehouseProducts.SelectedItems[0].SubItems[2].Text);

                listViewStoreOrder.Items.Add(item);

            } else {

                // decrement quantity from warehouse inventory
                listViewWarehouseProducts.SelectedItems[0].SubItems[1].Text = (Convert.ToInt32(listViewWarehouseProducts.SelectedItems[0].SubItems[1].Text) - 1).ToString();


                for (int i = 0; i < listViewStoreOrder.Items.Count; i++)
                {
                    if (listViewStoreOrder.Items[i].Name.Equals(currentItemSelected))
                    {

                        int qty = Convert.ToInt32(listViewStoreOrder.Items[i].SubItems[1].Text) + 1;
                        double price = Convert.ToDouble(listViewWarehouseProducts.SelectedItems[0].SubItems[2].Text) * qty;

                        listViewStoreOrder.Items[i].SubItems[1].Text = qty.ToString();
                        listViewStoreOrder.Items[i].SubItems[2].Text = price.ToString();
                    }
                }

            }

            resizeColumns(listViewStoreOrder);

        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

            String currentItemSelected = listViewStoreOrder.SelectedItems[0].Name.ToString();

            // decrement quantity from store inventory
            listViewStoreOrder.SelectedItems[0].SubItems[1].Text = (Convert.ToInt32(listViewStoreOrder.SelectedItems[0].SubItems[1].Text) - 1).ToString();

            if (Convert.ToInt32(listViewStoreOrder.SelectedItems[0].SubItems[1].Text) == 0) {

                listViewStoreOrder.Items.RemoveByKey(currentItemSelected);

            }

            for (int i = 0; i < listViewWarehouseProducts.Items.Count; i++)
            {
                if (listViewWarehouseProducts.Items[i].Name.Equals(currentItemSelected))
                {
                    int qty = Convert.ToInt32(listViewWarehouseProducts.Items[i].SubItems[1].Text) + 1;
                    listViewWarehouseProducts.Items[i].SubItems[1].Text = qty.ToString();
                }
            }

            resizeColumns(listViewStoreOrder);

        }

        private void resizeColumns(System.Windows.Forms.ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderController.PlaceOrder(_store, listViewStoreOrder, listViewWarehouseProducts);
            Close();
        }
    }
}
