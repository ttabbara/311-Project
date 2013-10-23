namespace UsedBookStore
{
    partial class NewListingWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionLbl = new System.Windows.Forms.Label();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.HeadlineInput = new System.Windows.Forms.TextBox();
            this.DescriptionInput = new System.Windows.Forms.TextBox();
            this.CreateListingBtn = new System.Windows.Forms.Button();
            this.AllowPhoneChk = new System.Windows.Forms.CheckBox();
            this.AllowEmailChk = new System.Windows.Forms.CheckBox();
            this.BookInfoLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FacultyLbl = new System.Windows.Forms.Label();
            this.FacultyCdInput = new System.Windows.Forms.ComboBox();
            this.DeptCdInput = new System.Windows.Forms.ComboBox();
            this.CourseCdInput = new System.Windows.Forms.TextBox();
            this.ConditionLbl = new System.Windows.Forms.Label();
            this.ConditionInput = new System.Windows.Forms.ComboBox();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.TitleInput = new System.Windows.Forms.TextBox();
            this.ISBNLbl = new System.Windows.Forms.Label();
            this.ISBNInput = new System.Windows.Forms.TextBox();
            this.AskingPriceLbl = new System.Windows.Forms.Label();
            this.PriceInput = new System.Windows.Forms.TextBox();
            this.AuthorInput = new System.Windows.Forms.TextBox();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditionInput = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PriceInput);
            this.panel1.Controls.Add(this.AskingPriceLbl);
            this.panel1.Controls.Add(this.AllowEmailChk);
            this.panel1.Controls.Add(this.AllowPhoneChk);
            this.panel1.Controls.Add(this.DescriptionLbl);
            this.panel1.Controls.Add(this.DescriptionInput);
            this.panel1.Controls.Add(this.HeaderLbl);
            this.panel1.Controls.Add(this.HeadlineInput);
            this.panel1.Controls.Add(this.BookInfoLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 329);
            this.panel1.TabIndex = 0;
            // 
            // DescriptionLbl
            // 
            this.DescriptionLbl.AutoSize = true;
            this.DescriptionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLbl.Location = new System.Drawing.Point(122, 85);
            this.DescriptionLbl.Name = "DescriptionLbl";
            this.DescriptionLbl.Size = new System.Drawing.Size(121, 26);
            this.DescriptionLbl.TabIndex = 3;
            this.DescriptionLbl.Text = "Description";
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLbl.Location = new System.Drawing.Point(134, 33);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(98, 26);
            this.HeaderLbl.TabIndex = 1;
            this.HeaderLbl.Text = "Headline";
            // 
            // HeadlineInput
            // 
            this.HeadlineInput.Location = new System.Drawing.Point(12, 62);
            this.HeadlineInput.MaxLength = 75;
            this.HeadlineInput.Name = "HeadlineInput";
            this.HeadlineInput.Size = new System.Drawing.Size(332, 20);
            this.HeadlineInput.TabIndex = 0;
            // 
            // DescriptionInput
            // 
            this.DescriptionInput.Location = new System.Drawing.Point(12, 114);
            this.DescriptionInput.MaxLength = 300;
            this.DescriptionInput.Multiline = true;
            this.DescriptionInput.Name = "DescriptionInput";
            this.DescriptionInput.Size = new System.Drawing.Size(332, 109);
            this.DescriptionInput.TabIndex = 2;
            // 
            // CreateListingBtn
            // 
            this.CreateListingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateListingBtn.Location = new System.Drawing.Point(499, 288);
            this.CreateListingBtn.Name = "CreateListingBtn";
            this.CreateListingBtn.Size = new System.Drawing.Size(101, 32);
            this.CreateListingBtn.TabIndex = 4;
            this.CreateListingBtn.Text = "Create Listing";
            this.CreateListingBtn.UseVisualStyleBackColor = true;
            this.CreateListingBtn.Click += new System.EventHandler(this.CreateListingBtn_Click);
            // 
            // AllowPhoneChk
            // 
            this.AllowPhoneChk.AutoSize = true;
            this.AllowPhoneChk.Location = new System.Drawing.Point(295, 245);
            this.AllowPhoneChk.Name = "AllowPhoneChk";
            this.AllowPhoneChk.Size = new System.Drawing.Size(125, 17);
            this.AllowPhoneChk.TabIndex = 5;
            this.AllowPhoneChk.Text = "Allow Phone Contact";
            this.AllowPhoneChk.UseVisualStyleBackColor = true;
            // 
            // AllowEmailChk
            // 
            this.AllowEmailChk.AutoSize = true;
            this.AllowEmailChk.Location = new System.Drawing.Point(295, 268);
            this.AllowEmailChk.Name = "AllowEmailChk";
            this.AllowEmailChk.Size = new System.Drawing.Size(122, 17);
            this.AllowEmailChk.TabIndex = 6;
            this.AllowEmailChk.Text = "Allow E-mail Contact";
            this.AllowEmailChk.UseVisualStyleBackColor = true;
            // 
            // BookInfoLbl
            // 
            this.BookInfoLbl.AutoSize = true;
            this.BookInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookInfoLbl.Location = new System.Drawing.Point(461, 0);
            this.BookInfoLbl.Name = "BookInfoLbl";
            this.BookInfoLbl.Size = new System.Drawing.Size(177, 26);
            this.BookInfoLbl.TabIndex = 1;
            this.BookInfoLbl.Text = "Book Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Faculty Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(393, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Department Code:";
            // 
            // FacultyLbl
            // 
            this.FacultyLbl.AutoSize = true;
            this.FacultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyLbl.Location = new System.Drawing.Point(393, 97);
            this.FacultyLbl.Name = "FacultyLbl";
            this.FacultyLbl.Size = new System.Drawing.Size(101, 18);
            this.FacultyLbl.TabIndex = 4;
            this.FacultyLbl.Text = "Course Code:";
            // 
            // FacultyCdInput
            // 
            this.FacultyCdInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyCdInput.FormattingEnabled = true;
            this.FacultyCdInput.Location = new System.Drawing.Point(528, 41);
            this.FacultyCdInput.Name = "FacultyCdInput";
            this.FacultyCdInput.Size = new System.Drawing.Size(165, 21);
            this.FacultyCdInput.TabIndex = 5;
            this.FacultyCdInput.SelectedIndexChanged += new System.EventHandler(this.FacultyCdInput_SelectedIndexChanged);
            // 
            // DeptCdInput
            // 
            this.DeptCdInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptCdInput.FormattingEnabled = true;
            this.DeptCdInput.Location = new System.Drawing.Point(528, 67);
            this.DeptCdInput.Name = "DeptCdInput";
            this.DeptCdInput.Size = new System.Drawing.Size(165, 21);
            this.DeptCdInput.TabIndex = 6;
            // 
            // CourseCdInput
            // 
            this.CourseCdInput.Location = new System.Drawing.Point(528, 95);
            this.CourseCdInput.MaxLength = 3;
            this.CourseCdInput.Name = "CourseCdInput";
            this.CourseCdInput.Size = new System.Drawing.Size(72, 20);
            this.CourseCdInput.TabIndex = 7;
            // 
            // ConditionLbl
            // 
            this.ConditionLbl.AutoSize = true;
            this.ConditionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLbl.Location = new System.Drawing.Point(452, 254);
            this.ConditionLbl.Name = "ConditionLbl";
            this.ConditionLbl.Size = new System.Drawing.Size(75, 18);
            this.ConditionLbl.TabIndex = 8;
            this.ConditionLbl.Text = "Condition:";
            // 
            // ConditionInput
            // 
            this.ConditionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConditionInput.FormattingEnabled = true;
            this.ConditionInput.Location = new System.Drawing.Point(533, 251);
            this.ConditionInput.Name = "ConditionInput";
            this.ConditionInput.Size = new System.Drawing.Size(123, 21);
            this.ConditionInput.TabIndex = 9;
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(529, 120);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(38, 20);
            this.TitleLbl.TabIndex = 10;
            this.TitleLbl.Text = "Title";
            // 
            // TitleInput
            // 
            this.TitleInput.Location = new System.Drawing.Point(455, 143);
            this.TitleInput.Name = "TitleInput";
            this.TitleInput.Size = new System.Drawing.Size(201, 20);
            this.TitleInput.TabIndex = 11;
            // 
            // ISBNLbl
            // 
            this.ISBNLbl.AutoSize = true;
            this.ISBNLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBNLbl.Location = new System.Drawing.Point(452, 201);
            this.ISBNLbl.Name = "ISBNLbl";
            this.ISBNLbl.Size = new System.Drawing.Size(46, 18);
            this.ISBNLbl.TabIndex = 12;
            this.ISBNLbl.Text = "ISBN:";
            // 
            // ISBNInput
            // 
            this.ISBNInput.Location = new System.Drawing.Point(533, 198);
            this.ISBNInput.Name = "ISBNInput";
            this.ISBNInput.Size = new System.Drawing.Size(123, 20);
            this.ISBNInput.TabIndex = 13;
            // 
            // AskingPriceLbl
            // 
            this.AskingPriceLbl.AutoSize = true;
            this.AskingPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AskingPriceLbl.Location = new System.Drawing.Point(13, 242);
            this.AskingPriceLbl.Name = "AskingPriceLbl";
            this.AskingPriceLbl.Size = new System.Drawing.Size(164, 26);
            this.AskingPriceLbl.TabIndex = 7;
            this.AskingPriceLbl.Text = "Asking Price:  $";
            // 
            // PriceInput
            // 
            this.PriceInput.Location = new System.Drawing.Point(174, 245);
            this.PriceInput.MaxLength = 6;
            this.PriceInput.Name = "PriceInput";
            this.PriceInput.Size = new System.Drawing.Size(85, 20);
            this.PriceInput.TabIndex = 14;
            // 
            // AuthorInput
            // 
            this.AuthorInput.Location = new System.Drawing.Point(533, 172);
            this.AuthorInput.Name = "AuthorInput";
            this.AuthorInput.Size = new System.Drawing.Size(123, 20);
            this.AuthorInput.TabIndex = 15;
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorLbl.Location = new System.Drawing.Point(452, 175);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(51, 18);
            this.AuthorLbl.TabIndex = 14;
            this.AuthorLbl.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(452, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edition:";
            // 
            // EditionInput
            // 
            this.EditionInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditionInput.FormattingEnabled = true;
            this.EditionInput.Location = new System.Drawing.Point(533, 224);
            this.EditionInput.Name = "EditionInput";
            this.EditionInput.Size = new System.Drawing.Size(67, 21);
            this.EditionInput.TabIndex = 17;
            // 
            // NewListingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 326);
            this.Controls.Add(this.EditionInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthorInput);
            this.Controls.Add(this.AuthorLbl);
            this.Controls.Add(this.ISBNInput);
            this.Controls.Add(this.ISBNLbl);
            this.Controls.Add(this.TitleInput);
            this.Controls.Add(this.TitleLbl);
            this.Controls.Add(this.ConditionInput);
            this.Controls.Add(this.ConditionLbl);
            this.Controls.Add(this.CourseCdInput);
            this.Controls.Add(this.DeptCdInput);
            this.Controls.Add(this.CreateListingBtn);
            this.Controls.Add(this.FacultyCdInput);
            this.Controls.Add(this.FacultyLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "NewListingWindow";
            this.Text = "New Listing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DescriptionLbl;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.TextBox HeadlineInput;
        private System.Windows.Forms.TextBox DescriptionInput;
        private System.Windows.Forms.TextBox PriceInput;
        private System.Windows.Forms.Label AskingPriceLbl;
        private System.Windows.Forms.CheckBox AllowEmailChk;
        private System.Windows.Forms.CheckBox AllowPhoneChk;
        private System.Windows.Forms.Button CreateListingBtn;
        private System.Windows.Forms.Label BookInfoLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FacultyLbl;
        private System.Windows.Forms.ComboBox FacultyCdInput;
        private System.Windows.Forms.ComboBox DeptCdInput;
        private System.Windows.Forms.TextBox CourseCdInput;
        private System.Windows.Forms.Label ConditionLbl;
        private System.Windows.Forms.ComboBox ConditionInput;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.TextBox TitleInput;
        private System.Windows.Forms.Label ISBNLbl;
        private System.Windows.Forms.TextBox ISBNInput;
        private System.Windows.Forms.TextBox AuthorInput;
        private System.Windows.Forms.Label AuthorLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox EditionInput;
    }
}