namespace management
{
    partial class Insert_Student
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
            this.components = new System.ComponentModel.Container();
            this.firstname = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.placeOfBirth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.PictureBox();
            this.currentPlace = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.CheckBox();
            this.female = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstname
            // 
            this.firstname.BackColor = System.Drawing.SystemColors.Window;
            this.firstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.firstname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.firstname.Location = new System.Drawing.Point(107, 100);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(262, 34);
            this.firstname.TabIndex = 3;
            this.firstname.TextChanged += new System.EventHandler(this.firstname_TextChanged);
            // 
            // lastname
            // 
            this.lastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lastname.Location = new System.Drawing.Point(425, 100);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(262, 34);
            this.lastname.TabIndex = 4;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // phone
            // 
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.phone.Location = new System.Drawing.Point(107, 502);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(262, 34);
            this.phone.TabIndex = 5;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "នាម";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "ត្រកូល";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "លេខទូរស័ព្ទ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd-MM-yyyy";
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateOfBirth.Location = new System.Drawing.Point(428, 199);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateOfBirth.Size = new System.Drawing.Size(262, 34);
            this.dateOfBirth.TabIndex = 9;
            this.dateOfBirth.Value = new System.DateTime(2002, 10, 7, 0, 0, 0, 0);
            this.dateOfBirth.ValueChanged += new System.EventHandler(this.dateOfBirth_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(425, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "ទីកន្លែងកំណើត";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // placeOfBirth
            // 
            this.placeOfBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.placeOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.placeOfBirth.Location = new System.Drawing.Point(110, 291);
            this.placeOfBirth.Multiline = true;
            this.placeOfBirth.Name = "placeOfBirth";
            this.placeOfBirth.Size = new System.Drawing.Size(262, 148);
            this.placeOfBirth.TabIndex = 11;
            this.placeOfBirth.TextChanged += new System.EventHandler(this.placeOfBirth_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 36);
            this.label6.TabIndex = 14;
            this.label6.Text = "អ៊ីមែល";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.email.Location = new System.Drawing.Point(110, 199);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(262, 34);
            this.email.TabIndex = 13;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.SteelBlue;
            this.submit.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(428, 475);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(265, 92);
            this.submit.TabIndex = 15;
            this.submit.Text = "បញ្ជូន";
            this.submit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // choose
            // 
            this.choose.BackColor = System.Drawing.Color.SteelBlue;
            this.choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose.ForeColor = System.Drawing.Color.White;
            this.choose.Location = new System.Drawing.Point(797, 452);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(188, 43);
            this.choose.TabIndex = 16;
            this.choose.Text = "ជ្រើសរើស";
            this.choose.UseVisualStyleBackColor = false;
            this.choose.Click += new System.EventHandler(this.button2_Click);
            // 
            // profile
            // 
            this.profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profile.Location = new System.Drawing.Point(761, 291);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(258, 148);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profile.TabIndex = 2;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // currentPlace
            // 
            this.currentPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.currentPlace.Location = new System.Drawing.Point(428, 291);
            this.currentPlace.Multiline = true;
            this.currentPlace.Name = "currentPlace";
            this.currentPlace.Size = new System.Drawing.Size(265, 148);
            this.currentPlace.TabIndex = 17;
            this.currentPlace.TextChanged += new System.EventHandler(this.currentPlace_TextChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(45, -3);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(79, 40);
            this.male.TabIndex = 19;
            this.male.Text = "ប្រុស";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(146, -1);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(65, 40);
            this.female.TabIndex = 20;
            this.female.Text = "ស្រី";
            this.female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(745, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "ភេទ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Java Developer ",
            "Php Developer",
            ".Net Developer ",
            "Software Tester",
            "Devops",
            ""});
            this.position.Location = new System.Drawing.Point(751, 197);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(268, 37);
            this.position.TabIndex = 22;
            this.position.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 36);
            this.label10.TabIndex = 25;
            this.label10.Text = "ទីលំនៅបច្ចុប្បន្ន";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(745, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "ជំនាញ";
            this.label7.Click += new System.EventHandler(this.label7_Click_1);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.female);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.panel1.Location = new System.Drawing.Point(751, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 36);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(755, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 36);
            this.label9.TabIndex = 28;
            this.label9.Text = "រូបថត";
            this.label9.Click += new System.EventHandler(this.label9_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Battambang", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(411, -79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 77);
            this.label11.TabIndex = 29;
            // 
            // Insert_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1132, 615);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.position);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.currentPlace);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.submit);
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
            this.Name = "Insert_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Insert_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.TextBox lastname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox placeOfBirth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.PictureBox profile;
        private System.Windows.Forms.TextBox currentPlace;
        private System.Windows.Forms.CheckBox male;
        private System.Windows.Forms.CheckBox female;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}