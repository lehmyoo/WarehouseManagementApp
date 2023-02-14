namespace WarehouseManagementApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStorePanel = new System.Windows.Forms.Button();
            this.btnStoreRegister = new System.Windows.Forms.Button();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.panelStoreLogin = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxStoreLoginPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStoreLogin = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxStoreLoginEmail = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelStoreLogin.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.splitContainer.Panel2.Controls.Add(this.panelStoreLogin);
            this.splitContainer.Panel2.Controls.Add(this.panel9);
            this.splitContainer.Panel2.Controls.Add(this.panel4);
            this.splitContainer.Panel2.Controls.Add(this.panel3);
            this.splitContainer.Panel2.Controls.Add(this.btnAdminLogin);
            this.splitContainer.Panel2.Controls.Add(this.label3);
            this.splitContainer.Panel2.Controls.Add(this.panel10);
            this.splitContainer.Size = new System.Drawing.Size(1500, 940);
            this.splitContainer.SplitterDistance = 550;
            this.splitContainer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStorePanel);
            this.panel1.Controls.Add(this.btnStoreRegister);
            this.panel1.Controls.Add(this.btnAdminPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(100);
            this.panel1.Size = new System.Drawing.Size(550, 940);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WarehouseManagementApp.Properties.Resources.carts;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(100, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(313, 102);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, -15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "WMS";
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
            this.btnExit.Location = new System.Drawing.Point(100, 800);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnExit.Size = new System.Drawing.Size(350, 100);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStorePanel
            // 
            this.btnStorePanel.BackColor = System.Drawing.Color.White;
            this.btnStorePanel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStorePanel.FlatAppearance.BorderSize = 0;
            this.btnStorePanel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnStorePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnStorePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStorePanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStorePanel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnStorePanel.Image = global::WarehouseManagementApp.Properties.Resources.icons8_shop_64;
            this.btnStorePanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStorePanel.Location = new System.Drawing.Point(100, 300);
            this.btnStorePanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.btnStorePanel.Name = "btnStorePanel";
            this.btnStorePanel.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnStorePanel.Size = new System.Drawing.Size(350, 100);
            this.btnStorePanel.TabIndex = 1;
            this.btnStorePanel.Text = "   Store";
            this.btnStorePanel.UseVisualStyleBackColor = true;
            this.btnStorePanel.Click += new System.EventHandler(this.btnStorePanel_Click);
            // 
            // btnStoreRegister
            // 
            this.btnStoreRegister.BackColor = System.Drawing.Color.White;
            this.btnStoreRegister.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnStoreRegister.FlatAppearance.BorderSize = 0;
            this.btnStoreRegister.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnStoreRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnStoreRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStoreRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnStoreRegister.Image = global::WarehouseManagementApp.Properties.Resources.icons8_locked_user_64;
            this.btnStoreRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreRegister.Location = new System.Drawing.Point(103, 679);
            this.btnStoreRegister.Name = "btnStoreRegister";
            this.btnStoreRegister.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnStoreRegister.Size = new System.Drawing.Size(350, 100);
            this.btnStoreRegister.TabIndex = 2;
            this.btnStoreRegister.Text = "  Register";
            this.btnStoreRegister.UseVisualStyleBackColor = false;
            this.btnStoreRegister.Click += new System.EventHandler(this.btnStoreRegister_Click);
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.White;
            this.btnAdminPanel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnAdminPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAdminPanel.Image = global::WarehouseManagementApp.Properties.Resources.warehouse1;
            this.btnAdminPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminPanel.Location = new System.Drawing.Point(100, 425);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Padding = new System.Windows.Forms.Padding(20, 0, 10, 0);
            this.btnAdminPanel.Size = new System.Drawing.Size(350, 100);
            this.btnAdminPanel.TabIndex = 2;
            this.btnAdminPanel.Text = "  Admin";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
            // 
            // panelStoreLogin
            // 
            this.panelStoreLogin.BackColor = System.Drawing.Color.White;
            this.panelStoreLogin.Controls.Add(this.panel8);
            this.panelStoreLogin.Controls.Add(this.panel7);
            this.panelStoreLogin.Controls.Add(this.panel6);
            this.panelStoreLogin.Controls.Add(this.label2);
            this.panelStoreLogin.Controls.Add(this.btnStoreLogin);
            this.panelStoreLogin.Controls.Add(this.panel5);
            this.panelStoreLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStoreLogin.Location = new System.Drawing.Point(0, 0);
            this.panelStoreLogin.Name = "panelStoreLogin";
            this.panelStoreLogin.Size = new System.Drawing.Size(946, 940);
            this.panelStoreLogin.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::WarehouseManagementApp.Properties.Resources.icons8_lock_64;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel8.Location = new System.Drawing.Point(155, 422);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(103, 80);
            this.panel8.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::WarehouseManagementApp.Properties.Resources.icons8_full_mailbox_64;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Location = new System.Drawing.Point(155, 319);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(103, 80);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel6.Controls.Add(this.textBoxStoreLoginPassword);
            this.panel6.Location = new System.Drawing.Point(274, 422);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(447, 80);
            this.panel6.TabIndex = 6;
            // 
            // textBoxStoreLoginPassword
            // 
            this.textBoxStoreLoginPassword.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxStoreLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStoreLoginPassword.Location = new System.Drawing.Point(30, 10);
            this.textBoxStoreLoginPassword.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxStoreLoginPassword.Name = "textBoxStoreLoginPassword";
            this.textBoxStoreLoginPassword.PlaceholderText = "Password";
            this.textBoxStoreLoginPassword.Size = new System.Drawing.Size(390, 54);
            this.textBoxStoreLoginPassword.TabIndex = 2;
            this.textBoxStoreLoginPassword.Text = "store";
            this.textBoxStoreLoginPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Image = global::WarehouseManagementApp.Properties.Resources.icons8_lock_64;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(274, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 81);
            this.label2.TabIndex = 0;
            this.label2.Text = "     Store Login";
            // 
            // btnStoreLogin
            // 
            this.btnStoreLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStoreLogin.FlatAppearance.BorderSize = 0;
            this.btnStoreLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStoreLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStoreLogin.Image = global::WarehouseManagementApp.Properties.Resources.icons8_login_64;
            this.btnStoreLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStoreLogin.Location = new System.Drawing.Point(274, 527);
            this.btnStoreLogin.Name = "btnStoreLogin";
            this.btnStoreLogin.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnStoreLogin.Size = new System.Drawing.Size(447, 104);
            this.btnStoreLogin.TabIndex = 3;
            this.btnStoreLogin.Text = "Login";
            this.btnStoreLogin.UseVisualStyleBackColor = false;
            this.btnStoreLogin.Click += new System.EventHandler(this.btnStoreLogin_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel5.Controls.Add(this.textBoxStoreLoginEmail);
            this.panel5.Location = new System.Drawing.Point(274, 319);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 80);
            this.panel5.TabIndex = 6;
            // 
            // textBoxStoreLoginEmail
            // 
            this.textBoxStoreLoginEmail.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxStoreLoginEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStoreLoginEmail.Location = new System.Drawing.Point(30, 12);
            this.textBoxStoreLoginEmail.Name = "textBoxStoreLoginEmail";
            this.textBoxStoreLoginEmail.PlaceholderText = "Email";
            this.textBoxStoreLoginEmail.Size = new System.Drawing.Size(390, 54);
            this.textBoxStoreLoginEmail.TabIndex = 1;
            this.textBoxStoreLoginEmail.Text = "store@store.com";
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::WarehouseManagementApp.Properties.Resources.icons8_full_mailbox_64;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel9.Location = new System.Drawing.Point(155, 319);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(103, 80);
            this.panel9.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(274, 422);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(447, 80);
            this.panel4.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(30, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Password";
            this.textBox1.Size = new System.Drawing.Size(390, 54);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "secret";
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(274, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(447, 80);
            this.panel3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(30, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Email";
            this.textBox2.Size = new System.Drawing.Size(390, 54);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "admin@admin.com";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdminLogin.FlatAppearance.BorderSize = 0;
            this.btnAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminLogin.Image = global::WarehouseManagementApp.Properties.Resources.icons8_login_64;
            this.btnAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminLogin.Location = new System.Drawing.Point(274, 527);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAdminLogin.Size = new System.Drawing.Size(447, 104);
            this.btnAdminLogin.TabIndex = 3;
            this.btnAdminLogin.Text = "Login";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Image = global::WarehouseManagementApp.Properties.Resources.icons8_lock_64;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(274, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(499, 81);
            this.label3.TabIndex = 0;
            this.label3.Text = "     Admin Login";
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = global::WarehouseManagementApp.Properties.Resources.icons8_lock_64;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel10.Location = new System.Drawing.Point(155, 422);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(103, 80);
            this.panel10.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 54F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 940);
            this.Controls.Add(this.splitContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WMS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelStoreLogin.ResumeLayout(false);
            this.panelStoreLogin.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer;
        private Button btnStorePanel;
        private Button btnAdminPanel;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Button btnAdminLogin;
        private TextBox textBox1;
        private Panel panelStoreLogin;
        private TextBox textBox2;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private TextBox textBoxStoreLoginPassword;
        private Label label2;
        private Button btnStoreLogin;
        private Panel panel5;
        private TextBox textBoxStoreLoginEmail;
        private Panel panel7;
        private Panel panel8;
        private Panel panel10;
        private Panel panel9;
        private Button btnStoreRegister;
    }
}