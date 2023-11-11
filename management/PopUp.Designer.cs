namespace management
{
    partial class PopUp
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
            this.accept = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.Color.SteelBlue;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.ForeColor = System.Drawing.Color.White;
            this.accept.Location = new System.Drawing.Point(35, 84);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(139, 54);
            this.accept.TabIndex = 0;
            this.accept.Text = "យល់ព្រម";
            this.accept.UseVisualStyleBackColor = false;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Red;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(185, 84);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(153, 54);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "បោះបង់";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(29, 32);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(95, 36);
            this.message.TabIndex = 2;
            this.message.Text = "message";
            // 
            // DeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 186);
            this.Controls.Add(this.message);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Name = "DeleteStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteStudent";
            this.Load += new System.EventHandler(this.DeleteStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label message;
    }
}