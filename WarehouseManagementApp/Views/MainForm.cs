using WarehouseManagementApp.Controllers;
using WarehouseManagementApp.Scripts;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WarehouseManagementApp
{
    public partial class MainForm : Form
    {

        #region unused code
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
private static extern IntPtr CreateRoundRectRgn (int nLeftRect,int nTopRect,int nRightRect,int nBottomRect,int nWidthEllipse,int nHeightEllipse);
*/
        //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 70, 70));
        #endregion

        public MainForm()
        {
            InitializeComponent();
            (new Shadow()).ApplyShadows(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panelStoreLogin.Visible = true;
        }

        private void btnStorePanel_Click(object sender, EventArgs e)
        {
            panelStoreLogin.Visible = true;
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            panelStoreLogin.Visible = false;
        }



        private void btnStoreLogin_Click(object sender, EventArgs e)
        {

            Dictionary<string, string> formData = new Dictionary<string, string>(){
                {"email", textBoxStoreLoginEmail.Text},
                {"password", textBoxStoreLoginPassword.Text},
            };

            btnStoreLogin.Text = "Loading...";
            btnStoreLogin.Enabled= false;

            AuthController.AuthenticateStore(formData);

            btnStoreLogin.Text = "Login";
            btnStoreLogin.Enabled = true;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> formData = new Dictionary<string, string>(){
                {"email", textBox2.Text},
                {"password", textBox1.Text},
            };

            btnAdminLogin.Text = "Loading...";
            btnAdminLogin.Enabled = false;

            AuthController.AuthenticateAdmin(formData);

            btnAdminLogin.Text = "Login";
            btnAdminLogin.Enabled = true;
        }

        private void btnStoreRegister_Click(object sender, EventArgs e)
        {
            StoreController.ShowCreateStoreForm();
        }
    }
}