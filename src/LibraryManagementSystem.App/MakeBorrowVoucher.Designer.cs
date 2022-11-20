namespace LibraryManagementSystem.App
{
    partial class MakeBorrowVoucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gb_selelcted = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.gb_books = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_infoReader = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_AuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb_selelcted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pn_infoReader.SuspendLayout();
            this.pn_header.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(437, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "MƯỢN SÁCH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gb_selelcted);
            this.panel1.Controls.Add(this.gb_books);
            this.panel1.Controls.Add(this.pn_infoReader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 600);
            this.panel1.TabIndex = 2;
            // 
            // gb_selelcted
            // 
            this.gb_selelcted.Controls.Add(this.dataGridView2);
            this.gb_selelcted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_selelcted.Location = new System.Drawing.Point(530, 163);
            this.gb_selelcted.Name = "gb_selelcted";
            this.gb_selelcted.Size = new System.Drawing.Size(494, 437);
            this.gb_selelcted.TabIndex = 2;
            this.gb_selelcted.TabStop = false;
            this.gb_selelcted.Text = "Sách đã chọn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(488, 411);
            this.dataGridView2.TabIndex = 0;
            // 
            // gb_books
            // 
            this.gb_books.Controls.Add(this.dataGridView1);
            this.gb_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_books.Location = new System.Drawing.Point(0, 163);
            this.gb_books.Name = "gb_books";
            this.gb_books.Size = new System.Drawing.Size(530, 437);
            this.gb_books.TabIndex = 1;
            this.gb_books.TabStop = false;
            this.gb_books.Text = "Danh sách sách";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SST,
            this.BookName,
            this.Author});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(524, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // SST
            // 
            this.SST.HeaderText = "Column1";
            this.SST.MinimumWidth = 6;
            this.SST.Name = "SST";
            this.SST.Width = 125;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Tên Sách";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.Width = 125;
            // 
            // Author
            // 
            this.Author.HeaderText = "Tác Giả";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.Width = 125;
            // 
            // pn_infoReader
            // 
            this.pn_infoReader.Controls.Add(this.dateTimePicker1);
            this.pn_infoReader.Controls.Add(this.label3);
            this.pn_infoReader.Controls.Add(this.txt_AuthorName);
            this.pn_infoReader.Controls.Add(this.label2);
            this.pn_infoReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_infoReader.Location = new System.Drawing.Point(0, 0);
            this.pn_infoReader.Name = "pn_infoReader";
            this.pn_infoReader.Size = new System.Drawing.Size(1024, 163);
            this.pn_infoReader.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(691, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(572, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày mượn:";
            // 
            // txt_AuthorName
            // 
            this.txt_AuthorName.Location = new System.Drawing.Point(129, 110);
            this.txt_AuthorName.Name = "txt_AuthorName";
            this.txt_AuthorName.Size = new System.Drawing.Size(326, 27);
            this.txt_AuthorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đọc giả:";
            // 
            // pn_header
            // 
            this.pn_header.Controls.Add(this.label1);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1024, 86);
            this.pn_header.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_submit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 69);
            this.panel3.TabIndex = 4;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(487, 19);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 29);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Xác nhận";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // MakeBorrowVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.panel1);
            this.Name = "MakeBorrowVoucher";
            this.Size = new System.Drawing.Size(1024, 600);
            this.panel1.ResumeLayout(false);
            this.gb_selelcted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pn_infoReader.ResumeLayout(false);
            this.pn_infoReader.PerformLayout();
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox gb_selelcted;
        private DataGridView dataGridView2;
        private GroupBox gb_books;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SST;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn Author;
        private Panel pn_infoReader;
        private Panel pn_header;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txt_AuthorName;
        private Label label2;
        private Button btn_submit;
    }
}
