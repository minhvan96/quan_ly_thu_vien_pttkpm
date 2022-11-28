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
            this.dtg_bookListSelected = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_books = new System.Windows.Forms.GroupBox();
            this.dtg_BookList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_infoReader = new System.Windows.Forms.Panel();
            this.cbb_Reader = new System.Windows.Forms.ComboBox();
            this.datepk_borrowDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_submit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gb_selelcted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bookListSelected)).BeginInit();
            this.gb_books.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BookList)).BeginInit();
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
            this.gb_selelcted.Controls.Add(this.dtg_bookListSelected);
            this.gb_selelcted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_selelcted.Location = new System.Drawing.Point(530, 163);
            this.gb_selelcted.Name = "gb_selelcted";
            this.gb_selelcted.Size = new System.Drawing.Size(494, 437);
            this.gb_selelcted.TabIndex = 2;
            this.gb_selelcted.TabStop = false;
            this.gb_selelcted.Text = "Sách đã chọn";
            // 
            // dtg_bookListSelected
            // 
            this.dtg_bookListSelected.AllowUserToAddRows = false;
            this.dtg_bookListSelected.AllowUserToDeleteRows = false;
            this.dtg_bookListSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_bookListSelected.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.BookId,
            this.AuthorSelected,
            this.Type});
            this.dtg_bookListSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_bookListSelected.Location = new System.Drawing.Point(3, 23);
            this.dtg_bookListSelected.Name = "dtg_bookListSelected";
            this.dtg_bookListSelected.ReadOnly = true;
            this.dtg_bookListSelected.RowHeadersWidth = 51;
            this.dtg_bookListSelected.RowTemplate.Height = 29;
            this.dtg_bookListSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_bookListSelected.Size = new System.Drawing.Size(488, 411);
            this.dtg_bookListSelected.TabIndex = 0;
            this.dtg_bookListSelected.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_bookListSelected_CellContentDoubleClick);
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "Tên Sách";
            this.BookName.MinimumWidth = 6;
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 125;
            // 
            // BookId
            // 
            this.BookId.DataPropertyName = "BookId";
            this.BookId.HeaderText = "BookId";
            this.BookId.MinimumWidth = 6;
            this.BookId.Name = "BookId";
            this.BookId.ReadOnly = true;
            this.BookId.Visible = false;
            this.BookId.Width = 125;
            // 
            // AuthorSelected
            // 
            this.AuthorSelected.DataPropertyName = "Author";
            this.AuthorSelected.HeaderText = "Tác Giả";
            this.AuthorSelected.MinimumWidth = 6;
            this.AuthorSelected.Name = "AuthorSelected";
            this.AuthorSelected.ReadOnly = true;
            this.AuthorSelected.Width = 125;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "BookType";
            this.Type.HeaderText = "Thể loại";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // gb_books
            // 
            this.gb_books.Controls.Add(this.dtg_BookList);
            this.gb_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.gb_books.Location = new System.Drawing.Point(0, 163);
            this.gb_books.Name = "gb_books";
            this.gb_books.Size = new System.Drawing.Size(530, 437);
            this.gb_books.TabIndex = 1;
            this.gb_books.TabStop = false;
            this.gb_books.Text = "Danh sách sách";
            // 
            // dtg_BookList
            // 
            this.dtg_BookList.AllowUserToAddRows = false;
            this.dtg_BookList.AllowUserToDeleteRows = false;
            this.dtg_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Author,
            this.TypeName,
            this.InStock});
            this.dtg_BookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_BookList.Location = new System.Drawing.Point(3, 23);
            this.dtg_BookList.MultiSelect = false;
            this.dtg_BookList.Name = "dtg_BookList";
            this.dtg_BookList.ReadOnly = true;
            this.dtg_BookList.RowHeadersWidth = 51;
            this.dtg_BookList.RowTemplate.Height = 29;
            this.dtg_BookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BookList.Size = new System.Drawing.Size(524, 411);
            this.dtg_BookList.TabIndex = 0;
            this.dtg_BookList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_BookList_CellContentDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Column1";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Tên Sách";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Tác Giả";
            this.Author.MinimumWidth = 6;
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 125;
            // 
            // TypeName
            // 
            this.TypeName.DataPropertyName = "TypeName";
            this.TypeName.HeaderText = "Thể Loại";
            this.TypeName.MinimumWidth = 6;
            this.TypeName.Name = "TypeName";
            this.TypeName.ReadOnly = true;
            this.TypeName.Width = 125;
            // 
            // InStock
            // 
            this.InStock.DataPropertyName = "InStock";
            this.InStock.HeaderText = "Số lượng";
            this.InStock.MinimumWidth = 6;
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            this.InStock.Width = 125;
            // 
            // pn_infoReader
            // 
            this.pn_infoReader.Controls.Add(this.cbb_Reader);
            this.pn_infoReader.Controls.Add(this.datepk_borrowDate);
            this.pn_infoReader.Controls.Add(this.label3);
            this.pn_infoReader.Controls.Add(this.label2);
            this.pn_infoReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_infoReader.Location = new System.Drawing.Point(0, 0);
            this.pn_infoReader.Name = "pn_infoReader";
            this.pn_infoReader.Size = new System.Drawing.Size(1024, 163);
            this.pn_infoReader.TabIndex = 0;
            // 
            // cbb_Reader
            // 
            this.cbb_Reader.FormattingEnabled = true;
            this.cbb_Reader.Location = new System.Drawing.Point(154, 109);
            this.cbb_Reader.Name = "cbb_Reader";
            this.cbb_Reader.Size = new System.Drawing.Size(278, 28);
            this.cbb_Reader.TabIndex = 4;
            // 
            // datepk_borrowDate
            // 
            this.datepk_borrowDate.Location = new System.Drawing.Point(691, 110);
            this.datepk_borrowDate.Name = "datepk_borrowDate";
            this.datepk_borrowDate.Size = new System.Drawing.Size(250, 27);
            this.datepk_borrowDate.TabIndex = 3;
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
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // MakeBorrowVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.panel1);
            this.Size = new System.Drawing.Size(1024, 600);
            this.Load += new System.EventHandler(this.Loaded);
            this.panel1.ResumeLayout(false);
            this.gb_selelcted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bookListSelected)).EndInit();
            this.gb_books.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BookList)).EndInit();
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
        private DataGridView dtg_bookListSelected;
        private GroupBox gb_books;
        private DataGridView dtg_BookList;
        private Panel pn_infoReader;
        private Panel pn_header;
        private Panel panel3;
        private DateTimePicker datepk_borrowDate;
        private Label label3;
        private Label label2;
        private Button btn_submit;
        private ComboBox cbb_Reader;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn TypeName;
        private DataGridViewTextBoxColumn InStock;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn AuthorSelected;
        private DataGridViewTextBoxColumn Type;
    }
}
