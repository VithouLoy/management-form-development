namespace management
{
    partial class DisplayMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayMe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.modify = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.view_detail = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.export = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(205, 151);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.On_Cell_Click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "បញ្ចូលព័តមាន";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.insert_Click);
            // 
            // modify
            // 
            this.modify.BackColor = System.Drawing.Color.SteelBlue;
            this.modify.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify.ForeColor = System.Drawing.Color.White;
            this.modify.Location = new System.Drawing.Point(43, 287);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(142, 55);
            this.modify.TabIndex = 2;
            this.modify.Text = "កែប្រែទិន្នន័យ";
            this.modify.UseVisualStyleBackColor = false;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.SteelBlue;
            this.Delete.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(43, 418);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(142, 55);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "លុបទិន្នន័យ";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // view_detail
            // 
            this.view_detail.BackColor = System.Drawing.Color.SteelBlue;
            this.view_detail.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_detail.ForeColor = System.Drawing.Color.White;
            this.view_detail.Location = new System.Drawing.Point(43, 551);
            this.view_detail.Name = "view_detail";
            this.view_detail.Size = new System.Drawing.Size(142, 55);
            this.view_detail.TabIndex = 4;
            this.view_detail.Text = "មើលទិន្នន័យ";
            this.view_detail.UseVisualStyleBackColor = false;
            this.view_detail.Click += new System.EventHandler(this.view_detail_Click);
            // 
            // find
            // 
            this.find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.find.Location = new System.Drawing.Point(205, 114);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(180, 26);
            this.find.TabIndex = 5;
            this.find.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(200, 84);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(57, 27);
            this.Search.TabIndex = 6;
            this.Search.Text = "ស្វែងរក";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // export
            // 
            this.export.BackColor = System.Drawing.Color.SteelBlue;
            this.export.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.Location = new System.Drawing.Point(205, 623);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(142, 55);
            this.export.TabIndex = 9;
            this.export.Text = "នាំចេញ";
            this.export.UseVisualStyleBackColor = false;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(382, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "នាំចូល";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.import_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Khmer OS Battambang", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1020, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "ចាកចេញ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1024, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // DisplayMe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1219, 728);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.export);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.find);
            this.Controls.Add(this.view_detail);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DisplayMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System";
            this.Load += new System.EventHandler(this.DisplayMe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button view_detail;
        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}