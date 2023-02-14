namespace WarehouseManagementApp.Views
{
    partial class StoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnStoreLogout = new System.Windows.Forms.Button();
            this.btnStoreOrder = new System.Windows.Forms.Button();
            this.labelStoreName = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.listViewPendingOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.comboBoxPendingOrders = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNoInventory = new System.Windows.Forms.Label();
            this.listViewStoreInventory = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.btnStoreLogout);
            this.splitContainer1.Panel1.Controls.Add(this.btnStoreOrder);
            this.splitContainer1.Panel1.Controls.Add(this.labelStoreName);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(113, 110, 113, 110);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(2380, 1108);
            this.splitContainer1.SplitterDistance = 622;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnStoreLogout
            // 
            this.btnStoreLogout.BackColor = System.Drawing.Color.IndianRed;
            this.btnStoreLogout.FlatAppearance.BorderSize = 0;
            this.btnStoreLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoreLogout.ForeColor = System.Drawing.Color.White;
            this.btnStoreLogout.Image = global::WarehouseManagementApp.Properties.Resources.icons8_shutdown_64;
            this.btnStoreLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreLogout.Location = new System.Drawing.Point(113, 886);
            this.btnStoreLogout.Name = "btnStoreLogout";
            this.btnStoreLogout.Padding = new System.Windows.Forms.Padding(23, 0, 11, 0);
            this.btnStoreLogout.Size = new System.Drawing.Size(397, 110);
            this.btnStoreLogout.TabIndex = 1;
            this.btnStoreLogout.Text = "  Logout";
            this.btnStoreLogout.UseVisualStyleBackColor = false;
            this.btnStoreLogout.Click += new System.EventHandler(this.btnStoreLogout_Click);
            // 
            // btnStoreOrder
            // 
            this.btnStoreOrder.BackColor = System.Drawing.Color.White;
            this.btnStoreOrder.FlatAppearance.BorderSize = 0;
            this.btnStoreOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnStoreOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoreOrder.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStoreOrder.Image = global::WarehouseManagementApp.Properties.Resources.icons8_shopping_trolley_64;
            this.btnStoreOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreOrder.Location = new System.Drawing.Point(113, 331);
            this.btnStoreOrder.Name = "btnStoreOrder";
            this.btnStoreOrder.Padding = new System.Windows.Forms.Padding(23, 0, 11, 0);
            this.btnStoreOrder.Size = new System.Drawing.Size(397, 110);
            this.btnStoreOrder.TabIndex = 1;
            this.btnStoreOrder.Text = "Order";
            this.btnStoreOrder.UseVisualStyleBackColor = false;
            this.btnStoreOrder.Click += new System.EventHandler(this.btnStoreOrder_Click);
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStoreName.Image = global::WarehouseManagementApp.Properties.Resources.icons8_shop_64;
            this.labelStoreName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStoreName.Location = new System.Drawing.Point(113, 110);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(277, 81);
            this.labelStoreName.TabIndex = 0;
            this.labelStoreName.Text = "     Store";
            this.labelStoreName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.splitContainer2.Panel1.Controls.Add(this.btnDeleteOrder);
            this.splitContainer2.Panel1.Controls.Add(this.listViewPendingOrders);
            this.splitContainer2.Panel1.Controls.Add(this.comboBoxPendingOrders);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(113, 110, 113, 110);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.labelNoInventory);
            this.splitContainer2.Panel2.Controls.Add(this.listViewStoreInventory);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(113, 0, 113, 110);
            this.splitContainer2.Size = new System.Drawing.Size(1755, 1108);
            this.splitContainer2.SplitterDistance = 854;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 1;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Location = new System.Drawing.Point(93, 885);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(660, 110);
            this.btnDeleteOrder.TabIndex = 3;
            this.btnDeleteOrder.Text = "Delete order";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // listViewPendingOrders
            // 
            this.listViewPendingOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewPendingOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPendingOrders.Location = new System.Drawing.Point(93, 414);
            this.listViewPendingOrders.MultiSelect = false;
            this.listViewPendingOrders.Name = "listViewPendingOrders";
            this.listViewPendingOrders.Size = new System.Drawing.Size(659, 383);
            this.listViewPendingOrders.TabIndex = 2;
            this.listViewPendingOrders.UseCompatibleStateImageBehavior = false;
            this.listViewPendingOrders.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Qty";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            // 
            // comboBoxPendingOrders
            // 
            this.comboBoxPendingOrders.FormattingEnabled = true;
            this.comboBoxPendingOrders.Location = new System.Drawing.Point(93, 331);
            this.comboBoxPendingOrders.Name = "comboBoxPendingOrders";
            this.comboBoxPendingOrders.Size = new System.Drawing.Size(659, 49);
            this.comboBoxPendingOrders.TabIndex = 1;
            this.comboBoxPendingOrders.SelectedIndexChanged += new System.EventHandler(this.comboBoxPendingOrders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::WarehouseManagementApp.Properties.Resources.icons8_invoice_64;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(113, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Pending Orders";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNoInventory
            // 
            this.labelNoInventory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelNoInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNoInventory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoInventory.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelNoInventory.Location = new System.Drawing.Point(117, 301);
            this.labelNoInventory.Name = "labelNoInventory";
            this.labelNoInventory.Padding = new System.Windows.Forms.Padding(34, 33, 34, 33);
            this.labelNoInventory.Size = new System.Drawing.Size(663, 274);
            this.labelNoInventory.TabIndex = 2;
            this.labelNoInventory.Text = "The store inventory is currently empty. Make an order then wait for the admin to " +
    "approve it and it will show up in this section";
            this.labelNoInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listViewStoreInventory
            // 
            this.listViewStoreInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStoreInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewStoreInventory.FullRowSelect = true;
            this.listViewStoreInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewStoreInventory.Location = new System.Drawing.Point(117, 301);
            this.listViewStoreInventory.MultiSelect = false;
            this.listViewStoreInventory.Name = "listViewStoreInventory";
            this.listViewStoreInventory.Size = new System.Drawing.Size(663, 694);
            this.listViewStoreInventory.TabIndex = 1;
            this.listViewStoreInventory.UseCompatibleStateImageBehavior = false;
            this.listViewStoreInventory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qty";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = global::WarehouseManagementApp.Properties.Resources.icons8_open_box_64;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(224, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 81);
            this.label2.TabIndex = 0;
            this.label2.Text = "     Inventory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2380, 1108);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreForm";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label labelStoreName;
        private Button btnStoreLogout;
        private Button btnStoreOrder;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer2;
        private ComboBox comboBoxPendingOrders;
        private ListView listViewPendingOrders;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnDeleteOrder;
        private ListView listViewStoreInventory;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label labelNoInventory;
    }
}