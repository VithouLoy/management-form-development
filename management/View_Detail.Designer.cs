namespace management
{
    partial class View_Detail
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
            this.label9 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.CheckBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currentPlace = new System.Windows.Forms.TextBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.placeOfBirth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.firstname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(787, 726);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 44;
            this.label9.Text = "Position";
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Enabled = false;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Java Developer ",
            "Php Developer",
            ".Net Developer ",
            "Software Tester",
            "Devops",
            ""});
            this.position.Location = new System.Drawing.Point(602, 754);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(438, 39);
            this.position.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(552, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Gender";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Enabled = false;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.female.Location = new System.Drawing.Point(615, 482);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(99, 29);
            this.female.TabIndex = 41;
            this.female.Text = "Female";
            this.female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Enabled = false;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.male.Location = new System.Drawing.Point(488, 482);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(77, 29);
            this.male.TabIndex = 40;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(521, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "Current Place";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // currentPlace
            // 
            this.currentPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPlace.Enabled = false;
            this.currentPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlace.Location = new System.Drawing.Point(54, 654);
            this.currentPlace.Name = "currentPlace";
            this.currentPlace.Size = new System.Drawing.Size(1054, 38);
            this.currentPlace.TabIndex = 38;
            this.currentPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profile
            // 
            this.profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile.Enabled = false;
            this.profile.Location = new System.Drawing.Point(498, 12);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(222, 216);
            this.profile.TabIndex = 24;
            this.profile.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(839, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Enabled = false;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(613, 374);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(492, 38);
            this.email.TabIndex = 35;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(536, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Birth Place";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // placeOfBirth
            // 
            this.placeOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeOfBirth.Enabled = false;
            this.placeOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeOfBirth.Location = new System.Drawing.Point(54, 569);
            this.placeOfBirth.Name = "placeOfBirth";
            this.placeOfBirth.Size = new System.Drawing.Size(1054, 38);
            this.placeOfBirth.TabIndex = 33;
            this.placeOfBirth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(279, 727);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Date of birth";
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.Enabled = false;
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Location = new System.Drawing.Point(98, 755);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(477, 38);
            this.dateOfBirth.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(271, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(824, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Lastname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(271, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Firstname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Enabled = false;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(51, 374);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(521, 38);
            this.phone.TabIndex = 27;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Enabled = false;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.Location = new System.Drawing.Point(613, 276);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(492, 38);
            this.lastname.TabIndex = 26;
            this.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // firstname
            // 
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Enabled = false;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(51, 276);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(521, 38);
            this.firstname.TabIndex = 25;
            this.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // View_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1148, 933);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.currentPlace);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.placeOfBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateOfBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.MaximumSize = new System.Drawing.Size(1166, 980);
            this.MinimumSize = new System.Drawing.Size(1166, 980);
            this.Name = "View_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Detail";
            this.Load += new System.EventHandler(this.View_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox currentPlace;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox placeOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox firstname;
    }
}