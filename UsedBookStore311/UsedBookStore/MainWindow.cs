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
                Form loginForm = new frmLogin(this, controller);
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

        private void searchBox_Click(object sender, EventArgs e)
        {
             if(searchBox.Text.Equals("[Search Here]"))
             {
                   searchBox.Text = string.Empty;
             }
        }

        private void searchBox_CheckEnter(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)13)
             {
                  //pass current searchBar text and selected comboBox item
                  controller.searchListings(searchBox.Text, searchComboBox.SelectedItem.ToString());
			   statusBar.Text = "Searching...";
             }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
