namespace LibraryManagementSystem.App
{
    partial class BorrowVoucherEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbb_Reader = new System.Windows.Forms.ComboBox();
            this.datepk_borrowDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtg_bookListSelected = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtg_BookList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bookListSelected)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BookList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(378, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "CẬP NHẬT MƯỢN SÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Close);
            this.groupBox2.Controls.Add(this.btn_Submit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 517);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1024, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.CausesValidation = false;
            this.btn_Close.Location = new System.Drawing.Point(553, 26);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(130, 35);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Đóng";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(353, 26);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(130, 35);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Cập nhật";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_update_callCard_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbb_Reader);
            this.groupBox3.Controls.Add(this.datepk_borrowDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1024, 86);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cbb_Reader
            // 
            this.cbb_Reader.FormattingEnabled = true;
            this.cbb_Reader.Location = new System.Drawing.Point(151, 35);
            this.cbb_Reader.Name = "cbb_Reader";
            this.cbb_Reader.Size = new System.Drawing.Size(278, 28);
            this.cbb_Reader.TabIndex = 8;
            // 
            // datepk_borrowDate
            // 
            this.datepk_borrowDate.Location = new System.Drawing.Point(688, 36);
            this.datepk_borrowDate.Name = "datepk_borrowDate";
            this.datepk_borrowDate.Size = new System.Drawing.Size(250, 27);
            this.datepk_borrowDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đọc giả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày mượn:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 337);
            this.panel1.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtg_bookListSelected);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(525, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(499, 337);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sách đã chọn";
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
            this.dtg_bookListSelected.Size = new System.Drawing.Size(493, 311);
            this.dtg_bookListSelected.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_BookList);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(525, 337);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sách";
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
            this.dtg_BookList.Size = new System.Drawing.Size(519, 311);
            this.dtg_BookList.TabIndex = 1;
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
            // BorrowVoucherEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Size = new System.Drawing.Size(1024, 600);
            this.Load += new System.EventHandler(this.BorrowVoucherEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_bookListSelected)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private ComboBox cbb_Reader;
        private DateTimePicker datepk_borrowDate;
        private Label label2;
        private Label label3;
        private Button btn_Close;
        private Button btn_Submit;
        private Panel panel1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private DataGridView dtg_BookList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn TypeName;
        private DataGridViewTextBoxColumn InStock;
        private DataGridView dtg_bookListSelected;
        private DataGridViewTextBoxColumn BookName;
        private DataGridViewTextBoxColumn BookId;
        private DataGridViewTextBoxColumn AuthorSelected;
        private DataGridViewTextBoxColumn Type;
    }
}
