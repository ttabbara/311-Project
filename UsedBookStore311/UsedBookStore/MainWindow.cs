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
        private DataTable cachedResultTable;
        private Image noImage = null;

        public frmMainWindow(Controller controller)
        {
            InitializeComponent();
            this.controller = controller;
            searchComboBox.SelectedIndex = 3;

            controller.setMainWindow(this);
		  statusbar.Text = "Sign up or Login for Full Access!";
		  statusStrip.Update();
            btnSettings.Visible = false;
            NewListingBtn.Visible = false;
            MyListingBtn.Visible = false;
            RecBookBtn.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (controller.isUserLoggedIn())
            {
                toggleLoginButton();
                toggleGreeting("shut off");
                controller.userLogout();
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
            if (controller.getUser() != null)
                this.controller.showNewListingWindow();
        }

        public void toggleLoginButton()
        {
            if (this.controller.isUserLoggedIn())
            {
                btnLogin.Text = "Logout";
                btnSettings.Visible = true;

                NewListingBtn.Visible = true;
                MyListingBtn.Visible = true;
                RecBookBtn.Visible = true;
			 statusbar.Text = "Best of luck with your classes!";
			 statusStrip.Update();
            }
            else
            {
                btnLogin.Text = "Login";
                btnSettings.Visible = false;

                NewListingBtn.Visible = false;
                MyListingBtn.Visible = false;
                RecBookBtn.Visible = false;
            }
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
		   statusbar.Text = "Keep your searches simple. Searches are not Case-sensitive.";
		   statusStrip.Update();
            if (searchBox.Text.Equals("[Search Here]"))
            {
                searchBox.Text = string.Empty;
            }
        }

        private void searchBox_CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                //pass current searchBar text and selected comboBox item
                if (searchBox.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Please enter search text before searching");
                    return;
                }
			 statusbar.Text = "Searching...";
			 statusStrip.Update();
                displaySearchResults(cachedResultTable = controller.searchListings(searchBox.Text, searchComboBox.SelectedItem.ToString()));
			
            }
        }

        private void displaySearchResults(DataTable dt)
        {
            if (dt.Rows.Count < 1)
            {
                MessageBox.Show("Your search did not match any Ads.", "No results");
			 statusbar.Text = "Try to refine your search please.";
			 statusStrip.Update();
            }
            dgvSearchResults.Rows.Clear();
            int counter = 1;
            dgvSearchResults.BringToFront();
            foreach (DataRow row in dt.Rows)
            {
                //No Image default record, skip it
                if (row["ListingID"].ToString().Equals("11"))
                {
                    continue;
                }
                if (row["Image"].ToString() != "")
                {
                    Image image = DatabaseManager.byteArrayToImage(row["Image"] as Byte[]);
                    Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                    dgvSearchResults.Rows.Add(row["ListingID"].ToString() + "", thumb, row["Header"].ToString(), "Me", row["Desc"].ToString(), "$" + row["Price"].ToString(), row["Condition"].ToString());
                }
                else
                {
                    Image thumb = getNoImagePic().GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                    dgvSearchResults.Rows.Add(row["ListingID"].ToString() + "",thumb, row["Header"].ToString(), "Me", row["Desc"].ToString(), "$" + row["Price"].ToString(), row["Condition"].ToString());
                }
                counter++;
            }
		  statusbar.Text = "Click open ad to view contact information!";
		  statusStrip.Update();
        }

        private Image getCorrespondingImage(string id)
        {
            foreach (DataRow row in cachedResultTable.Rows)
            {
                if (row["ListingID"].ToString().Equals(id + ""))
                {
                    return DatabaseManager.byteArrayToImage(row["Image"] as Byte[]); ;
                }
            }
            return null;
        }

        private Image getNoImagePic()
        {
            if (noImage != null)
            {
                return noImage;
            }
            return noImage = DatabaseManager.getDefaultNoImage();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //My Listings Button
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAdTitle_Click(object sender, EventArgs e)
        {

        }

        //Open ad button
        private void btnOpenAd_Click(object sender, EventArgs e)
        {
            if (dgvSearchResults.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an Ad to open first.");
                return;
            }
            foreach(DataGridViewRow row in dgvSearchResults.SelectedRows)
            {
                Image image;
                Image thumb;

                try
                {
                    image = getCorrespondingImage(row.Cells[0].Value.ToString());
                    thumb = image.GetThumbnailImage(226, 219, () => false, IntPtr.Zero);
                }
                catch (Exception ee) //No image available, use noImageDefault
                {
                    thumb = getNoImagePic().GetThumbnailImage(226, 219, () => false, IntPtr.Zero);
                }

                imageAd.Image = thumb;
                lblAdTitle.Text = row.Cells[2].Value.ToString();
                lblPrice.Text = "Price: " +  row.Cells[5].Value.ToString();
                lblCondition.Text = "Condition: " + row.Cells[6].Value.ToString();
                //lblEmail.Text = row.Cells[2].Value.ToString();
                //lblPhone.Text = 
                txtAdDescription.Text = row.Cells[4].Value.ToString();
            }
                
            panelAdPanel.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgvSearchResults.BringToFront();
		  statusbar.Text = "You can try posting an ad of your own for free!";
		  statusStrip.Update();
        }

        public void toggleGreeting(string userName)
        {
            if (lblGreeting.Visible)
            {
                lblGreeting.Visible = false;
            }
            else
            {
                lblGreeting.Visible = true;
                lblGreeting.Text = "Hi, " + userName + "!";
            }
        }

        private void SendEmailBtn_Click(object sender, EventArgs e)
        {
            string body = EmailBodyInput.Text;


        }


    }
}
