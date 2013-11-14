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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.NewListingBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAdDescription = new System.Windows.Forms.TextBox();
            this.lblAdTitle = new System.Windows.Forms.Label();
            this.imageAd = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.panelAdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAd)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusBar.Location = new System.Drawing.Point(0, 459);
            this.statusBar.Name = "statusBar";
            this.statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusBar.Size = new System.Drawing.Size(837, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 17);
            this.toolStripStatusLabel1.Text = "Welcome!";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(740, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(653, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            // 
            // searchBox
            // 
            this.searchBox.AcceptsReturn = true;
            this.searchBox.Location = new System.Drawing.Point(10, 14);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(156, 20);
            this.searchBox.TabIndex = 3;
            this.searchBox.Text = "[Search Here]";
            this.searchBox.Click += new System.EventHandler(this.searchBox_Click);
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_CheckEnter);
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.Items.AddRange(new object[] {
            "Author",
            "Course Code",
            "ISBN",
            "Title"});
            this.searchComboBox.Location = new System.Drawing.Point(172, 14);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(121, 21);
            this.searchComboBox.Sorted = true;
            this.searchComboBox.TabIndex = 7;
            // 
            // NewListingBtn
            // 
            this.NewListingBtn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.NewListingBtn.Location = new System.Drawing.Point(12, 170);
            this.NewListingBtn.Name = "NewListingBtn";
            this.NewListingBtn.Size = new System.Drawing.Size(111, 37);
            this.NewListingBtn.TabIndex = 11;
            this.NewListingBtn.Text = "Post a Listing";
            this.NewListingBtn.UseVisualStyleBackColor = false;
            this.NewListingBtn.Click += new System.EventHandler(this.NewListingBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(12, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 12;
            this.button3.Text = "My Listings";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(12, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 37);
            this.button4.TabIndex = 13;
            this.button4.Text = "Recommended Books";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button6.Location = new System.Drawing.Point(12, 41);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 37);
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
            this.dgvSearchResults.Location = new System.Drawing.Point(154, 41);
            this.dgvSearchResults.MultiSelect = false;
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.ReadOnly = true;
            this.dgvSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchResults.Size = new System.Drawing.Size(661, 386);
            this.dgvSearchResults.TabIndex = 15;
            // 
            // adNumberCol
            // 
            this.adNumberCol.HeaderText = "#";
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
            this.btnOpenAd.Location = new System.Drawing.Point(693, 433);
            this.btnOpenAd.Name = "btnOpenAd";
            this.btnOpenAd.Size = new System.Drawing.Size(119, 23);
            this.btnOpenAd.TabIndex = 16;
            this.btnOpenAd.Text = "Open Ad";
            this.btnOpenAd.UseVisualStyleBackColor = true;
            this.btnOpenAd.Click += new System.EventHandler(this.btnOpenAd_Click);
            // 
            // panelAdPanel
            // 
            this.panelAdPanel.Controls.Add(this.lblPhone);
            this.panelAdPanel.Controls.Add(this.lblEmail);
            this.panelAdPanel.Controls.Add(this.lblCondition);
            this.panelAdPanel.Controls.Add(this.lblPrice);
            this.panelAdPanel.Controls.Add(this.txtAdDescription);
            this.panelAdPanel.Controls.Add(this.lblAdTitle);
            this.panelAdPanel.Controls.Add(this.imageAd);
            this.panelAdPanel.Location = new System.Drawing.Point(154, 40);
            this.panelAdPanel.Name = "panelAdPanel";
            this.panelAdPanel.Size = new System.Drawing.Size(661, 387);
            this.panelAdPanel.TabIndex = 17;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(250, 173);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(115, 18);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Contact Phone: ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(250, 138);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(105, 18);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Contact Email:";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(250, 106);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(75, 18);
            this.lblCondition.TabIndex = 4;
            this.lblCondition.Text = "Condition:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(249, 73);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 24);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price Goes Here";
            // 
            // txtAdDescription
            // 
            this.txtAdDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtAdDescription.Location = new System.Drawing.Point(18, 237);
            this.txtAdDescription.Multiline = true;
            this.txtAdDescription.Name = "txtAdDescription";
            this.txtAdDescription.ReadOnly = true;
            this.txtAdDescription.Size = new System.Drawing.Size(625, 135);
            this.txtAdDescription.TabIndex = 2;
            // 
            // lblAdTitle
            // 
            this.lblAdTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdTitle.Location = new System.Drawing.Point(250, 14);
            this.lblAdTitle.Name = "lblAdTitle";
            this.lblAdTitle.Size = new System.Drawing.Size(408, 54);
            this.lblAdTitle.TabIndex = 1;
            this.lblAdTitle.Text = "Ad Title Goes Here";
            this.lblAdTitle.Click += new System.EventHandler(this.lblAdTitle_Click);
            // 
            // imageAd
            // 
            this.imageAd.Location = new System.Drawing.Point(18, 12);
            this.imageAd.Name = "imageAd";
            this.imageAd.Size = new System.Drawing.Size(226, 219);
            this.imageAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imageAd.TabIndex = 0;
            this.imageAd.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(571, 433);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 23);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back to list";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(474, 9);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(78, 20);
            this.lblGreeting.TabIndex = 19;
            this.lblGreeting.Text = "Hi, Name!";
            this.lblGreeting.Visible = false;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 481);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpenAd);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NewListingBtn);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.panelAdPanel);
            this.Name = "frmMainWindow";
            this.Text = "Bookstore";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.panelAdPanel.ResumeLayout(false);
            this.panelAdPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.StatusStrip statusBar;
          private System.Windows.Forms.Button btnLogin;
          private System.Windows.Forms.Button btnSettings;
          private System.Windows.Forms.TextBox searchBox;
          private System.Windows.Forms.ComboBox searchComboBox;
          private System.Windows.Forms.Button NewListingBtn;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn adNumberCol;
        private System.Windows.Forms.DataGridViewImageColumn adImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn adTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn adAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn adPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn adCondition;
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
     }
}

