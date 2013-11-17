namespace UsedBookStore
{
     partial class frmMainWindow
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusbar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.NewListingBtn = new System.Windows.Forms.Button();
            this.MyListingBtn = new System.Windows.Forms.Button();
            this.RecBookBtn = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.adNumberCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.adTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adCondition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpenAd = new System.Windows.Forms.Button();
            this.panelAdPanel = new System.Windows.Forms.Panel();
            this.SendEmailBtn = new System.Windows.Forms.Button();
            this.EmailSellerLbl = new System.Windows.Forms.Label();
            this.EmailBodyInput = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAdDescription = new System.Windows.Forms.TextBox();
            this.lblAdTitle = new System.Windows.Forms.Label();
            this.imageAd = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.panelAdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusbar});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(976, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusbar
            // 
            this.statusbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(0, 17);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Location = new System.Drawing.Point(863, 14);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 27);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Location = new System.Drawing.Point(762, 14);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(87, 27);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = true;
            this.searchBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchBox.Location = new System.Drawing.Point(9, 16);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(184, 23);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "[Search Here]";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_CheckEnter);
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchComboBox.Items.AddRange(new object[] {
            "Author",
            "Course Code",
            "ISBN",
            "Title"});
            this.searchComboBox.Location = new System.Drawing.Point(201, 16);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(140, 23);
            this.searchComboBox.Sorted = true;
            this.searchComboBox.TabIndex = 7;
            // 
            // NewListingBtn
            // 
            this.NewListingBtn.BackColor = System.Drawing.Color.Gold;
            this.NewListingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewListingBtn.Location = new System.Drawing.Point(9, 196);
            this.NewListingBtn.Name = "NewListingBtn";
            this.NewListingBtn.Size = new System.Drawing.Size(162, 43);
            this.NewListingBtn.TabIndex = 11;
            this.NewListingBtn.Text = "Post a Listing";
            this.NewListingBtn.UseVisualStyleBackColor = false;
            this.NewListingBtn.Click += new System.EventHandler(this.NewListingBtn_Click);
            // 
            // MyListingBtn
            // 
            this.MyListingBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MyListingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MyListingBtn.Location = new System.Drawing.Point(9, 97);
            this.MyListingBtn.Name = "MyListingBtn";
            this.MyListingBtn.Size = new System.Drawing.Size(162, 43);
            this.MyListingBtn.TabIndex = 12;
            this.MyListingBtn.Text = "My Listings";
            this.MyListingBtn.UseVisualStyleBackColor = false;
            this.MyListingBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // RecBookBtn
            // 
            this.RecBookBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.RecBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RecBookBtn.Location = new System.Drawing.Point(9, 147);
            this.RecBookBtn.Name = "RecBookBtn";
            this.RecBookBtn.Size = new System.Drawing.Size(162, 43);
            this.RecBookBtn.TabIndex = 13;
            this.RecBookBtn.Text = "Recommended Books";
            this.RecBookBtn.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(9, 47);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(162, 43);
            this.button6.TabIndex = 14;
            this.button6.Text = "Home";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.AllowUserToAddRows = false;
            this.dgvSearchResults.AllowUserToDeleteRows = false;
            this.dgvSearchResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adNumberCol,
            this.adImage,
            this.adTitle,
            this.adAuthor,
            this.adDesc,
            this.adPrice,
            this.adCondition});
            this.dgvSearchResults.Location = new System.Drawing.Point(180, 47);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(771, 445);
            this.dgvSearchResults.TabIndex = 15;
            // 
            // adNumberCol
            // 
            this.adNumberCol.HeaderText = "ID";
            this.adNumberCol.Name = "adNumberCol";
            this.adNumberCol.ReadOnly = true;
            this.adNumberCol.Width = 25;
            // 
            // adImage
            // 
            this.adImage.HeaderText = "Image";
            this.adImage.Name = "adImage";
            this.adImage.ReadOnly = true;
            // 
            // adTitle
            // 
            this.adTitle.HeaderText = "Title";
            this.adTitle.Name = "adTitle";
            this.adTitle.ReadOnly = true;
            // 
            // adAuthor
            // 
            this.adAuthor.HeaderText = "Posted By";
            this.adAuthor.Name = "adAuthor";
            this.adAuthor.ReadOnly = true;
            // 
            // adDesc
            // 
            this.adDesc.HeaderText = "Description";
            this.adDesc.Name = "adDesc";
            this.adDesc.ReadOnly = true;
            // 
            // adPrice
            // 
            this.adPrice.HeaderText = "Price";
            this.adPrice.Name = "adPrice";
            this.adPrice.ReadOnly = true;
            // 
            // adCondition
            // 
            this.adCondition.HeaderText = "Condition";
            this.adCondition.Name = "adCondition";
            this.adCondition.ReadOnly = true;
            this.adCondition.Width = 75;
            // 
            // btnOpenAd
            // 
            this.btnOpenAd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenAd.Location = new System.Drawing.Point(808, 500);
            this.btnOpenAd.Name = "btnOpenAd";
            this.btnOpenAd.Size = new System.Drawing.Size(139, 27);
            this.btnOpenAd.TabIndex = 16;
            this.btnOpenAd.Text = "Open Ad";
            this.btnOpenAd.UseVisualStyleBackColor = true;
            this.btnOpenAd.Click += new System.EventHandler(this.btnOpenAd_Click);
            // 
            // panelAdPanel
            // 
            this.panelAdPanel.Controls.Add(this.SendEmailBtn);
            this.panelAdPanel.Controls.Add(this.EmailSellerLbl);
            this.panelAdPanel.Controls.Add(this.EmailBodyInput);
            this.panelAdPanel.Controls.Add(this.lblPhone);
            this.panelAdPanel.Controls.Add(this.lblEmail);
            this.panelAdPanel.Controls.Add(this.lblCondition);
            this.panelAdPanel.Controls.Add(this.lblPrice);
            this.panelAdPanel.Controls.Add(this.txtAdDescription);
            this.panelAdPanel.Controls.Add(this.lblAdTitle);
            this.panelAdPanel.Controls.Add(this.imageAd);
            this.panelAdPanel.Location = new System.Drawing.Point(180, 46);
            this.panelAdPanel.Name = "panelAdPanel";
            this.panelAdPanel.Size = new System.Drawing.Size(771, 447);
            this.panelAdPanel.TabIndex = 17;
            // 
            // SendEmailBtn
            // 
            this.SendEmailBtn.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendEmailBtn.Location = new System.Drawing.Point(597, 224);
            this.SendEmailBtn.Name = "SendEmailBtn";
            this.SendEmailBtn.Size = new System.Drawing.Size(81, 43);
            this.SendEmailBtn.TabIndex = 9;
            this.SendEmailBtn.Text = "Send Email";
            this.SendEmailBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SendEmailBtn.UseVisualStyleBackColor = true;
            this.SendEmailBtn.Click += new System.EventHandler(this.SendEmailBtn_Click);
            // 
            // EmailSellerLbl
            // 
            this.EmailSellerLbl.AutoSize = true;
            this.EmailSellerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailSellerLbl.Location = new System.Drawing.Point(516, 84);
            this.EmailSellerLbl.Name = "EmailSellerLbl";
            this.EmailSellerLbl.Size = new System.Drawing.Size(110, 24);
            this.EmailSellerLbl.TabIndex = 8;
            this.EmailSellerLbl.Text = "Email Seller";
            // 
            // EmailBodyInput
            // 
            this.EmailBodyInput.Location = new System.Drawing.Point(520, 123);
            this.EmailBodyInput.Multiline = true;
            this.EmailBodyInput.Name = "EmailBodyInput";
            this.EmailBodyInput.Size = new System.Drawing.Size(229, 95);
            this.EmailBodyInput.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(292, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 18);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Contact Phone: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(292, 159);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Contact Email:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(292, 122);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(75, 18);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Condition:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(290, 84);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price Goes Here";
            // 
            // txtAdDescription
            // 
            this.txtAdDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdDescription.Location = new System.Drawing.Point(21, 273);
            this.txtAdDescription.Multiline = true;
            this.txtAdDescription.Name = "txtAdDescription";
            this.txtAdDescription.ReadOnly = true;
            this.txtAdDescription.Size = new System.Drawing.Size(728, 155);
            this.txtAdDescription.TabIndex = 2;
            // 
            // lblAdTitle
            // 
            this.lblAdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdTitle.Location = new System.Drawing.Point(292, 16);
            this.lblAdTitle.Name = "lblAdTitle";
            this.lblAdTitle.Size = new System.Drawing.Size(476, 62);
            this.lblAdTitle.TabIndex = 1;
            this.lblAdTitle.Text = "Ad Title Goes Here";
            this.lblAdTitle.Click += new System.EventHandler(this.lblAdTitle_Click);
            // 
            // imageAd
            // 
            this.imageAd.Location = new System.Drawing.Point(21, 14);
            this.imageAd.Name = "imageAd";
            this.imageAd.Size = new System.Drawing.Size(264, 253);
            this.imageAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageAd.TabIndex = 0;
            this.imageAd.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Location = new System.Drawing.Point(666, 500);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 27);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back to list";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(553, 10);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(78, 20);
            this.lblGreeting.TabIndex = 19;
            this.lblGreeting.Text = "Hi, Name!";
            this.lblGreeting.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UsedBookStore.Properties.Resources.Uwin;
            this.pictureBox1.Location = new System.Drawing.Point(9, 246);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 230);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(976, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpenAd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.RecBookBtn);
            this.Controls.Add(this.MyListingBtn);
            this.Controls.Add(this.NewListingBtn);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.panelAdPanel);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainWindow";
            this.Text = "UWDb";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.panelAdPanel.ResumeLayout(false);
            this.panelAdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.StatusStrip statusStrip;
          private System.Windows.Forms.Button btnLogin;
          private System.Windows.Forms.Button btnSettings;
          private System.Windows.Forms.TextBox searchBox;
          private System.Windows.Forms.ComboBox searchComboBox;
          private System.Windows.Forms.Button NewListingBtn;
          private System.Windows.Forms.Button MyListingBtn;
          private System.Windows.Forms.Button RecBookBtn;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ToolStripStatusLabel statusbar;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Button btnOpenAd;
        private System.Windows.Forms.Panel panelAdPanel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtAdDescription;
        private System.Windows.Forms.Label lblAdTitle;
        private System.Windows.Forms.PictureBox imageAd;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.DataGridViewTextBoxColumn adNumberCol;
        private System.Windows.Forms.DataGridViewImageColumn adImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn adTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn adAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn adPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn adCondition;
	   private System.Windows.Forms.PictureBox pictureBox1;
       private System.Windows.Forms.Button SendEmailBtn;
       private System.Windows.Forms.Label EmailSellerLbl;
       private System.Windows.Forms.TextBox EmailBodyInput;
     }
}

