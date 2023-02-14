namespace WarehouseManagementApp.Views
{
    partial class CreateStoreForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCreateStore = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 539);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 41);
            this.label5.TabIndex = 0;
            this.label5.Text = "Warehouse ID:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(367, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Name";
            this.textBox1.Size = new System.Drawing.Size(448, 47);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(367, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "example.example.com";
            this.textBox2.Size = new System.Drawing.Size(448, 47);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(367, 383);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Password";
            this.textBox3.Size = new System.Drawing.Size(448, 47);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(367, 460);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Password";
            this.textBox4.Size = new System.Drawing.Size(448, 47);
            this.textBox4.TabIndex = 1;
            this.textBox4.UseSystemPasswordChar = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(367, 535);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(448, 49);
            this.comboBox1.TabIndex = 2;
            // 
            // btnCreateStore
            // 
            this.btnCreateStore.Location = new System.Drawing.Point(554, 636);
            this.btnCreateStore.Name = "btnCreateStore";
            this.btnCreateStore.Size = new System.Drawing.Size(262, 65);
            this.btnCreateStore.TabIndex = 3;
            this.btnCreateStore.Text = "Create";
            this.btnCreateStore.UseVisualStyleBackColor = true;
            this.btnCreateStore.Click += new System.EventHandler(this.btnCreateStore_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(367, 636);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 65);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Image = global::WarehouseManagementApp.Properties.Resources.icons8_shop_64;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(196, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(540, 81);
            this.label6.TabIndex = 4;
            this.label6.Text = "     Register Store";
            // 
            // CreateStoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 754);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateStore);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateStoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateStoreForm";
            this.Load += new System.EventHandler(this.CreateStoreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button btnCreateStore;
        private Button btnCancel;
        private Label label6;
    }
}