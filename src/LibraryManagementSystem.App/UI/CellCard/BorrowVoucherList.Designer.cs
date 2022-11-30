namespace LibraryManagementSystem.App
{
    partial class BorrowVoucherList
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
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtg_BorrowBookList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BorrowBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1024, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(342, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH MƯỢN SÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 507);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1024, 93);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(527, 35);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(209, 33);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa phiếu mượn";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(291, 35);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(209, 33);
            this.btn_update.TabIndex = 0;
            this.btn_update.Text = "Xem chi tiết và cập nhật";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtg_BorrowBookList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1024, 405);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu mượn";
            // 
            // dtg_BorrowBookList
            // 
            this.dtg_BorrowBookList.AllowUserToAddRows = false;
            this.dtg_BorrowBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_BorrowBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BorrowBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LibraryName,
            this.BorrowDate,
            this.Status,
            this.BookCount});
            this.dtg_BorrowBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_BorrowBookList.Location = new System.Drawing.Point(3, 23);
            this.dtg_BorrowBookList.Name = "dtg_BorrowBookList";
            this.dtg_BorrowBookList.ReadOnly = true;
            this.dtg_BorrowBookList.RowHeadersWidth = 51;
            this.dtg_BorrowBookList.RowTemplate.Height = 29;
            this.dtg_BorrowBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BorrowBookList.ShowCellToolTips = false;
            this.dtg_BorrowBookList.ShowEditingIcon = false;
            this.dtg_BorrowBookList.Size = new System.Drawing.Size(1018, 379);
            this.dtg_BorrowBookList.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // LibraryName
            // 
            this.LibraryName.DataPropertyName = "LibraryName";
            this.LibraryName.HeaderText = "Đọc giả";
            this.LibraryName.MinimumWidth = 6;
            this.LibraryName.Name = "LibraryName";
            this.LibraryName.ReadOnly = true;
            // 
            // BorrowDate
            // 
            this.BorrowDate.DataPropertyName = "BorrowDate";
            this.BorrowDate.HeaderText = "Ngày mượn";
            this.BorrowDate.MinimumWidth = 6;
            this.BorrowDate.Name = "BorrowDate";
            this.BorrowDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Tình trạng";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "Số lượng";
            this.BookCount.MinimumWidth = 6;
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            // 
            // BorrowVoucherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BorrowVoucherList";
            this.Size = new System.Drawing.Size(1024, 600);
            this.Load += new System.EventHandler(this.BorrowVoucherList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BorrowBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private Button btn_Delete;
        private Button btn_update;
        private DataGridView dtg_BorrowBookList;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn LibraryName;
        private DataGridViewTextBoxColumn BorrowDate;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn BookCount;
    }
}
