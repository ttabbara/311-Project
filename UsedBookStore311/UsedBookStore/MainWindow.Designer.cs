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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewListingBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(827, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            this.btnSettings.Location = new System.Drawing.Point(659, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 2;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Search";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Author",
            "Course Code",
            "ISBN",
            "Title"});
            this.comboBox1.Location = new System.Drawing.Point(172, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(129, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 343);
            this.panel1.TabIndex = 8;
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button7.Location = new System.Drawing.Point(12, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 37);
            this.button7.TabIndex = 15;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(111, 37);
            this.button8.TabIndex = 16;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 421);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.NewListingBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmMainWindow";
            this.Text = "Bookstore";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.StatusStrip statusStrip1;
          private System.Windows.Forms.Button btnLogin;
          private System.Windows.Forms.Button btnSettings;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.ComboBox comboBox1;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Button NewListingBtn;
          private System.Windows.Forms.Button button3;
          private System.Windows.Forms.Button button4;
          private System.Windows.Forms.Button button6;
          private System.Windows.Forms.Button button7;
          private System.Windows.Forms.Button button8;
     }
}

