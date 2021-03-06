﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Mail;

namespace UsedBookStore
{
    public partial class frmMainWindow : Form
    {
        Controller controller;

        private User currentAdUserInfo;

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

                int userID = Convert.ToInt32(row["PosterID"].ToString());
                User currentUserInfo = DatabaseManager.getUserInfo(userID);

                if (row["Image"].ToString() != "")
                {
                    Image image = DatabaseManager.byteArrayToImage(row["Image"] as Byte[]);
                    Image thumb = image.GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                    dgvSearchResults.Rows.Add(row["ListingID"].ToString() + "", thumb, row["Header"].ToString(), currentUserInfo.Username, row["Desc"].ToString(), "$" + row["Price"].ToString(), row["Condition"].ToString());
                }
                else
                {
                    Image thumb = getNoImagePic().GetThumbnailImage(120, 120, () => false, IntPtr.Zero);
                    dgvSearchResults.Rows.Add(row["ListingID"].ToString() + "", thumb, row["Header"].ToString(), currentUserInfo.Username, row["Desc"].ToString(), "$" + row["Price"].ToString(), row["Condition"].ToString());
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
            displaySearchResults(cachedResultTable = controller.getMyListings(controller.getUser().ID));
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
            foreach (DataGridViewRow row in dgvSearchResults.SelectedRows)
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
                string username = row.Cells[3].Value.ToString();

                currentAdUserInfo = DatabaseManager.getUserInfo(username);

                if (currentAdUserInfo != null)
                {
                    lblAdTitle.Text = row.Cells[2].Value.ToString();
                    lblEmail.Text = "Contact Email: " + currentAdUserInfo.UserEmail;
                    lblPhone.Text = "Phone: " + currentAdUserInfo.UserPhoneNumber;
                    lblPrice.Text = "Price: " + row.Cells[5].Value.ToString();
                    lblCondition.Text = "Condition: " + row.Cells[6].Value.ToString();
                    txtAdDescription.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    MessageBox.Show("Sorry, could not find this user.");
                }
            }

            panelAdPanel.BringToFront();

            this.DeleteListingBtn.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            dgvSearchResults.BringToFront();

            statusbar.Text = "You can try posting an ad of your own for free!";
            statusStrip.Update();

            this.DeleteListingBtn.Visible = true;
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
            //if there is no ad user
            if (currentAdUserInfo == null)
            {
                MessageBox.Show("There was an error getting the poster's email, please re-open this ad.");
                return;
            }

            MailMessage message = new MailMessage();

            message.Subject = "Your ad was responded to!";

            message.Body = EmailBodyInput.Text;

            message.BodyEncoding = Encoding.GetEncoding("Windows-1254"); // Turkish Character Encoding

            message.From = new MailAddress("311bookstore@gmail.com");

            message.To.Add(new MailAddress(currentAdUserInfo.UserEmail));

            System.Net.Mail.SmtpClient Smtp = new SmtpClient();

            Smtp.Host = "smtp.gmail.com";

            Smtp.Port = 25;

            Smtp.EnableSsl = true;

            Smtp.Credentials = new System.Net.NetworkCredential("311bookstore@gmail.com", "311project");

            try
            {
                statusbar.Text = "Sending email... Please wait...";
                statusStrip.Update();

                Smtp.Send(message);
                MessageBox.Show("Your message has been sent!");
                EmailBodyInput.Text = string.Empty;

                statusbar.Text = "Email Successful!";
                statusStrip.Update();
            }
            catch (Exception mailException)
            {
                MessageBox.Show("Sending mail has failed at this time. Sorry.");

                statusbar.Text = "Email failed.";
                statusStrip.Update();
            }

            Smtp.Dispose();
            message.Dispose();
        }

        private void DeleteListingBtn_Click(object sender, EventArgs e)
        {

            if (dgvSearchResults.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an Ad to open first.");
                return;
            }

            if (!this.controller.isUserLoggedIn())
            {
                MessageBox.Show("Please log in to delete your ad.");
                return;
            }

            foreach (DataGridViewRow row in dgvSearchResults.SelectedRows)
            {
                int currentUserID = DatabaseManager.getUserID(row.Cells[3].Value.ToString());

                if (currentUserID == this.controller.getUser().ID)
                {
                    int listingID = Convert.ToInt32(row.Cells[0].Value);

                    DatabaseManager.deleteListing(listingID);
                }

                dgvSearchResults.Rows.RemoveAt(row.Index);
            }

        }


    }
}
