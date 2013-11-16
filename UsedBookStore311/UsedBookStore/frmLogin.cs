using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UsedBookStore
{
    public partial class frmLogin : Form
    {
        frmMainWindow originalForm;
        Controller controller;

        public frmLogin(Form original, Controller c)
        {
            InitializeComponent();
            originalForm = (frmMainWindow)original;
            controller = c;
        }

        //Register Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRegUser.Text.Equals("") || txtRegPW.Text.Equals("") || txtPhone.Text.Equals("") || txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Please ensure all fields are filled.", "Registration failed");
                return;
            }

            if (!txtRegPW.Text.Equals(txtConfirmPW.Text))
            {
                MessageBox.Show("Passwords don't match.", "Registration failed");
                return;
            }

            if (!Regex.IsMatch(txtRegUser.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Please only enter letters and/or numbers in the Username field.", "Registration failed");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$"))
            {
                MessageBox.Show("Please enter a valid email.", "Registration failed");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^(?:(?:\+?1\s*(?:[.-]\s*)?)?(?:\(\s*([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9])\s*\)|([2-9]1[02-9]|[2-9][02-8]1|[2-9][02-8][02-9]))\s*(?:[.-]\s*)?)?([2-9]1[02-9]|[2-9][02-9]1|[2-9][02-9]{2})\s*(?:[.-]\s*)?([0-9]{4})(?:\s*(?:#|x\.?|ext\.?|extension)\s*(\d+))?$"))
            {
                MessageBox.Show("Please enter a valid phone number, in any format.", "Registration failed");
                return;
            }

            bool registerSuccess = this.controller.tryRegister(txtRegUser.Text, txtRegPW.Text, "TODO", txtPhone.Text, txtEmail.Text);

            if (registerSuccess)
            {
                this.Close();
                MessageBox.Show("Successfully Registered!", "Registration Successful");
            }
            else
            {
                MessageBox.Show("Failed to register user", "Registration failed");
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool successfulLogin = false;
            if (Regex.IsMatch(txtUser.Text, @"^[a-zA-Z]+$"))
            {
                successfulLogin = this.controller.tryLogin(txtUser.Text, txtPass.Text);
            }
           

            if (successfulLogin)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username password combination", "Invalid User");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
