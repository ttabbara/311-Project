namespace UsedBookStore
{
    partial class frmLogin
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblRegUser = new System.Windows.Forms.Label();
            this.lblRegPW = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtConfirmPW = new System.Windows.Forms.TextBox();
            this.txtRegPW = new System.Windows.Forms.TextBox();
            this.txtRegUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(16, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(91, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User Name";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(16, 85);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(81, 17);
            this.lblPass.TabIndex = 1;
            this.lblPass.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(182, 27);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(338, 27);
            this.txtUser.TabIndex = 2;
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(182, 82);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(338, 27);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblNewUser
            // 
            this.lblNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewUser.Location = new System.Drawing.Point(190, 215);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(156, 17);
            this.lblNewUser.TabIndex = 4;
            this.lblNewUser.Text = "New User? Sign up!";
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(182, 473);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(187, 41);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Sign up!";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(107, 139);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(328, 41);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblRegUser
            // 
            this.lblRegUser.AutoSize = true;
            this.lblRegUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegUser.Location = new System.Drawing.Point(16, 265);
            this.lblRegUser.Name = "lblRegUser";
            this.lblRegUser.Size = new System.Drawing.Size(91, 17);
            this.lblRegUser.TabIndex = 7;
            this.lblRegUser.Text = "User Name";
            // 
            // lblRegPW
            // 
            this.lblRegPW.AutoSize = true;
            this.lblRegPW.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPW.Location = new System.Drawing.Point(16, 301);
            this.lblRegPW.Name = "lblRegPW";
            this.lblRegPW.Size = new System.Drawing.Size(81, 17);
            this.lblRegPW.TabIndex = 8;
            this.lblRegPW.Text = "Password";
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.Location = new System.Drawing.Point(16, 342);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(149, 17);
            this.lblConfirm.TabIndex = 9;
            this.lblConfirm.Text = "Confirm Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(16, 382);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(188, 17);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail (For ad contact)";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(16, 420);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(197, 17);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "Phone # (for ad contact)";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(264, 417);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(277, 27);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(264, 379);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(277, 27);
            this.txtEmail.TabIndex = 8;
            // 
            // txtConfirmPW
            // 
            this.txtConfirmPW.Location = new System.Drawing.Point(264, 339);
            this.txtConfirmPW.Name = "txtConfirmPW";
            this.txtConfirmPW.Size = new System.Drawing.Size(277, 27);
            this.txtConfirmPW.TabIndex = 7;
            this.txtConfirmPW.UseSystemPasswordChar = true;
            this.txtConfirmPW.TextChanged += new System.EventHandler(this.txtConfirmPW_TextChanged);
            // 
            // txtRegPW
            // 
            this.txtRegPW.Location = new System.Drawing.Point(264, 298);
            this.txtRegPW.Name = "txtRegPW";
            this.txtRegPW.Size = new System.Drawing.Size(277, 27);
            this.txtRegPW.TabIndex = 6;
            this.txtRegPW.UseSystemPasswordChar = true;
            // 
            // txtRegUser
            // 
            this.txtRegUser.Location = new System.Drawing.Point(264, 262);
            this.txtRegUser.Name = "txtRegUser";
            this.txtRegUser.Size = new System.Drawing.Size(277, 27);
            this.txtRegUser.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 528);
            this.Controls.Add(this.txtRegUser);
            this.Controls.Add(this.txtRegPW);
            this.Controls.Add(this.txtConfirmPW);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblRegPW);
            this.Controls.Add(this.lblRegUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblNewUser;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblRegUser;
        private System.Windows.Forms.Label lblRegPW;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmPW;
        private System.Windows.Forms.TextBox txtRegPW;
        private System.Windows.Forms.TextBox txtRegUser;
    }
}