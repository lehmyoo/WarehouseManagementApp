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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            (new Shadow()).ApplyShadows(this);
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            StoreController.ShowCreateStoreForm();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            FillStoreComboBox();
        }

        private void FillStoreComboBox()
        {

            try {

                listViewWarehouseProducts.Items.Clear();
                listViewPendingOrders.Items.Clear();
                listViewPendingOrderDetails.Items.Clear();
                comboBoxStores.Items.Clear();


                List<Store> stores = StoreController.GetAllStoresWithPendingOrders();

                stores.ForEach(store => {

                    if (store.Orders.Count > 0 && store.Orders.Any(order => order.completed != true))
                    {
                        comboBoxStores.DisplayMember = "Name";
                        comboBoxStores.ValueMember = "ID";
                        comboBoxStores.Items.Add(store);
                    }

                });

                comboBoxStores.Text = "";

            } catch (Exception) { 
            }

        }

        private void comboBoxStores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listViewWarehouseProducts.Items.Clear();
                listViewPendingOrders.Items.Clear();
                listViewPendingOrderDetails.Items.Clear();

                int warehouseID = Convert.ToInt32(((Store)comboBoxStores.SelectedItem).WarehouseID);
                int storeID = Convert.ToInt32(((Store)comboBoxStores.SelectedItem).ID);

                WarehouseController.EagerByID(warehouseID).WarehouseProducts.ForEach(wp => {

                    ListViewItem item = new ListViewItem();

                    item.Tag = wp.Product;
                    item.Name = wp.Product.ID.ToString();
                    item.Text = wp.Product.Name;
                    item.SubItems.Add(wp.Quantity.ToString());
                    item.SubItems.Add(wp.Product.Price.ToString());

                    listViewWarehouseProducts.Items.Add(item);
                    resizeColumns(listViewWarehouseProducts);

                });

                FillPendingOrders(storeID);
            }
            catch (Exception)
            {
            }
        }

        private void FillPendingOrders(int storeID)
        {

            try {

                listViewPendingOrders.Items.Clear();
                listViewPendingOrderDetails.Items.Clear();

                Store store = StoreController.GetStoreWithPendingOrders(storeID);

                store.Orders.ForEach(order =>
                {

                    if (order.completed != true)
                    {

                        ListViewItem item = new ListViewItem();

                        item.Tag = order;
                        item.Name = order.ID.ToString();
                        item.Text = order.ID.ToString();
                        item.SubItems.Add(order.Total.ToString());

                        listViewPendingOrders.Items.Add(item);
                        resizeColumns(listViewPendingOrders);

                    }

                });
            } catch (Exception){
            }

        }

        private void listViewPendingOrders_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {

                listViewPendingOrderDetails.Items.Clear();

                int orderID = Convert.ToInt32(listViewPendingOrders.SelectedItems[0].Name);

                Order order = OrderController.GetPendingOrderByID(orderID);

                order.OrderProducts.ForEach(op =>
                {
                    ListViewItem item = new ListViewItem();
                    item.Tag = op.Product;
                    item.Name = op.ProductID.ToString();
                    item.Text = op.Product.Name;
                    item.SubItems.Add(op.Quantity.ToString());

                    listViewPendingOrderDetails.Items.Add(item);
                    resizeColumns(listViewPendingOrderDetails);
                });

            }
            catch (Exception) {
                
                //MessageBox.Show("Small bug");

            }

            
        }

        private void btnApproveOrder_Click(object sender, EventArgs e)
        {

            Store store = (Store)comboBoxStores.SelectedItem;
            int orderID = Convert.ToInt32(listViewPendingOrders.SelectedItems[0].Name);

            try {

                OrderController.ApproveOrder(orderID, store, listViewPendingOrderDetails, listViewWarehouseProducts);

                listViewWarehouseProducts.Items.Clear();
                listViewPendingOrders.Items.Clear();
                listViewPendingOrderDetails.Items.Clear();

            } catch (Exception) {
                MessageBox.Show("Error approving order");
            }
        }

        private void btnDeclineOrder_Click(object sender, EventArgs e)
        {
            try {

                int storeID = Convert.ToInt32(((Store)comboBoxStores.SelectedItem).ID);
                string orderID = listViewPendingOrders.SelectedItems[0].Name;

                listViewPendingOrders.Items[listViewPendingOrders.SelectedItems[0].Index].Remove();

                OrderController.Delete(orderID);

                FillStoreComboBox();

            } catch (Exception) {
                MessageBox.Show("Error Declining order");
            }

        }

        private void resizeColumns(System.Windows.Forms.ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
