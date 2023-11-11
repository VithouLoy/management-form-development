namespace management
{
    partial class ExportData
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
            this.position = new System.Windows.Forms.ComboBox();
            this.export = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // position
            // 
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "EXCEL",
            "CSV",
            "JSON"});
            this.position.Location = new System.Drawing.Point(29, 71);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(268, 33);
            this.position.TabIndex = 23;
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.SteelBlue;
            this.export.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.Location = new System.Drawing.Point(306, 61);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(142, 55);
            this.export.TabIndex = 24;
            this.export.Text = "រក្សាទុក";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 25;
            this.label1.Text = "ប្រភេទ";
            // 
            // ExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.export);
            this.Controls.Add(this.position);
            this.Name = "ExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExportData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Label label1;
    }
}