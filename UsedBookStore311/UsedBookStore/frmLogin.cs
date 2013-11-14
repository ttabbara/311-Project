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
            if (DatabaseManager.registerUser(txtRegUser.Text, txtRegPW.Text, "TODO", txtPhone.Text, txtEmail.Text))
            {
                originalForm.toggleLoginButton();
                originalForm.toggleGreeting(txtUser.Text);
                controller.setUser(new User(txtUser.Text, txtPass.Text, txtPhone.Text, txtEmail.Text));
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
            if (DatabaseManager.verifyLogin(txtUser.Text, txtPass.Text))
            {
                originalForm.toggleLoginButton();
                originalForm.toggleGreeting(txtUser.Text);
                controller.setUser(new User(txtUser.Text, txtPass.Text));
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
    }
}
