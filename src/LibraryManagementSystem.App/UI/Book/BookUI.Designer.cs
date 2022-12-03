namespace LibraryManagementSystem.App.UI.Book
{
    partial class BookUI
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.BookMenu_SearchBookPage = new System.Windows.Forms.TabPage();
            this.BookPageContainer = new System.Windows.Forms.SplitContainer();
            this.BookPageSearchGroup = new System.Windows.Forms.GroupBox();
            this.SearchBookSearchCriteriaLabel = new System.Windows.Forms.Label();
            this.SearchBookByStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchBookByAuthorCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchBookByTypeCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchBookByNameCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchBookSearchCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.BookPageSearchBooksButton = new System.Windows.Forms.Button();
            this.BookPageDataGroup = new System.Windows.Forms.GroupBox();
            this.BookPageDataGridView = new System.Windows.Forms.DataGridView();
            this.BookPageDataIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookMenu_ManageBookPage = new System.Windows.Forms.TabPage();
            this.BookManager_MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.BookManager_AddBookGroup = new System.Windows.Forms.GroupBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.BookManager_UpdateBookButton = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookManager_AddBookButton = new System.Windows.Forms.Button();
            this.dtpPushlshed = new System.Windows.Forms.DateTimePicker();
            this.txbPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BookManager_BookTypeCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BookManager_BookViewGroup = new System.Windows.Forms.GroupBox();
            this.BM_ManageBookDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BM_ManageBookDGV_BookNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BM_ManageBookDGV_AuthorCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BM_ManageBookDGV_PublisherCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BM_ManageBookDGV_BookTypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BM_ManageBookDGV_PublishedYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BM_ManageBookDGV_DeleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txbQuantily = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.BookMenu_SearchBookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageContainer)).BeginInit();
            this.BookPageContainer.Panel1.SuspendLayout();
            this.BookPageContainer.Panel2.SuspendLayout();
            this.BookPageContainer.SuspendLayout();
            this.BookPageSearchGroup.SuspendLayout();
            this.BookPageDataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageDataGridView)).BeginInit();
            this.BookMenu_ManageBookPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookManager_MainSplitContainer)).BeginInit();
            this.BookManager_MainSplitContainer.Panel1.SuspendLayout();
            this.BookManager_MainSplitContainer.Panel2.SuspendLayout();
            this.BookManager_MainSplitContainer.SuspendLayout();
            this.BookManager_AddBookGroup.SuspendLayout();
            this.BookManager_BookViewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BM_ManageBookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantily)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.BookMenu_SearchBookPage);
            this.tabControl1.Controls.Add(this.BookMenu_ManageBookPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 600);
            this.tabControl1.TabIndex = 0;
            // 
            // BookMenu_SearchBookPage
            // 
            this.BookMenu_SearchBookPage.Controls.Add(this.BookPageContainer);
            this.BookMenu_SearchBookPage.Location = new System.Drawing.Point(4, 29);
            this.BookMenu_SearchBookPage.Name = "BookMenu_SearchBookPage";
            this.BookMenu_SearchBookPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookMenu_SearchBookPage.Size = new System.Drawing.Size(1016, 567);
            this.BookMenu_SearchBookPage.TabIndex = 0;
            this.BookMenu_SearchBookPage.Text = "Tra cứu sách";
            this.BookMenu_SearchBookPage.UseVisualStyleBackColor = true;
            // 
            // BookPageContainer
            // 
            this.BookPageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookPageContainer.Location = new System.Drawing.Point(3, 3);
            this.BookPageContainer.Name = "BookPageContainer";
            this.BookPageContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BookPageContainer.Panel1
            // 
            this.BookPageContainer.Panel1.Controls.Add(this.BookPageSearchGroup);
            // 
            // BookPageContainer.Panel2
            // 
            this.BookPageContainer.Panel2.Controls.Add(this.BookPageDataGroup);
            this.BookPageContainer.Size = new System.Drawing.Size(1010, 561);
            this.BookPageContainer.SplitterDistance = 94;
            this.BookPageContainer.TabIndex = 2;
            // 
            // BookPageSearchGroup
            // 
            this.BookPageSearchGroup.Controls.Add(this.SearchBookSearchCriteriaLabel);
            this.BookPageSearchGroup.Controls.Add(this.SearchBookByStatusCheckBox);
            this.BookPageSearchGroup.Controls.Add(this.SearchBookByAuthorCheckBox);
            this.BookPageSearchGroup.Controls.Add(this.SearchBookByTypeCheckBox);
            this.BookPageSearchGroup.Controls.Add(this.SearchBookByNameCheckBox);
            this.BookPageSearchGroup.Controls.Add(this.SearchBookSearchCriteriaTextBox);
            this.BookPageSearchGroup.Controls.Add(this.BookPageSearchBooksButton);
            this.BookPageSearchGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookPageSearchGroup.Location = new System.Drawing.Point(0, 0);
            this.BookPageSearchGroup.Name = "BookPageSearchGroup";
            this.BookPageSearchGroup.Size = new System.Drawing.Size(1010, 94);
            this.BookPageSearchGroup.TabIndex = 0;
            this.BookPageSearchGroup.TabStop = false;
            this.BookPageSearchGroup.Text = "Tìm kiếm";
            // 
            // SearchBookSearchCriteriaLabel
            // 
            this.SearchBookSearchCriteriaLabel.AutoSize = true;
            this.SearchBookSearchCriteriaLabel.Location = new System.Drawing.Point(21, 65);
            this.SearchBookSearchCriteriaLabel.Name = "SearchBookSearchCriteriaLabel";
            this.SearchBookSearchCriteriaLabel.Size = new System.Drawing.Size(62, 20);
            this.SearchBookSearchCriteriaLabel.TabIndex = 6;
            this.SearchBookSearchCriteriaLabel.Text = "Từ khoá";
            // 
            // SearchBookByStatusCheckBox
            // 
            this.SearchBookByStatusCheckBox.AutoSize = true;
            this.SearchBookByStatusCheckBox.Location = new System.Drawing.Point(287, 29);
            this.SearchBookByStatusCheckBox.Name = "SearchBookByStatusCheckBox";
            this.SearchBookByStatusCheckBox.Size = new System.Drawing.Size(98, 24);
            this.SearchBookByStatusCheckBox.TabIndex = 5;
            this.SearchBookByStatusCheckBox.Text = "Tình trạng";
            this.SearchBookByStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookByAuthorCheckBox
            // 
            this.SearchBookByAuthorCheckBox.AutoSize = true;
            this.SearchBookByAuthorCheckBox.Location = new System.Drawing.Point(203, 29);
            this.SearchBookByAuthorCheckBox.Name = "SearchBookByAuthorCheckBox";
            this.SearchBookByAuthorCheckBox.Size = new System.Drawing.Size(78, 24);
            this.SearchBookByAuthorCheckBox.TabIndex = 4;
            this.SearchBookByAuthorCheckBox.Text = "Tác Giả";
            this.SearchBookByAuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookByTypeCheckBox
            // 
            this.SearchBookByTypeCheckBox.AutoSize = true;
            this.SearchBookByTypeCheckBox.Location = new System.Drawing.Point(113, 29);
            this.SearchBookByTypeCheckBox.Name = "SearchBookByTypeCheckBox";
            this.SearchBookByTypeCheckBox.Size = new System.Drawing.Size(84, 24);
            this.SearchBookByTypeCheckBox.TabIndex = 3;
            this.SearchBookByTypeCheckBox.Text = "Thể loại";
            this.SearchBookByTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookByNameCheckBox
            // 
            this.SearchBookByNameCheckBox.AutoSize = true;
            this.SearchBookByNameCheckBox.Location = new System.Drawing.Point(21, 29);
            this.SearchBookByNameCheckBox.Name = "SearchBookByNameCheckBox";
            this.SearchBookByNameCheckBox.Size = new System.Drawing.Size(87, 24);
            this.SearchBookByNameCheckBox.TabIndex = 2;
            this.SearchBookByNameCheckBox.Text = "Tên sách";
            this.SearchBookByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookSearchCriteriaTextBox
            // 
            this.SearchBookSearchCriteriaTextBox.Location = new System.Drawing.Point(88, 60);
            this.SearchBookSearchCriteriaTextBox.Name = "SearchBookSearchCriteriaTextBox";
            this.SearchBookSearchCriteriaTextBox.Size = new System.Drawing.Size(181, 27);
            this.SearchBookSearchCriteriaTextBox.TabIndex = 1;
            // 
            // BookPageSearchBooksButton
            // 
            this.BookPageSearchBooksButton.Location = new System.Drawing.Point(287, 59);
            this.BookPageSearchBooksButton.Name = "BookPageSearchBooksButton";
            this.BookPageSearchBooksButton.Size = new System.Drawing.Size(94, 29);
            this.BookPageSearchBooksButton.TabIndex = 0;
            this.BookPageSearchBooksButton.Text = "Tìm kiếm";
            this.BookPageSearchBooksButton.UseVisualStyleBackColor = true;
            this.BookPageSearchBooksButton.Click += new System.EventHandler(this.BookPageSearchBooksButton_Click);
            // 
            // BookPageDataGroup
            // 
            this.BookPageDataGroup.Controls.Add(this.BookPageDataGridView);
            this.BookPageDataGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.BookPageDataGroup.Location = new System.Drawing.Point(0, 0);
            this.BookPageDataGroup.Name = "BookPageDataGroup";
            this.BookPageDataGroup.Size = new System.Drawing.Size(1024, 463);
            this.BookPageDataGroup.TabIndex = 0;
            this.BookPageDataGroup.TabStop = false;
            this.BookPageDataGroup.Text = "Thông tin sách";
            // 
            // BookPageDataGridView
            // 
            this.BookPageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookPageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookPageDataIndexColumn,
            this.BookPageDataNameColumn,
            this.BookPageDataType,
            this.BookPageDataAuthor,
            this.BookPageDataStatus});
            this.BookPageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookPageDataGridView.Location = new System.Drawing.Point(3, 23);
            this.BookPageDataGridView.Name = "BookPageDataGridView";
            this.BookPageDataGridView.RowHeadersWidth = 51;
            this.BookPageDataGridView.RowTemplate.Height = 29;
            this.BookPageDataGridView.Size = new System.Drawing.Size(1018, 437);
            this.BookPageDataGridView.TabIndex = 0;
            // 
            // BookPageDataIndexColumn
            // 
            this.BookPageDataIndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BookPageDataIndexColumn.FillWeight = 200.5348F;
            this.BookPageDataIndexColumn.HeaderText = "STT";
            this.BookPageDataIndexColumn.MinimumWidth = 6;
            this.BookPageDataIndexColumn.Name = "BookPageDataIndexColumn";
            this.BookPageDataIndexColumn.ReadOnly = true;
            this.BookPageDataIndexColumn.Width = 75;
            // 
            // BookPageDataNameColumn
            // 
            this.BookPageDataNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPageDataNameColumn.FillWeight = 74.86631F;
            this.BookPageDataNameColumn.HeaderText = "Tên sách";
            this.BookPageDataNameColumn.MinimumWidth = 6;
            this.BookPageDataNameColumn.Name = "BookPageDataNameColumn";
            this.BookPageDataNameColumn.ReadOnly = true;
            // 
            // BookPageDataType
            // 
            this.BookPageDataType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPageDataType.FillWeight = 74.86631F;
            this.BookPageDataType.HeaderText = "Thể loại";
            this.BookPageDataType.MinimumWidth = 6;
            this.BookPageDataType.Name = "BookPageDataType";
            this.BookPageDataType.ReadOnly = true;
            // 
            // BookPageDataAuthor
            // 
            this.BookPageDataAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPageDataAuthor.FillWeight = 74.86631F;
            this.BookPageDataAuthor.HeaderText = "Tác giả";
            this.BookPageDataAuthor.MinimumWidth = 6;
            this.BookPageDataAuthor.Name = "BookPageDataAuthor";
            this.BookPageDataAuthor.ReadOnly = true;
            // 
            // BookPageDataStatus
            // 
            this.BookPageDataStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPageDataStatus.FillWeight = 74.86631F;
            this.BookPageDataStatus.HeaderText = "Tình trạng";
            this.BookPageDataStatus.MinimumWidth = 6;
            this.BookPageDataStatus.Name = "BookPageDataStatus";
            this.BookPageDataStatus.ReadOnly = true;
            // 
            // BookMenu_ManageBookPage
            // 
            this.BookMenu_ManageBookPage.Controls.Add(this.BookManager_MainSplitContainer);
            this.BookMenu_ManageBookPage.Location = new System.Drawing.Point(4, 29);
            this.BookMenu_ManageBookPage.Name = "BookMenu_ManageBookPage";
            this.BookMenu_ManageBookPage.Padding = new System.Windows.Forms.Padding(3);
            this.BookMenu_ManageBookPage.Size = new System.Drawing.Size(1016, 567);
            this.BookMenu_ManageBookPage.TabIndex = 1;
            this.BookMenu_ManageBookPage.Text = "Quản lý sách";
            this.BookMenu_ManageBookPage.UseVisualStyleBackColor = true;
            this.BookMenu_ManageBookPage.Enter += new System.EventHandler(this.BookMenu_ManageBookPage_Enter);
            // 
            // BookManager_MainSplitContainer
            // 
            this.BookManager_MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookManager_MainSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.BookManager_MainSplitContainer.Name = "BookManager_MainSplitContainer";
            this.BookManager_MainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BookManager_MainSplitContainer.Panel1
            // 
            this.BookManager_MainSplitContainer.Panel1.Controls.Add(this.BookManager_AddBookGroup);
            // 
            // BookManager_MainSplitContainer.Panel2
            // 
            this.BookManager_MainSplitContainer.Panel2.Controls.Add(this.BookManager_BookViewGroup);
            this.BookManager_MainSplitContainer.Size = new System.Drawing.Size(1010, 561);
            this.BookManager_MainSplitContainer.SplitterDistance = 154;
            this.BookManager_MainSplitContainer.TabIndex = 3;
            // 
            // BookManager_AddBookGroup
            // 
            this.BookManager_AddBookGroup.Controls.Add(this.txbQuantily);
            this.BookManager_AddBookGroup.Controls.Add(this.lbQuantity);
            this.BookManager_AddBookGroup.Controls.Add(this.BookManager_UpdateBookButton);
            this.BookManager_AddBookGroup.Controls.Add(this.txbId);
            this.BookManager_AddBookGroup.Controls.Add(this.label1);
            this.BookManager_AddBookGroup.Controls.Add(this.BookManager_AddBookButton);
            this.BookManager_AddBookGroup.Controls.Add(this.dtpPushlshed);
            this.BookManager_AddBookGroup.Controls.Add(this.txbPublisher);
            this.BookManager_AddBookGroup.Controls.Add(this.label5);
            this.BookManager_AddBookGroup.Controls.Add(this.label6);
            this.BookManager_AddBookGroup.Controls.Add(this.txbName);
            this.BookManager_AddBookGroup.Controls.Add(this.label2);
            this.BookManager_AddBookGroup.Controls.Add(this.BookManager_BookTypeCbb);
            this.BookManager_AddBookGroup.Controls.Add(this.label3);
            this.BookManager_AddBookGroup.Controls.Add(this.txbAuthor);
            this.BookManager_AddBookGroup.Controls.Add(this.label4);
            this.BookManager_AddBookGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookManager_AddBookGroup.Location = new System.Drawing.Point(0, 0);
            this.BookManager_AddBookGroup.Name = "BookManager_AddBookGroup";
            this.BookManager_AddBookGroup.Size = new System.Drawing.Size(1010, 154);
            this.BookManager_AddBookGroup.TabIndex = 1;
            this.BookManager_AddBookGroup.TabStop = false;
            this.BookManager_AddBookGroup.Text = "Quản lý sách";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(877, 23);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(69, 20);
            this.lbQuantity.TabIndex = 17;
            this.lbQuantity.Text = "Số lượng";
            // 
            // BookManager_UpdateBookButton
            // 
            this.BookManager_UpdateBookButton.Location = new System.Drawing.Point(916, 106);
            this.BookManager_UpdateBookButton.Name = "BookManager_UpdateBookButton";
            this.BookManager_UpdateBookButton.Size = new System.Drawing.Size(91, 29);
            this.BookManager_UpdateBookButton.TabIndex = 15;
            this.BookManager_UpdateBookButton.Text = "Cập nhật";
            this.BookManager_UpdateBookButton.UseVisualStyleBackColor = true;
            this.BookManager_UpdateBookButton.Click += new System.EventHandler(this.BookManager_UpdateBookButton_Click);
            // 
            // txbId
            // 
            this.txbId.Enabled = false;
            this.txbId.Location = new System.Drawing.Point(6, 50);
            this.txbId.Name = "txbId";
            this.txbId.ReadOnly = true;
            this.txbId.Size = new System.Drawing.Size(241, 27);
            this.txbId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã Sách";
            // 
            // BookManager_AddBookButton
            // 
            this.BookManager_AddBookButton.Location = new System.Drawing.Point(816, 107);
            this.BookManager_AddBookButton.Name = "BookManager_AddBookButton";
            this.BookManager_AddBookButton.Size = new System.Drawing.Size(94, 29);
            this.BookManager_AddBookButton.TabIndex = 12;
            this.BookManager_AddBookButton.Text = "Thêm";
            this.BookManager_AddBookButton.UseVisualStyleBackColor = true;
            this.BookManager_AddBookButton.Click += new System.EventHandler(this.BookManager_AddBookButton_Click);
            // 
            // dtpPushlshed
            // 
            this.dtpPushlshed.Location = new System.Drawing.Point(547, 108);
            this.dtpPushlshed.Name = "dtpPushlshed";
            this.dtpPushlshed.Size = new System.Drawing.Size(241, 27);
            this.dtpPushlshed.TabIndex = 9;
            // 
            // txbPublisher
            // 
            this.txbPublisher.Location = new System.Drawing.Point(279, 108);
            this.txbPublisher.Name = "txbPublisher";
            this.txbPublisher.Size = new System.Drawing.Size(241, 27);
            this.txbPublisher.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm xuất bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhà xuất bản";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(279, 50);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(339, 27);
            this.txbName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // BookManager_BookTypeCbb
            // 
            this.BookManager_BookTypeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BookManager_BookTypeCbb.FormattingEnabled = true;
            this.BookManager_BookTypeCbb.Location = new System.Drawing.Point(6, 107);
            this.BookManager_BookTypeCbb.Name = "BookManager_BookTypeCbb";
            this.BookManager_BookTypeCbb.Size = new System.Drawing.Size(241, 28);
            this.BookManager_BookTypeCbb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thể loại";
            // 
            // txbAuthor
            // 
            this.txbAuthor.Location = new System.Drawing.Point(650, 50);
            this.txbAuthor.Name = "txbAuthor";
            this.txbAuthor.Size = new System.Drawing.Size(204, 27);
            this.txbAuthor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tác giả";
            // 
            // BookManager_BookViewGroup
            // 
            this.BookManager_BookViewGroup.Controls.Add(this.BM_ManageBookDGV);
            this.BookManager_BookViewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookManager_BookViewGroup.Location = new System.Drawing.Point(0, 0);
            this.BookManager_BookViewGroup.Name = "BookManager_BookViewGroup";
            this.BookManager_BookViewGroup.Size = new System.Drawing.Size(1010, 403);
            this.BookManager_BookViewGroup.TabIndex = 0;
            this.BookManager_BookViewGroup.TabStop = false;
            this.BookManager_BookViewGroup.Text = "Thông tin sách";
            // 
            // BM_ManageBookDGV
            // 
            this.BM_ManageBookDGV.AllowUserToAddRows = false;
            this.BM_ManageBookDGV.AllowUserToDeleteRows = false;
            this.BM_ManageBookDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BM_ManageBookDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BM_ManageBookDGV_BookNameCol,
            this.BM_ManageBookDGV_AuthorCol,
            this.BM_ManageBookDGV_PublisherCol,
            this.BM_ManageBookDGV_BookTypeCol,
            this.BM_ManageBookDGV_PublishedYear,
            this.InStock,
            this.BM_ManageBookDGV_DeleteCol});
            this.BM_ManageBookDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BM_ManageBookDGV.Location = new System.Drawing.Point(3, 23);
            this.BM_ManageBookDGV.MultiSelect = false;
            this.BM_ManageBookDGV.Name = "BM_ManageBookDGV";
            this.BM_ManageBookDGV.ReadOnly = true;
            this.BM_ManageBookDGV.RowHeadersWidth = 51;
            this.BM_ManageBookDGV.RowTemplate.Height = 29;
            this.BM_ManageBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BM_ManageBookDGV.Size = new System.Drawing.Size(1004, 377);
            this.BM_ManageBookDGV.TabIndex = 0;
            this.BM_ManageBookDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BM_ManageBookDGV_CellClick);
            this.BM_ManageBookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BM_ManageBookDGV_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // BM_ManageBookDGV_BookNameCol
            // 
            this.BM_ManageBookDGV_BookNameCol.HeaderText = "Tên sách";
            this.BM_ManageBookDGV_BookNameCol.MinimumWidth = 6;
            this.BM_ManageBookDGV_BookNameCol.Name = "BM_ManageBookDGV_BookNameCol";
            this.BM_ManageBookDGV_BookNameCol.ReadOnly = true;
            this.BM_ManageBookDGV_BookNameCol.Width = 200;
            // 
            // BM_ManageBookDGV_AuthorCol
            // 
            this.BM_ManageBookDGV_AuthorCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BM_ManageBookDGV_AuthorCol.HeaderText = "Tác giả";
            this.BM_ManageBookDGV_AuthorCol.MinimumWidth = 6;
            this.BM_ManageBookDGV_AuthorCol.Name = "BM_ManageBookDGV_AuthorCol";
            this.BM_ManageBookDGV_AuthorCol.ReadOnly = true;
            this.BM_ManageBookDGV_AuthorCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BM_ManageBookDGV_AuthorCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BM_ManageBookDGV_PublisherCol
            // 
            this.BM_ManageBookDGV_PublisherCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BM_ManageBookDGV_PublisherCol.HeaderText = "Nhà xuất bản";
            this.BM_ManageBookDGV_PublisherCol.MinimumWidth = 6;
            this.BM_ManageBookDGV_PublisherCol.Name = "BM_ManageBookDGV_PublisherCol";
            this.BM_ManageBookDGV_PublisherCol.ReadOnly = true;
            this.BM_ManageBookDGV_PublisherCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BM_ManageBookDGV_PublisherCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BM_ManageBookDGV_BookTypeCol
            // 
            this.BM_ManageBookDGV_BookTypeCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BM_ManageBookDGV_BookTypeCol.HeaderText = "Thể loại";
            this.BM_ManageBookDGV_BookTypeCol.MinimumWidth = 6;
            this.BM_ManageBookDGV_BookTypeCol.Name = "BM_ManageBookDGV_BookTypeCol";
            this.BM_ManageBookDGV_BookTypeCol.ReadOnly = true;
            this.BM_ManageBookDGV_BookTypeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.BM_ManageBookDGV_BookTypeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BM_ManageBookDGV_PublishedYear
            // 
            this.BM_ManageBookDGV_PublishedYear.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BM_ManageBookDGV_PublishedYear.HeaderText = "Năm xuất bản";
            this.BM_ManageBookDGV_PublishedYear.MinimumWidth = 6;
            this.BM_ManageBookDGV_PublishedYear.Name = "BM_ManageBookDGV_PublishedYear";
            this.BM_ManageBookDGV_PublishedYear.ReadOnly = true;
            // 
            // InStock
            // 
            this.InStock.HeaderText = "Số lượng";
            this.InStock.MinimumWidth = 6;
            this.InStock.Name = "InStock";
            this.InStock.ReadOnly = true;
            this.InStock.Width = 125;
            // 
            // BM_ManageBookDGV_DeleteCol
            // 
            this.BM_ManageBookDGV_DeleteCol.HeaderText = "Xoá";
            this.BM_ManageBookDGV_DeleteCol.MinimumWidth = 6;
            this.BM_ManageBookDGV_DeleteCol.Name = "BM_ManageBookDGV_DeleteCol";
            this.BM_ManageBookDGV_DeleteCol.ReadOnly = true;
            this.BM_ManageBookDGV_DeleteCol.Width = 50;
            // 
            // txbQuantily
            // 
            this.txbQuantily.Location = new System.Drawing.Point(877, 46);
            this.txbQuantily.Name = "txbQuantily";
            this.txbQuantily.Size = new System.Drawing.Size(101, 27);
            this.txbQuantily.TabIndex = 18;
            // 
            // BookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "BookUI";
            this.Size = new System.Drawing.Size(1024, 600);
            this.tabControl1.ResumeLayout(false);
            this.BookMenu_SearchBookPage.ResumeLayout(false);
            this.BookPageContainer.Panel1.ResumeLayout(false);
            this.BookPageContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookPageContainer)).EndInit();
            this.BookPageContainer.ResumeLayout(false);
            this.BookPageSearchGroup.ResumeLayout(false);
            this.BookPageSearchGroup.PerformLayout();
            this.BookPageDataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookPageDataGridView)).EndInit();
            this.BookMenu_ManageBookPage.ResumeLayout(false);
            this.BookManager_MainSplitContainer.Panel1.ResumeLayout(false);
            this.BookManager_MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookManager_MainSplitContainer)).EndInit();
            this.BookManager_MainSplitContainer.ResumeLayout(false);
            this.BookManager_AddBookGroup.ResumeLayout(false);
            this.BookManager_AddBookGroup.PerformLayout();
            this.BookManager_BookViewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BM_ManageBookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txbQuantily)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage BookMenu_SearchBookPage;
        private SplitContainer BookPageContainer;
        private GroupBox BookPageSearchGroup;
        private Label SearchBookSearchCriteriaLabel;
        private CheckBox SearchBookByStatusCheckBox;
        private CheckBox SearchBookByAuthorCheckBox;
        private CheckBox SearchBookByTypeCheckBox;
        private CheckBox SearchBookByNameCheckBox;
        private TextBox SearchBookSearchCriteriaTextBox;
        private Button BookPageSearchBooksButton;
        private GroupBox BookPageDataGroup;
        private DataGridView BookPageDataGridView;
        private DataGridViewTextBoxColumn BookPageDataIndexColumn;
        private DataGridViewTextBoxColumn BookPageDataNameColumn;
        private DataGridViewTextBoxColumn BookPageDataType;
        private DataGridViewTextBoxColumn BookPageDataAuthor;
        private DataGridViewTextBoxColumn BookPageDataStatus;
        private TabPage BookMenu_ManageBookPage;
        private Button BookManager_AddBookButton;
        private TextBox txbPublisher;
        private Label label6;
        private DateTimePicker dtpPushlshed;
        private Label label5;
        private Label label4;
        private ComboBox BookManager_BookTypeCbb;
        private TextBox txbAuthor;
        private Label label3;
        private TextBox txbName;
        private Label label2;
        private SplitContainer BookManager_MainSplitContainer;
        private GroupBox BookManager_AddBookGroup;
        private Button BookManager_UpdateBookButton;
        private TextBox txbId;
        private Label label1;
        private GroupBox BookManager_BookViewGroup;
        private DataGridView BM_ManageBookDGV;
        private Label lbQuantity;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn BM_ManageBookDGV_BookNameCol;
        private DataGridViewTextBoxColumn BM_ManageBookDGV_AuthorCol;
        private DataGridViewTextBoxColumn BM_ManageBookDGV_PublisherCol;
        private DataGridViewTextBoxColumn BM_ManageBookDGV_BookTypeCol;
        private DataGridViewTextBoxColumn BM_ManageBookDGV_PublishedYear;
        private DataGridViewTextBoxColumn InStock;
        private DataGridViewButtonColumn BM_ManageBookDGV_DeleteCol;
        private NumericUpDown txbQuantily;
    }
}
