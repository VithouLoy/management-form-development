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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.view_detail = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.achive = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(160, 73);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(992, 455);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.On_Cell_Click);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(12, 283);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(142, 55);
            this.Delete.TabIndex = 3;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // view_detail
            // 
            this.view_detail.Location = new System.Drawing.Point(12, 381);
            this.view_detail.Name = "view_detail";
            this.view_detail.Size = new System.Drawing.Size(142, 55);
            this.view_detail.TabIndex = 4;
            this.view_detail.Text = "View Detail";
            this.view_detail.UseVisualStyleBackColor = true;
            this.view_detail.Click += new System.EventHandler(this.view_detail_Click);
            // 
            // find
            // 
            this.find.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.find.Location = new System.Drawing.Point(972, 39);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(180, 26);
            this.find.TabIndex = 5;
            this.find.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // Search
            // 
            this.Search.AutoSize = true;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search.Location = new System.Drawing.Point(968, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(62, 20);
            this.Search.TabIndex = 6;
            this.Search.Text = "Search";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(174, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 51);
            this.button3.TabIndex = 7;
            this.button3.Text = "Advance Filter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // achive
            // 
            this.achive.Location = new System.Drawing.Point(12, 477);
            this.achive.Name = "achive";
            this.achive.Size = new System.Drawing.Size(142, 51);
            this.achive.TabIndex = 8;
            this.achive.Text = "Achive";
            this.achive.UseVisualStyleBackColor = true;
            this.achive.Click += new System.EventHandler(this.achive_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(174, 549);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 55);
            this.button6.TabIndex = 9;
            this.button6.Text = "Export";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(526, 16);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(157, 49);
            this.Refresh.TabIndex = 10;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // DisplayMe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1178, 616);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.achive);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.find);
            this.Controls.Add(this.view_detail);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button view_detail;
        private System.Windows.Forms.TextBox find;
        private System.Windows.Forms.Label Search;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button achive;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Refresh;
    }
}