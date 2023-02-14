using WarehouseManagementApp.Controllers;
using WarehouseManagementApp.Models.DAO;
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
    public partial class StoreForm : Form
    {

        private Store _store;

        public StoreForm(Store store)
        {
            _store = store;

            InitializeComponent();
            (new Shadow()).ApplyShadows(this);

        }

        private void StoreForm_Load(object sender, EventArgs e)
        {
            labelStoreName.Text = "     " + _store.Name;

            _store.StoreProducts.ForEach(sp => {

                ListViewItem item = new ListViewItem();

                item.Tag = sp.Product;
                item.Name = sp.Product.ID.ToString();
                item.Text = sp.Product.Name;
                item.SubItems.Add(sp.Quantity.ToString());
                item.SubItems.Add(sp.Product.Price.ToString());

                listViewStoreInventory.Items.Add(item);
                resizeColumns(listViewStoreInventory);

            });

            if (listViewStoreInventory.Items.Count > 0) { 
                labelNoInventory.Visible= false;
            }

            RefreshComboBox();
            
        }

        private void btnStoreLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStoreOrder_Click(object sender, EventArgs e)
        {
            OrderController.ShowOrderForm(_store);
            RefreshComboBox();
        }

        private void comboBoxPendingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshListViewPendingOrders();
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            OrderController.Delete(comboBoxPendingOrders.Text);
            RefreshComboBox();
        }

        private void RefreshComboBox() {

            comboBoxPendingOrders.Items.Clear();
            listViewPendingOrders.Items.Clear();

            List<Order> orders = OrderController.GetPendingOrders(_store.ID);

            orders.ForEach(order => {
                comboBoxPendingOrders.Items.Add(order.ID);
            });

            comboBoxPendingOrders.Text = "";

        }

        private void RefreshListViewPendingOrders()
        {

            Store store = StoreController.GetStoreWithPendingOrders(_store.ID);

            listViewPendingOrders.Items.Clear();

            store.Orders.ForEach(order => {

                if (order.completed != true && order.ID == Convert.ToInt32(comboBoxPendingOrders.Text))
                {

                    order.OrderProducts.ForEach(op => {

                        ListViewItem item = new ListViewItem();
                        item.Tag = order;
                        item.Name = op.ID.ToString();
                        item.Text = op.Product.Name;
                        item.SubItems.Add(op.Quantity.ToString());
                        item.SubItems.Add(op.Product.Price.ToString());

                        listViewPendingOrders.Items.Add(item);
                        resizeColumns(listViewPendingOrders);

                    });

                }

            });

        }

        private void resizeColumns(System.Windows.Forms.ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
