namespace WarehouseManagementApp.Views
{
    partial class OrderForm
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
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewStoreOrder = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewWarehouseProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoveProduct);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlaceOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.btnAddProduct);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(2100, 1000);
            this.splitContainer1.SplitterDistance = 1050;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.FlatAppearance.BorderSize = 0;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveProduct.Image = global::WarehouseManagementApp.Properties.Resources.icons8_circled_right_64;
            this.btnRemoveProduct.Location = new System.Drawing.Point(903, 504);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(110, 114);
            this.btnRemoveProduct.TabIndex = 3;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.listViewStoreOrder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(166, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 550);
            this.panel2.TabIndex = 1;
            // 
            // listViewStoreOrder
            // 
            this.listViewStoreOrder.BackColor = System.Drawing.Color.White;
            this.listViewStoreOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewStoreOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewStoreOrder.FullRowSelect = true;
            this.listViewStoreOrder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewStoreOrder.Location = new System.Drawing.Point(31, 93);
            this.listViewStoreOrder.Name = "listViewStoreOrder";
            this.listViewStoreOrder.Size = new System.Drawing.Size(642, 428);
            this.listViewStoreOrder.TabIndex = 0;
            this.listViewStoreOrder.UseCompatibleStateImageBehavior = false;
            this.listViewStoreOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Product";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qty";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(31, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Products in cart";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::WarehouseManagementApp.Properties.Resources.icons8_cancel_64;
            this.button2.Location = new System.Drawing.Point(0, 900);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.button2.Size = new System.Drawing.Size(350, 100);
            this.button2.TabIndex = 0;
            this.button2.Text = "  Cancel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::WarehouseManagementApp.Properties.Resources.icons8_invoice_64;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(316, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 72);
            this.label2.TabIndex = 0;
            this.label2.Text = "     Order List";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.White;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlaceOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPlaceOrder.Image = global::WarehouseManagementApp.Properties.Resources.icons8_fast_cart_64;
            this.btnPlaceOrder.Location = new System.Drawing.Point(348, 900);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnPlaceOrder.Size = new System.Drawing.Size(712, 100);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "  Place Order";
            this.btnPlaceOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaceOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.Image = global::WarehouseManagementApp.Properties.Resources.icons8_go_back_64;
            this.btnAddProduct.Location = new System.Drawing.Point(44, 504);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(110, 114);
            this.btnAddProduct.TabIndex = 3;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.listViewWarehouseProducts);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(190, 274);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.panel1.Size = new System.Drawing.Size(680, 550);
            this.panel1.TabIndex = 2;
            // 
            // listViewWarehouseProducts
            // 
            this.listViewWarehouseProducts.BackColor = System.Drawing.Color.White;
            this.listViewWarehouseProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewWarehouseProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewWarehouseProducts.FullRowSelect = true;
            this.listViewWarehouseProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewWarehouseProducts.Location = new System.Drawing.Point(30, 93);
            this.listViewWarehouseProducts.MultiSelect = false;
            this.listViewWarehouseProducts.Name = "listViewWarehouseProducts";
            this.listViewWarehouseProducts.Size = new System.Drawing.Size(616, 428);
            this.listViewWarehouseProducts.TabIndex = 4;
            this.listViewWarehouseProducts.UseCompatibleStateImageBehavior = false;
            this.listViewWarehouseProducts.View = System.Windows.Forms.View.Details;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Products in warehouse";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Image = global::WarehouseManagementApp.Properties.Resources.icons8_barcode_scanner_64;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(190, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(679, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "     Warehouse Inventory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2100, 1000);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Label label1;
        private Button button2;
        private Button btnPlaceOrder;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private ListView listViewWarehouseProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnAddProduct;
        private Panel panel2;
        private ListView listViewStoreOrder;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label4;
        private Button btnRemoveProduct;
    }
}