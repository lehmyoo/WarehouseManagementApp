namespace WarehouseManagementApp.Views
{
    partial class AdminForm
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listViewPendingOrders = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listViewPendingOrderDetails = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.listViewWarehouseProducts = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApproveOrder = new System.Windows.Forms.Button();
            this.btnDeclineOrder = new System.Windows.Forms.Button();
            this.comboBoxStores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnExit);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddStore);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.listViewWarehouseProducts);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnApproveOrder);
            this.splitContainer1.Panel2.Controls.Add(this.btnDeclineOrder);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxStores);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Size = new System.Drawing.Size(2336, 1492);
            this.splitContainer1.SplitterDistance = 580;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::WarehouseManagementApp.Properties.Resources.icons8_shutdown_64;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(70, 1298);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(22, 0, 12, 0);
            this.btnExit.Size = new System.Drawing.Size(396, 112);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Logout";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Image = global::WarehouseManagementApp.Properties.Resources.icons8_locked_user_64;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(70, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 81);
            this.label6.TabIndex = 5;
            this.label6.Text = "      Admin";
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(70, 292);
            this.btnAddStore.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(396, 101);
            this.btnAddStore.TabIndex = 0;
            this.btnAddStore.Text = "New Store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Location = new System.Drawing.Point(852, 273);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(770, 71);
            this.panel5.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(15, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 41);
            this.label12.TabIndex = 7;
            this.label12.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(328, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(663, 14);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 41);
            this.label13.TabIndex = 7;
            this.label13.Text = "Price";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.listViewPendingOrders);
            this.panel2.Location = new System.Drawing.Point(58, 448);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 350);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(22, 25);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 71);
            this.panel3.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(15, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 41);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(515, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 41);
            this.label10.TabIndex = 7;
            this.label10.Text = "Total";
            // 
            // listViewPendingOrders
            // 
            this.listViewPendingOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewPendingOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPendingOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPendingOrders.FullRowSelect = true;
            this.listViewPendingOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewPendingOrders.Location = new System.Drawing.Point(36, 98);
            this.listViewPendingOrders.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listViewPendingOrders.MultiSelect = false;
            this.listViewPendingOrders.Name = "listViewPendingOrders";
            this.listViewPendingOrders.Size = new System.Drawing.Size(583, 221);
            this.listViewPendingOrders.TabIndex = 7;
            this.listViewPendingOrders.UseCompatibleStateImageBehavior = false;
            this.listViewPendingOrders.View = System.Windows.Forms.View.Details;
            this.listViewPendingOrders.SelectedIndexChanged += new System.EventHandler(this.listViewPendingOrders_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.listViewPendingOrderDetails);
            this.panel1.Location = new System.Drawing.Point(58, 905);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 350);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(22, 27);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 71);
            this.panel4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(15, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "Product";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(532, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 41);
            this.label9.TabIndex = 7;
            this.label9.Text = "Qty";
            // 
            // listViewPendingOrderDetails
            // 
            this.listViewPendingOrderDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewPendingOrderDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPendingOrderDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listViewPendingOrderDetails.FullRowSelect = true;
            this.listViewPendingOrderDetails.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewPendingOrderDetails.Location = new System.Drawing.Point(36, 104);
            this.listViewPendingOrderDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listViewPendingOrderDetails.MultiSelect = false;
            this.listViewPendingOrderDetails.Name = "listViewPendingOrderDetails";
            this.listViewPendingOrderDetails.Size = new System.Drawing.Size(583, 216);
            this.listViewPendingOrderDetails.TabIndex = 4;
            this.listViewPendingOrderDetails.UseCompatibleStateImageBehavior = false;
            this.listViewPendingOrderDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Product";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Qty";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listViewWarehouseProducts
            // 
            this.listViewWarehouseProducts.BackColor = System.Drawing.Color.AliceBlue;
            this.listViewWarehouseProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWarehouseProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewWarehouseProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listViewWarehouseProducts.FullRowSelect = true;
            this.listViewWarehouseProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewWarehouseProducts.Location = new System.Drawing.Point(857, 374);
            this.listViewWarehouseProducts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listViewWarehouseProducts.MultiSelect = false;
            this.listViewWarehouseProducts.Name = "listViewWarehouseProducts";
            this.listViewWarehouseProducts.Size = new System.Drawing.Size(743, 1044);
            this.listViewWarehouseProducts.TabIndex = 4;
            this.listViewWarehouseProducts.UseCompatibleStateImageBehavior = false;
            this.listViewWarehouseProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Price";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(56, 394);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "Orders";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(58, 845);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Image = global::WarehouseManagementApp.Properties.Resources.icons8_barcode_scanner_64;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(852, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(759, 81);
            this.label4.TabIndex = 9;
            this.label4.Text = "     Warehouse Inventory";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnApproveOrder
            // 
            this.btnApproveOrder.BackColor = System.Drawing.Color.PowderBlue;
            this.btnApproveOrder.FlatAppearance.BorderSize = 0;
            this.btnApproveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApproveOrder.ForeColor = System.Drawing.Color.White;
            this.btnApproveOrder.Image = global::WarehouseManagementApp.Properties.Resources.icons8_trolley_64;
            this.btnApproveOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApproveOrder.Location = new System.Drawing.Point(287, 1296);
            this.btnApproveOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnApproveOrder.Name = "btnApproveOrder";
            this.btnApproveOrder.Padding = new System.Windows.Forms.Padding(22, 0, 12, 0);
            this.btnApproveOrder.Size = new System.Drawing.Size(435, 112);
            this.btnApproveOrder.TabIndex = 8;
            this.btnApproveOrder.Text = "    Approve Order";
            this.btnApproveOrder.UseVisualStyleBackColor = false;
            this.btnApproveOrder.Click += new System.EventHandler(this.btnApproveOrder_Click);
            // 
            // btnDeclineOrder
            // 
            this.btnDeclineOrder.BackColor = System.Drawing.Color.DarkGray;
            this.btnDeclineOrder.FlatAppearance.BorderSize = 0;
            this.btnDeclineOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeclineOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeclineOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeclineOrder.Location = new System.Drawing.Point(58, 1296);
            this.btnDeclineOrder.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDeclineOrder.Name = "btnDeclineOrder";
            this.btnDeclineOrder.Size = new System.Drawing.Size(197, 112);
            this.btnDeclineOrder.TabIndex = 8;
            this.btnDeclineOrder.Text = "Decline";
            this.btnDeclineOrder.UseVisualStyleBackColor = false;
            this.btnDeclineOrder.Click += new System.EventHandler(this.btnDeclineOrder_Click);
            // 
            // comboBoxStores
            // 
            this.comboBoxStores.FormattingEnabled = true;
            this.comboBoxStores.Location = new System.Drawing.Point(58, 292);
            this.comboBoxStores.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxStores.Name = "comboBoxStores";
            this.comboBoxStores.Size = new System.Drawing.Size(662, 49);
            this.comboBoxStores.TabIndex = 6;
            this.comboBoxStores.SelectedIndexChanged += new System.EventHandler(this.comboBoxStores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(58, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 50);
            this.label2.TabIndex = 6;
            this.label2.Text = "Stores";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::WarehouseManagementApp.Properties.Resources.icons8_invoice_64;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(58, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "     Pending orders";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(784, 1492);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2336, 1492);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAddStore;
        private Splitter splitter1;
        private Label label6;
        private Label label1;
        private ComboBox comboBoxStores;
        private Button btnExit;
        private Label label2;
        private Button btnApproveOrder;
        private Button btnDeclineOrder;
        private ListView listViewPendingOrders;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewWarehouseProducts;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Label label4;
        private Label label5;
        private ListView listViewPendingOrderDetails;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private Label label10;
        private Label label11;
        private Label label9;
        private Label label8;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label12;
        private Label label3;
        private Label label13;
    }
}