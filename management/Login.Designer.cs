namespace management
{
    partial class Authentication
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.forgot_password = new System.Windows.Forms.LinkLabel();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(147, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.White;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.SystemColors.MenuText;
            this.username.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.username.Location = new System.Drawing.Point(153, 163);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(289, 43);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.txt_username);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.login.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(197, 369);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(213, 45);
            this.login.TabIndex = 2;
            this.login.Text = "Login";
            this.login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login.UseVisualStyleBackColor = false;
            this.login.TextChanged += new System.EventHandler(this.txt_login);
            this.login.Click += new System.EventHandler(this.login_btn);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new System.Drawing.Point(344, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 704);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.linkLabel2);
            this.panel3.Controls.Add(this.username);
            this.panel3.Controls.Add(this.forgot_password);
            this.panel3.Controls.Add(this.password);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.login);
            this.panel3.Location = new System.Drawing.Point(77, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 537);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel2.Location = new System.Drawing.Point(265, 445);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 25);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Sign up";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_btn);
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.forgot_password.Location = new System.Drawing.Point(230, 327);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(159, 25);
            this.forgot_password.TabIndex = 5;
            this.forgot_password.TabStop = true;
            this.forgot_password.Text = "Forgot Password";
            this.forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgotpassword_link);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(153, 265);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(289, 43);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.txt_password);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(147, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "User Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 704);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(89, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 154);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Authentication
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1003, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox username;
        private global::System.Windows.Forms.Button login;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.TextBox password;
        private global::System.Windows.Forms.Panel panel2;
        private global::System.Windows.Forms.PictureBox pictureBox1;
        private global::System.Windows.Forms.LinkLabel forgot_password;
        private global::System.Windows.Forms.LinkLabel linkLabel2;
        private global::System.Windows.Forms.Panel panel3;
    }
}

