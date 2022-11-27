namespace LibraryManagementSystem.App
{
    partial class LibraryManagementSystemUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SystemMainTabControl = new System.Windows.Forms.TabControl();
            this.STC_HomeTP = new System.Windows.Forms.TabPage();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.STC_BookTP = new System.Windows.Forms.TabPage();
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
            this.MakeBorrow = new System.Windows.Forms.TabPage();
            this.LibraryConfigurationTab = new System.Windows.Forms.TabPage();
            this.LibraryConfigurationTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.SearchLibraryConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchConfigurationSearchCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.SearchConfigurationByCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchConfigurationByNameCheckBox = new System.Windows.Forms.CheckBox();
            this.LibraryConfigurationSearchButton = new System.Windows.Forms.Button();
            this.LibraryConfigurationDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LibraryConfigurationDataGridView = new System.Windows.Forms.DataGridView();
            this.LibraryConfigurationCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryConfigurationNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryConfigurationValueeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STC_AddBook = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SystemMainTabControl.SuspendLayout();
            this.STC_HomeTP.SuspendLayout();
            this.STC_BookTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageContainer)).BeginInit();
            this.BookPageContainer.Panel1.SuspendLayout();
            this.BookPageContainer.Panel2.SuspendLayout();
            this.BookPageContainer.SuspendLayout();
            this.BookPageSearchGroup.SuspendLayout();
            this.BookPageDataGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageDataGridView)).BeginInit();
            this.LibraryConfigurationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationTab_MainContainer)).BeginInit();
            this.LibraryConfigurationTab_MainContainer.Panel1.SuspendLayout();
            this.LibraryConfigurationTab_MainContainer.Panel2.SuspendLayout();
            this.LibraryConfigurationTab_MainContainer.SuspendLayout();
            this.SearchLibraryConfigurationGroupBox.SuspendLayout();
            this.LibraryConfigurationDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationDataGridView)).BeginInit();
            this.STC_AddBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemMainTabControl
            // 
            this.SystemMainTabControl.Controls.Add(this.STC_HomeTP);
            this.SystemMainTabControl.Controls.Add(this.STC_BookTP);
            this.SystemMainTabControl.Controls.Add(this.MakeBorrow);
            this.SystemMainTabControl.Controls.Add(this.LibraryConfigurationTab);
            this.SystemMainTabControl.Controls.Add(this.STC_AddBook);
            this.SystemMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemMainTabControl.Location = new System.Drawing.Point(0, 0);
            this.SystemMainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemMainTabControl.Name = "SystemMainTabControl";
            this.SystemMainTabControl.SelectedIndex = 0;
            this.SystemMainTabControl.Size = new System.Drawing.Size(1032, 623);
            this.SystemMainTabControl.TabIndex = 0;
            this.SystemMainTabControl.SelectedIndexChanged += new System.EventHandler(this.SystemMainTabControl_SelectedIndexChanged);
            this.SystemMainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.SystemMainTabControl_Selected);
            // 
            // STC_HomeTP
            // 
            this.STC_HomeTP.Controls.Add(this.txtTest);
            this.STC_HomeTP.Controls.Add(this.button1);
            this.STC_HomeTP.Location = new System.Drawing.Point(4, 29);
            this.STC_HomeTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_HomeTP.Name = "STC_HomeTP";
            this.STC_HomeTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_HomeTP.Size = new System.Drawing.Size(1024, 590);
            this.STC_HomeTP.TabIndex = 0;
            this.STC_HomeTP.Text = "HOME";
            this.STC_HomeTP.UseVisualStyleBackColor = true;
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(221, 318);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(125, 27);
            this.txtTest.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // STC_BookTP
            // 
            this.STC_BookTP.Controls.Add(this.BookPageContainer);
            this.STC_BookTP.Location = new System.Drawing.Point(4, 29);
            this.STC_BookTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_BookTP.Name = "STC_BookTP";
            this.STC_BookTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_BookTP.Size = new System.Drawing.Size(1024, 590);
            this.STC_BookTP.TabIndex = 1;
            this.STC_BookTP.Text = "Tra cứu sách";
            this.STC_BookTP.UseVisualStyleBackColor = true;
            // 
            // BookPageContainer
            // 
            this.BookPageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookPageContainer.Location = new System.Drawing.Point(3, 4);
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
            this.BookPageContainer.Size = new System.Drawing.Size(1018, 582);
            this.BookPageContainer.SplitterDistance = 100;
            this.BookPageContainer.TabIndex = 0;
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
            this.BookPageSearchGroup.Size = new System.Drawing.Size(1018, 100);
            this.BookPageSearchGroup.TabIndex = 0;
            this.BookPageSearchGroup.TabStop = false;
            this.BookPageSearchGroup.Text = "Tìm kiếm";
            // 
            // SearchBookSearchCriteriaLabel
            // 
            this.SearchBookSearchCriteriaLabel.AutoSize = true;
            this.SearchBookSearchCriteriaLabel.Location = new System.Drawing.Point(17, 56);
            this.SearchBookSearchCriteriaLabel.Name = "SearchBookSearchCriteriaLabel";
            this.SearchBookSearchCriteriaLabel.Size = new System.Drawing.Size(62, 20);
            this.SearchBookSearchCriteriaLabel.TabIndex = 6;
            this.SearchBookSearchCriteriaLabel.Text = "Từ khoá";
            // 
            // SearchBookByStatusCheckBox
            // 
            this.SearchBookByStatusCheckBox.AutoSize = true;
            this.SearchBookByStatusCheckBox.Location = new System.Drawing.Point(338, 22);
            this.SearchBookByStatusCheckBox.Name = "SearchBookByStatusCheckBox";
            this.SearchBookByStatusCheckBox.Size = new System.Drawing.Size(98, 24);
            this.SearchBookByStatusCheckBox.TabIndex = 5;
            this.SearchBookByStatusCheckBox.Text = "Tình trạng";
            this.SearchBookByStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookByAuthorCheckBox
            // 
            this.SearchBookByAuthorCheckBox.AutoSize = true;
            this.SearchBookByAuthorCheckBox.Location = new System.Drawing.Point(231, 22);
            this.SearchBookByAuthorCheckBox.Name = "SearchBookByAuthorCheckBox";
            this.SearchBookByAuthorCheckBox.Size = new System.Drawing.Size(78, 24);
            this.SearchBookByAuthorCheckBox.TabIndex = 4;
            this.SearchBookByAuthorCheckBox.Text = "Tác Giả";
            this.SearchBookByAuthorCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookByTypeCheckBox
            // 
            this.SearchBookByTypeCheckBox.AutoSize = true;
            this.SearchBookByTypeCheckBox.Location = new System.Drawing.Point(124, 22);
            this.SearchBookByTypeCheckBox.Name = "SearchBookByTypeCheckBox";
            this.SearchBookByTypeCheckBox.Size = new System.Drawing.Size(84, 24);
            this.SearchBookByTypeCheckBox.TabIndex = 3;
            this.SearchBookByTypeCheckBox.Text = "Thể loại";
            this.SearchBookByTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookByNameCheckBox
            // 
            this.SearchBookByNameCheckBox.AutoSize = true;
            this.SearchBookByNameCheckBox.Location = new System.Drawing.Point(17, 22);
            this.SearchBookByNameCheckBox.Name = "SearchBookByNameCheckBox";
            this.SearchBookByNameCheckBox.Size = new System.Drawing.Size(87, 24);
            this.SearchBookByNameCheckBox.TabIndex = 2;
            this.SearchBookByNameCheckBox.Text = "Tên sách";
            this.SearchBookByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchBookSearchCriteriaTextBox
            // 
            this.SearchBookSearchCriteriaTextBox.Location = new System.Drawing.Point(85, 53);
            this.SearchBookSearchCriteriaTextBox.Name = "SearchBookSearchCriteriaTextBox";
            this.SearchBookSearchCriteriaTextBox.Size = new System.Drawing.Size(125, 27);
            this.SearchBookSearchCriteriaTextBox.TabIndex = 1;
            // 
            // BookPageSearchBooksButton
            // 
            this.BookPageSearchBooksButton.Location = new System.Drawing.Point(216, 53);
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
            this.BookPageDataGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookPageDataGroup.Location = new System.Drawing.Point(0, 0);
            this.BookPageDataGroup.Name = "BookPageDataGroup";
            this.BookPageDataGroup.Size = new System.Drawing.Size(1018, 478);
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
            this.BookPageDataGridView.Size = new System.Drawing.Size(1012, 452);
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
            // MakeBorrow
            // 
            this.MakeBorrow.Location = new System.Drawing.Point(4, 29);
            this.MakeBorrow.Name = "MakeBorrow";
            this.MakeBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.MakeBorrow.Size = new System.Drawing.Size(1024, 590);
            this.MakeBorrow.TabIndex = 2;
            this.MakeBorrow.Text = "Make Borrow Voucher";
            this.MakeBorrow.UseVisualStyleBackColor = true;
            // 
            // LibraryConfigurationTab
            // 
            this.LibraryConfigurationTab.Controls.Add(this.LibraryConfigurationTab_MainContainer);
            this.LibraryConfigurationTab.Location = new System.Drawing.Point(4, 29);
            this.LibraryConfigurationTab.Name = "LibraryConfigurationTab";
            this.LibraryConfigurationTab.Padding = new System.Windows.Forms.Padding(3);
            this.LibraryConfigurationTab.Size = new System.Drawing.Size(1024, 590);
            this.LibraryConfigurationTab.TabIndex = 3;
            this.LibraryConfigurationTab.Text = "Cấu hình";
            this.LibraryConfigurationTab.UseVisualStyleBackColor = true;
            // 
            // LibraryConfigurationTab_MainContainer
            // 
            this.LibraryConfigurationTab_MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryConfigurationTab_MainContainer.Location = new System.Drawing.Point(3, 3);
            this.LibraryConfigurationTab_MainContainer.Name = "LibraryConfigurationTab_MainContainer";
            this.LibraryConfigurationTab_MainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // LibraryConfigurationTab_MainContainer.Panel1
            // 
            this.LibraryConfigurationTab_MainContainer.Panel1.Controls.Add(this.SearchLibraryConfigurationGroupBox);
            // 
            // LibraryConfigurationTab_MainContainer.Panel2
            // 
            this.LibraryConfigurationTab_MainContainer.Panel2.Controls.Add(this.LibraryConfigurationDataGroupBox);
            this.LibraryConfigurationTab_MainContainer.Size = new System.Drawing.Size(1018, 584);
            this.LibraryConfigurationTab_MainContainer.SplitterDistance = 100;
            this.LibraryConfigurationTab_MainContainer.TabIndex = 0;
            // 
            // SearchLibraryConfigurationGroupBox
            // 
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.SearchConfigurationSearchCriteriaTextBox);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.SearchConfigurationByCodeCheckBox);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.SearchConfigurationByNameCheckBox);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.LibraryConfigurationSearchButton);
            this.SearchLibraryConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLibraryConfigurationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SearchLibraryConfigurationGroupBox.Name = "SearchLibraryConfigurationGroupBox";
            this.SearchLibraryConfigurationGroupBox.Size = new System.Drawing.Size(1018, 100);
            this.SearchLibraryConfigurationGroupBox.TabIndex = 0;
            this.SearchLibraryConfigurationGroupBox.TabStop = false;
            this.SearchLibraryConfigurationGroupBox.Text = "Tìm kiếm";
            // 
            // SearchConfigurationSearchCriteriaTextBox
            // 
            this.SearchConfigurationSearchCriteriaTextBox.Location = new System.Drawing.Point(20, 56);
            this.SearchConfigurationSearchCriteriaTextBox.Name = "SearchConfigurationSearchCriteriaTextBox";
            this.SearchConfigurationSearchCriteriaTextBox.Size = new System.Drawing.Size(125, 27);
            this.SearchConfigurationSearchCriteriaTextBox.TabIndex = 6;
            // 
            // SearchConfigurationByCodeCheckBox
            // 
            this.SearchConfigurationByCodeCheckBox.AutoSize = true;
            this.SearchConfigurationByCodeCheckBox.Location = new System.Drawing.Point(20, 26);
            this.SearchConfigurationByCodeCheckBox.Name = "SearchConfigurationByCodeCheckBox";
            this.SearchConfigurationByCodeCheckBox.Size = new System.Drawing.Size(111, 24);
            this.SearchConfigurationByCodeCheckBox.TabIndex = 5;
            this.SearchConfigurationByCodeCheckBox.Text = "Mã cấu hình";
            this.SearchConfigurationByCodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchConfigurationByNameCheckBox
            // 
            this.SearchConfigurationByNameCheckBox.AutoSize = true;
            this.SearchConfigurationByNameCheckBox.Location = new System.Drawing.Point(137, 26);
            this.SearchConfigurationByNameCheckBox.Name = "SearchConfigurationByNameCheckBox";
            this.SearchConfigurationByNameCheckBox.Size = new System.Drawing.Size(113, 24);
            this.SearchConfigurationByNameCheckBox.TabIndex = 4;
            this.SearchConfigurationByNameCheckBox.Text = "Tên cấu hình";
            this.SearchConfigurationByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // LibraryConfigurationSearchButton
            // 
            this.LibraryConfigurationSearchButton.Location = new System.Drawing.Point(156, 56);
            this.LibraryConfigurationSearchButton.Name = "LibraryConfigurationSearchButton";
            this.LibraryConfigurationSearchButton.Size = new System.Drawing.Size(94, 29);
            this.LibraryConfigurationSearchButton.TabIndex = 0;
            this.LibraryConfigurationSearchButton.Text = "Tìm kiếm";
            this.LibraryConfigurationSearchButton.UseVisualStyleBackColor = true;
            this.LibraryConfigurationSearchButton.Click += new System.EventHandler(this.LibraryConfigurationSearchButton_Click);
            // 
            // LibraryConfigurationDataGroupBox
            // 
            this.LibraryConfigurationDataGroupBox.Controls.Add(this.LibraryConfigurationDataGridView);
            this.LibraryConfigurationDataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryConfigurationDataGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LibraryConfigurationDataGroupBox.Name = "LibraryConfigurationDataGroupBox";
            this.LibraryConfigurationDataGroupBox.Size = new System.Drawing.Size(1018, 480);
            this.LibraryConfigurationDataGroupBox.TabIndex = 0;
            this.LibraryConfigurationDataGroupBox.TabStop = false;
            this.LibraryConfigurationDataGroupBox.Text = "Danh sách cấu hình";
            // 
            // LibraryConfigurationDataGridView
            // 
            this.LibraryConfigurationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LibraryConfigurationDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LibraryConfigurationCodeColumn,
            this.LibraryConfigurationNameColumn,
            this.LibraryConfigurationValueeColumn});
            this.LibraryConfigurationDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibraryConfigurationDataGridView.Location = new System.Drawing.Point(3, 23);
            this.LibraryConfigurationDataGridView.Name = "LibraryConfigurationDataGridView";
            this.LibraryConfigurationDataGridView.RowHeadersWidth = 51;
            this.LibraryConfigurationDataGridView.RowTemplate.Height = 29;
            this.LibraryConfigurationDataGridView.Size = new System.Drawing.Size(1012, 454);
            this.LibraryConfigurationDataGridView.TabIndex = 0;
            // 
            // LibraryConfigurationCodeColumn
            // 
            this.LibraryConfigurationCodeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LibraryConfigurationCodeColumn.HeaderText = "Mã cấu hình";
            this.LibraryConfigurationCodeColumn.MinimumWidth = 6;
            this.LibraryConfigurationCodeColumn.Name = "LibraryConfigurationCodeColumn";
            this.LibraryConfigurationCodeColumn.ReadOnly = true;
            // 
            // LibraryConfigurationNameColumn
            // 
            this.LibraryConfigurationNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LibraryConfigurationNameColumn.HeaderText = "Tên cấu hình";
            this.LibraryConfigurationNameColumn.MinimumWidth = 6;
            this.LibraryConfigurationNameColumn.Name = "LibraryConfigurationNameColumn";
            // 
            // LibraryConfigurationValueeColumn
            // 
            this.LibraryConfigurationValueeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LibraryConfigurationValueeColumn.HeaderText = "Giá trị";
            this.LibraryConfigurationValueeColumn.MinimumWidth = 6;
            this.LibraryConfigurationValueeColumn.Name = "LibraryConfigurationValueeColumn";
            // 
            // STC_AddBook
            // 
            this.STC_AddBook.Controls.Add(this.groupBox1);
            this.STC_AddBook.Location = new System.Drawing.Point(4, 29);
            this.STC_AddBook.Name = "STC_AddBook";
            this.STC_AddBook.Size = new System.Drawing.Size(1024, 590);
            this.STC_AddBook.TabIndex = 4;
            this.STC_AddBook.Text = "Nhận sách mới";
            this.STC_AddBook.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm / Chỉnh sửa thông tin sách";
            // 
            // LibraryManagementSystemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 623);
            this.Controls.Add(this.SystemMainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LibraryManagementSystemUI";
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.LibraryManagementSystemUI_Load);
            this.SystemMainTabControl.ResumeLayout(false);
            this.STC_HomeTP.ResumeLayout(false);
            this.STC_HomeTP.PerformLayout();
            this.STC_BookTP.ResumeLayout(false);
            this.BookPageContainer.Panel1.ResumeLayout(false);
            this.BookPageContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookPageContainer)).EndInit();
            this.BookPageContainer.ResumeLayout(false);
            this.BookPageSearchGroup.ResumeLayout(false);
            this.BookPageSearchGroup.PerformLayout();
            this.BookPageDataGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookPageDataGridView)).EndInit();
            this.LibraryConfigurationTab.ResumeLayout(false);
            this.LibraryConfigurationTab_MainContainer.Panel1.ResumeLayout(false);
            this.LibraryConfigurationTab_MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationTab_MainContainer)).EndInit();
            this.LibraryConfigurationTab_MainContainer.ResumeLayout(false);
            this.SearchLibraryConfigurationGroupBox.ResumeLayout(false);
            this.SearchLibraryConfigurationGroupBox.PerformLayout();
            this.LibraryConfigurationDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationDataGridView)).EndInit();
            this.STC_AddBook.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl SystemMainTabControl;
        private TabPage STC_HomeTP;
        private TabPage STC_BookTP;
        private Button button1;
        private TextBox txtTest;
        private TabPage MakeBorrow;
        private TabPage LibraryConfigurationTab;
        private SplitContainer LibraryConfigurationTab_MainContainer;
        private GroupBox SearchLibraryConfigurationGroupBox;
        private Button LibraryConfigurationSearchButton;
        private GroupBox LibraryConfigurationDataGroupBox;
        private DataGridView LibraryConfigurationDataGridView;
        private DataGridViewTextBoxColumn LibraryConfigurationCodeColumn;
        private DataGridViewTextBoxColumn LibraryConfigurationNameColumn;
        private DataGridViewTextBoxColumn LibraryConfigurationValueeColumn;
        private SplitContainer BookPageContainer;
        private GroupBox BookPageSearchGroup;
        private GroupBox BookPageDataGroup;
        private DataGridView BookPageDataGridView;
        private DataGridViewTextBoxColumn BookPageDataIndexColumn;
        private DataGridViewTextBoxColumn BookPageDataNameColumn;
        private DataGridViewTextBoxColumn BookPageDataType;
        private DataGridViewTextBoxColumn BookPageDataAuthor;
        private DataGridViewTextBoxColumn BookPageDataStatus;
        private Button BookPageSearchBooksButton;
        private Label SearchBookSearchCriteriaLabel;
        private CheckBox SearchBookByStatusCheckBox;
        private CheckBox SearchBookByAuthorCheckBox;
        private CheckBox SearchBookByTypeCheckBox;
        private CheckBox SearchBookByNameCheckBox;
        private TextBox SearchBookSearchCriteriaTextBox;
        private TextBox SearchConfigurationSearchCriteriaTextBox;
        private CheckBox SearchConfigurationByCodeCheckBox;
        private CheckBox SearchConfigurationByNameCheckBox;
        private TabPage STC_AddBook;
        private GroupBox groupBox1;
    }
}