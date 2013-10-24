using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsedBookStore
{
    public partial class frmMainWindow : Form
    {
        Controller controller;

        public frmMainWindow(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            //controller.connectDB();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLoggedIn())
            {
                toggleLoginButton();
            }
            else
            {
                Form loginForm = new frmLogin(this);
                loginForm.Visible = true;
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void NewListingBtn_Click(object sender, EventArgs e)
        {
            this.controller.showNewListingWindow();
        }

        public void toggleLoginButton()
        {
            if (btnLogin.Text.Equals("Login"))
            {
                btnLogin.Text = "Logout";
                btnSettings.Visible = true;
            }
            else
            {
                btnLogin.Text = "Login";
                btnSettings.Visible = false;
            }
        }

        public bool isLoggedIn()
        {
            if (btnLogin.Text.Equals("Logout"))
            {
                return true;
            }

            return false;
        }
    }
}
