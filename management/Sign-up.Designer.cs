namespace management
{
    partial class Form2
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
            this.textBox1 = new global::System.Windows.Forms.TextBox();
            this.textBox2 = new global::System.Windows.Forms.TextBox();
            this.panel1 = new global::System.Windows.Forms.Panel();
            this.textBox3 = new global::System.Windows.Forms.TextBox();
            this.label1 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.button1 = new global::System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new global::System.Drawing.Point(63, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new global::System.Drawing.Size(360, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new global::System.Drawing.Point(63, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '•';
            this.textBox2.Size = new global::System.Drawing.Size(360, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            this.textBox2.TextChanged += new global::System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panel1.Location = new global::System.Drawing.Point(63, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new global::System.Drawing.Size(444, 320);
            this.panel1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new global::System.Drawing.Point(63, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '•';
            this.textBox3.Size = new global::System.Drawing.Size(357, 38);
            this.textBox3.TabIndex = 2;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new global::System.Drawing.Point(61, -2);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(110, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            this.label1.Click += new global::System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new global::System.Drawing.Point(58, 80);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new global::System.Drawing.Point(58, 159);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(171, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            this.label3.Click += new global::System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new global::System.Drawing.Point(174, 240);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(147, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new global::System.Drawing.Size(543, 386);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new global::System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.TextBox textBox1;
        private global::System.Windows.Forms.TextBox textBox2;
        private global::System.Windows.Forms.Panel panel1;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox textBox3;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Button button1;
    }
}