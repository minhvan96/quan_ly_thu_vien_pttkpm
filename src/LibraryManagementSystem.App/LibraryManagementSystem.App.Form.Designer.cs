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
            this.STC_BookTP = new System.Windows.Forms.TabPage();
            this.QueryBookTab = new System.Windows.Forms.TabControl();
            this.QueryBookTab_BookViewPage = new System.Windows.Forms.TabPage();
            this.QueryBookTab_ImportBookPage = new System.Windows.Forms.TabPage();
            this.MakeBorrow = new System.Windows.Forms.TabPage();
            this.LibraryConfigurationTab = new System.Windows.Forms.TabPage();
            this.LibraryConfigurationTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.SearchLibraryConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchConfigurationSearchCriteriaTextBox = new System.Windows.Forms.TextBox();
            this.SearchConfigurationByCodeCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchConfigurationByNameCheckBox = new System.Windows.Forms.CheckBox();
            this.LibraryConfigurationSearchButton = new System.Windows.Forms.Button();
            this.LibraryConfigurationDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LibraryConfigurationDataGridView = new System.Windows.Forms.DataGridView();
            this.LibraryConfigurationCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryConfigurationNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryConfigurationValueeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reader = new System.Windows.Forms.TabPage();
            this.groupBoxReaderInfo = new System.Windows.Forms.GroupBox();
            this.buttonReaderRefresh = new System.Windows.Forms.Button();
            this.labelReaderId = new System.Windows.Forms.Label();
            this.textBoxReaderIdInfo = new System.Windows.Forms.TextBox();
            this.buttonReaderEdit = new System.Windows.Forms.Button();
            this.buttonReaderDelete = new System.Windows.Forms.Button();
            this.buttonReaderAdd = new System.Windows.Forms.Button();
            this.dtpReaderCreateDate = new System.Windows.Forms.DateTimePicker();
            this.labelReaderCreate = new System.Windows.Forms.Label();
            this.dtpReaderBodInfo = new System.Windows.Forms.DateTimePicker();
            this.labelReaderBodInfo = new System.Windows.Forms.Label();
            this.textBoxReaderEmailInfo = new System.Windows.Forms.TextBox();
            this.labelRaederEmailInfo = new System.Windows.Forms.Label();
            this.comboBoxReaderType = new System.Windows.Forms.ComboBox();
            this.labelReaderType = new System.Windows.Forms.Label();
            this.textBoxReaderAddressInfo = new System.Windows.Forms.TextBox();
            this.labelReaderAddressInfo = new System.Windows.Forms.Label();
            this.textBoxReaderNameInfo = new System.Windows.Forms.TextBox();
            this.labelReaderNameInfo = new System.Windows.Forms.Label();
            this.groupBoxDataReader = new System.Windows.Forms.GroupBox();
            this.dataGridViewReader = new System.Windows.Forms.DataGridView();
            this.dgv_Reader_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Reader_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Reader_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Reader_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Reader_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Reader_Bod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Reader_Create_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxReaderSearch = new System.Windows.Forms.GroupBox();
            this.buttonReaderSearch = new System.Windows.Forms.Button();
            this.textBoxSearchReader = new System.Windows.Forms.TextBox();
            this.labelReaderSearch = new System.Windows.Forms.Label();
            this.BorrowBookList = new System.Windows.Forms.TabPage();
            this.STC_BookNew = new System.Windows.Forms.TabPage();
            this.SystemMainTabControl.SuspendLayout();
            this.STC_BookTP.SuspendLayout();
            this.QueryBookTab.SuspendLayout();
            this.LibraryConfigurationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationTab_MainContainer)).BeginInit();
            this.LibraryConfigurationTab_MainContainer.Panel1.SuspendLayout();
            this.LibraryConfigurationTab_MainContainer.Panel2.SuspendLayout();
            this.LibraryConfigurationTab_MainContainer.SuspendLayout();
            this.SearchLibraryConfigurationGroupBox.SuspendLayout();
            this.LibraryConfigurationDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationDataGridView)).BeginInit();
            this.Reader.SuspendLayout();
            this.groupBoxReaderInfo.SuspendLayout();
            this.groupBoxDataReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).BeginInit();
            this.groupBoxReaderSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemMainTabControl
            // 
            this.SystemMainTabControl.Controls.Add(this.STC_HomeTP);
            this.SystemMainTabControl.Controls.Add(this.STC_BookTP);
            this.SystemMainTabControl.Controls.Add(this.MakeBorrow);
            this.SystemMainTabControl.Controls.Add(this.LibraryConfigurationTab);
            this.SystemMainTabControl.Controls.Add(this.Reader);
            this.SystemMainTabControl.Controls.Add(this.BorrowBookList);
            this.SystemMainTabControl.Controls.Add(this.STC_BookNew);
            this.SystemMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SystemMainTabControl.Location = new System.Drawing.Point(0, 0);
            this.SystemMainTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemMainTabControl.Name = "SystemMainTabControl";
            this.SystemMainTabControl.SelectedIndex = 0;
            this.SystemMainTabControl.Size = new System.Drawing.Size(1032, 623);
            this.SystemMainTabControl.TabIndex = 0;
            this.SystemMainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.SystemMainTabControl_Selected);
            // 
            // STC_HomeTP
            // 
            this.STC_HomeTP.Location = new System.Drawing.Point(4, 29);
            this.STC_HomeTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_HomeTP.Name = "STC_HomeTP";
            this.STC_HomeTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_HomeTP.Size = new System.Drawing.Size(1024, 590);
            this.STC_HomeTP.TabIndex = 0;
            this.STC_HomeTP.Text = "HOME";
            this.STC_HomeTP.UseVisualStyleBackColor = true;
            // 
            // STC_BookTP
            // 
            this.STC_BookTP.Controls.Add(this.QueryBookTab);
            this.STC_BookTP.Location = new System.Drawing.Point(4, 29);
            this.STC_BookTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_BookTP.Name = "STC_BookTP";
            this.STC_BookTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_BookTP.Size = new System.Drawing.Size(1024, 590);
            this.STC_BookTP.TabIndex = 1;
            this.STC_BookTP.Text = "Tra cứu sách";
            this.STC_BookTP.UseVisualStyleBackColor = true;
            // 
            // QueryBookTab
            // 
            this.QueryBookTab.Controls.Add(this.QueryBookTab_BookViewPage);
            this.QueryBookTab.Controls.Add(this.QueryBookTab_ImportBookPage);
            this.QueryBookTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryBookTab.Location = new System.Drawing.Point(3, 4);
            this.QueryBookTab.Name = "QueryBookTab";
            this.QueryBookTab.SelectedIndex = 0;
            this.QueryBookTab.Size = new System.Drawing.Size(1018, 582);
            this.QueryBookTab.TabIndex = 0;
            // 
            // QueryBookTab_BookViewPage
            // 
            this.QueryBookTab_BookViewPage.Location = new System.Drawing.Point(4, 29);
            this.QueryBookTab_BookViewPage.Name = "QueryBookTab_BookViewPage";
            this.QueryBookTab_BookViewPage.Padding = new System.Windows.Forms.Padding(3);
            this.QueryBookTab_BookViewPage.Size = new System.Drawing.Size(1010, 549);
            this.QueryBookTab_BookViewPage.TabIndex = 0;
            this.QueryBookTab_BookViewPage.Text = "Thông tin sách";
            this.QueryBookTab_BookViewPage.UseVisualStyleBackColor = true;
            // 
            // QueryBookTab_ImportBookPage
            // 
            this.QueryBookTab_ImportBookPage.Location = new System.Drawing.Point(4, 29);
            this.QueryBookTab_ImportBookPage.Name = "QueryBookTab_ImportBookPage";
            this.QueryBookTab_ImportBookPage.Padding = new System.Windows.Forms.Padding(3);
            this.QueryBookTab_ImportBookPage.Size = new System.Drawing.Size(1010, 549);
            this.QueryBookTab_ImportBookPage.TabIndex = 1;
            this.QueryBookTab_ImportBookPage.Text = "Thêm sách";
            this.QueryBookTab_ImportBookPage.UseVisualStyleBackColor = true;
            // 
            // MakeBorrow
            // 
            this.MakeBorrow.Location = new System.Drawing.Point(4, 29);
            this.MakeBorrow.Name = "MakeBorrow";
            this.MakeBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.MakeBorrow.Size = new System.Drawing.Size(1024, 590);
            this.MakeBorrow.TabIndex = 2;
            this.MakeBorrow.Text = "Lập phiếu mượn";
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
            this.LibraryConfigurationTab_MainContainer.SplitterDistance = 99;
            this.LibraryConfigurationTab_MainContainer.TabIndex = 0;
            // 
            // SearchLibraryConfigurationGroupBox
            // 
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.label1);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.SearchConfigurationSearchCriteriaTextBox);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.SearchConfigurationByCodeCheckBox);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.SearchConfigurationByNameCheckBox);
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.LibraryConfigurationSearchButton);
            this.SearchLibraryConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLibraryConfigurationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SearchLibraryConfigurationGroupBox.Name = "SearchLibraryConfigurationGroupBox";
            this.SearchLibraryConfigurationGroupBox.Size = new System.Drawing.Size(1018, 99);
            this.SearchLibraryConfigurationGroupBox.TabIndex = 0;
            this.SearchLibraryConfigurationGroupBox.TabStop = false;
            this.SearchLibraryConfigurationGroupBox.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Từ khoá";
            // 
            // SearchConfigurationSearchCriteriaTextBox
            // 
            this.SearchConfigurationSearchCriteriaTextBox.Location = new System.Drawing.Point(88, 61);
            this.SearchConfigurationSearchCriteriaTextBox.Name = "SearchConfigurationSearchCriteriaTextBox";
            this.SearchConfigurationSearchCriteriaTextBox.Size = new System.Drawing.Size(125, 27);
            this.SearchConfigurationSearchCriteriaTextBox.TabIndex = 6;
            // 
            // SearchConfigurationByCodeCheckBox
            // 
            this.SearchConfigurationByCodeCheckBox.AutoSize = true;
            this.SearchConfigurationByCodeCheckBox.Location = new System.Drawing.Point(21, 29);
            this.SearchConfigurationByCodeCheckBox.Name = "SearchConfigurationByCodeCheckBox";
            this.SearchConfigurationByCodeCheckBox.Size = new System.Drawing.Size(111, 24);
            this.SearchConfigurationByCodeCheckBox.TabIndex = 5;
            this.SearchConfigurationByCodeCheckBox.Text = "Mã cấu hình";
            this.SearchConfigurationByCodeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchConfigurationByNameCheckBox
            // 
            this.SearchConfigurationByNameCheckBox.AutoSize = true;
            this.SearchConfigurationByNameCheckBox.Location = new System.Drawing.Point(137, 29);
            this.SearchConfigurationByNameCheckBox.Name = "SearchConfigurationByNameCheckBox";
            this.SearchConfigurationByNameCheckBox.Size = new System.Drawing.Size(113, 24);
            this.SearchConfigurationByNameCheckBox.TabIndex = 4;
            this.SearchConfigurationByNameCheckBox.Text = "Tên cấu hình";
            this.SearchConfigurationByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // LibraryConfigurationSearchButton
            // 
            this.LibraryConfigurationSearchButton.Location = new System.Drawing.Point(219, 61);
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
            this.LibraryConfigurationDataGroupBox.Size = new System.Drawing.Size(1018, 481);
            this.LibraryConfigurationDataGroupBox.TabIndex = 0;
            this.LibraryConfigurationDataGroupBox.TabStop = false;
            this.LibraryConfigurationDataGroupBox.Text = "Danh sách cấu hình";
            // 
            // LibraryConfigurationDataGridView
            // 
            this.LibraryConfigurationDataGridView.AllowUserToResizeColumns = false;
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
            this.LibraryConfigurationDataGridView.Size = new System.Drawing.Size(1012, 455);
            this.LibraryConfigurationDataGridView.TabIndex = 0;
            this.LibraryConfigurationDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.LibraryConfigurationDataGridView_CellValueChanged);
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
            // Reader
            // 
            this.Reader.Controls.Add(this.groupBoxReaderInfo);
            this.Reader.Controls.Add(this.groupBoxDataReader);
            this.Reader.Controls.Add(this.groupBoxReaderSearch);
            this.Reader.Location = new System.Drawing.Point(4, 29);
            this.Reader.Name = "Reader";
            this.Reader.Padding = new System.Windows.Forms.Padding(3);
            this.Reader.Size = new System.Drawing.Size(1024, 590);
            this.Reader.TabIndex = 4;
            this.Reader.Text = "Đọc giả";
            this.Reader.UseVisualStyleBackColor = true;
            // 
            // groupBoxReaderInfo
            // 
            this.groupBoxReaderInfo.Controls.Add(this.buttonReaderRefresh);
            this.groupBoxReaderInfo.Controls.Add(this.labelReaderId);
            this.groupBoxReaderInfo.Controls.Add(this.textBoxReaderIdInfo);
            this.groupBoxReaderInfo.Controls.Add(this.buttonReaderEdit);
            this.groupBoxReaderInfo.Controls.Add(this.buttonReaderDelete);
            this.groupBoxReaderInfo.Controls.Add(this.buttonReaderAdd);
            this.groupBoxReaderInfo.Controls.Add(this.dtpReaderCreateDate);
            this.groupBoxReaderInfo.Controls.Add(this.labelReaderCreate);
            this.groupBoxReaderInfo.Controls.Add(this.dtpReaderBodInfo);
            this.groupBoxReaderInfo.Controls.Add(this.labelReaderBodInfo);
            this.groupBoxReaderInfo.Controls.Add(this.textBoxReaderEmailInfo);
            this.groupBoxReaderInfo.Controls.Add(this.labelRaederEmailInfo);
            this.groupBoxReaderInfo.Controls.Add(this.comboBoxReaderType);
            this.groupBoxReaderInfo.Controls.Add(this.labelReaderType);
            this.groupBoxReaderInfo.Controls.Add(this.textBoxReaderAddressInfo);
            this.groupBoxReaderInfo.Controls.Add(this.labelReaderAddressInfo);
            this.groupBoxReaderInfo.Controls.Add(this.textBoxReaderNameInfo);
            this.groupBoxReaderInfo.Controls.Add(this.labelReaderNameInfo);
            this.groupBoxReaderInfo.Location = new System.Drawing.Point(3, 401);
            this.groupBoxReaderInfo.Name = "groupBoxReaderInfo";
            this.groupBoxReaderInfo.Size = new System.Drawing.Size(1012, 185);
            this.groupBoxReaderInfo.TabIndex = 2;
            this.groupBoxReaderInfo.TabStop = false;
            this.groupBoxReaderInfo.Text = "Thông tin đọc giả";
            // 
            // buttonReaderRefresh
            // 
            this.buttonReaderRefresh.Location = new System.Drawing.Point(635, 150);
            this.buttonReaderRefresh.Name = "buttonReaderRefresh";
            this.buttonReaderRefresh.Size = new System.Drawing.Size(94, 29);
            this.buttonReaderRefresh.TabIndex = 18;
            this.buttonReaderRefresh.Text = "Refresh";
            this.buttonReaderRefresh.UseVisualStyleBackColor = true;
            this.buttonReaderRefresh.Click += new System.EventHandler(this.buttonReaderRefresh_Click);
            // 
            // labelReaderId
            // 
            this.labelReaderId.AutoSize = true;
            this.labelReaderId.Location = new System.Drawing.Point(6, 26);
            this.labelReaderId.Name = "labelReaderId";
            this.labelReaderId.Size = new System.Drawing.Size(87, 20);
            this.labelReaderId.TabIndex = 17;
            this.labelReaderId.Text = "Mã đọc giả:";
            // 
            // textBoxReaderIdInfo
            // 
            this.textBoxReaderIdInfo.Location = new System.Drawing.Point(6, 49);
            this.textBoxReaderIdInfo.Name = "textBoxReaderIdInfo";
            this.textBoxReaderIdInfo.ReadOnly = true;
            this.textBoxReaderIdInfo.Size = new System.Drawing.Size(196, 27);
            this.textBoxReaderIdInfo.TabIndex = 16;
            // 
            // buttonReaderEdit
            // 
            this.buttonReaderEdit.Location = new System.Drawing.Point(507, 150);
            this.buttonReaderEdit.Name = "buttonReaderEdit";
            this.buttonReaderEdit.Size = new System.Drawing.Size(94, 29);
            this.buttonReaderEdit.TabIndex = 15;
            this.buttonReaderEdit.Text = "Sửa";
            this.buttonReaderEdit.UseVisualStyleBackColor = true;
            this.buttonReaderEdit.Click += new System.EventHandler(this.buttonReaderEdit_Click);
            // 
            // buttonReaderDelete
            // 
            this.buttonReaderDelete.Location = new System.Drawing.Point(368, 150);
            this.buttonReaderDelete.Name = "buttonReaderDelete";
            this.buttonReaderDelete.Size = new System.Drawing.Size(94, 29);
            this.buttonReaderDelete.TabIndex = 14;
            this.buttonReaderDelete.Text = "Xóa";
            this.buttonReaderDelete.UseVisualStyleBackColor = true;
            this.buttonReaderDelete.Click += new System.EventHandler(this.buttonReaderDelete_Click);
            // 
            // buttonReaderAdd
            // 
            this.buttonReaderAdd.Location = new System.Drawing.Point(236, 150);
            this.buttonReaderAdd.Name = "buttonReaderAdd";
            this.buttonReaderAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonReaderAdd.TabIndex = 13;
            this.buttonReaderAdd.Text = "Thêm";
            this.buttonReaderAdd.UseVisualStyleBackColor = true;
            this.buttonReaderAdd.Click += new System.EventHandler(this.buttonReaderAdd_Click);
            // 
            // dtpReaderCreateDate
            // 
            this.dtpReaderCreateDate.Location = new System.Drawing.Point(507, 102);
            this.dtpReaderCreateDate.Name = "dtpReaderCreateDate";
            this.dtpReaderCreateDate.Size = new System.Drawing.Size(196, 27);
            this.dtpReaderCreateDate.TabIndex = 12;
            // 
            // labelReaderCreate
            // 
            this.labelReaderCreate.AutoSize = true;
            this.labelReaderCreate.Location = new System.Drawing.Point(507, 79);
            this.labelReaderCreate.Name = "labelReaderCreate";
            this.labelReaderCreate.Size = new System.Drawing.Size(97, 20);
            this.labelReaderCreate.TabIndex = 11;
            this.labelReaderCreate.Text = "Ngày lập thẻ:";
            // 
            // dtpReaderBodInfo
            // 
            this.dtpReaderBodInfo.Location = new System.Drawing.Point(253, 102);
            this.dtpReaderBodInfo.Name = "dtpReaderBodInfo";
            this.dtpReaderBodInfo.Size = new System.Drawing.Size(196, 27);
            this.dtpReaderBodInfo.TabIndex = 10;
            // 
            // labelReaderBodInfo
            // 
            this.labelReaderBodInfo.AutoSize = true;
            this.labelReaderBodInfo.Location = new System.Drawing.Point(253, 79);
            this.labelReaderBodInfo.Name = "labelReaderBodInfo";
            this.labelReaderBodInfo.Size = new System.Drawing.Size(77, 20);
            this.labelReaderBodInfo.TabIndex = 9;
            this.labelReaderBodInfo.Text = "Ngày sinh:";
            // 
            // textBoxReaderEmailInfo
            // 
            this.textBoxReaderEmailInfo.Location = new System.Drawing.Point(6, 102);
            this.textBoxReaderEmailInfo.Name = "textBoxReaderEmailInfo";
            this.textBoxReaderEmailInfo.Size = new System.Drawing.Size(196, 27);
            this.textBoxReaderEmailInfo.TabIndex = 8;
            // 
            // labelRaederEmailInfo
            // 
            this.labelRaederEmailInfo.AutoSize = true;
            this.labelRaederEmailInfo.Location = new System.Drawing.Point(6, 79);
            this.labelRaederEmailInfo.Name = "labelRaederEmailInfo";
            this.labelRaederEmailInfo.Size = new System.Drawing.Size(49, 20);
            this.labelRaederEmailInfo.TabIndex = 7;
            this.labelRaederEmailInfo.Text = "Email:";
            // 
            // comboBoxReaderType
            // 
            this.comboBoxReaderType.FormattingEnabled = true;
            this.comboBoxReaderType.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.comboBoxReaderType.Location = new System.Drawing.Point(764, 49);
            this.comboBoxReaderType.Name = "comboBoxReaderType";
            this.comboBoxReaderType.Size = new System.Drawing.Size(196, 28);
            this.comboBoxReaderType.TabIndex = 6;
            // 
            // labelReaderType
            // 
            this.labelReaderType.AutoSize = true;
            this.labelReaderType.Location = new System.Drawing.Point(764, 23);
            this.labelReaderType.Name = "labelReaderType";
            this.labelReaderType.Size = new System.Drawing.Size(94, 20);
            this.labelReaderType.TabIndex = 5;
            this.labelReaderType.Text = "Loại đọc giả:";
            // 
            // textBoxReaderAddressInfo
            // 
            this.textBoxReaderAddressInfo.Location = new System.Drawing.Point(507, 49);
            this.textBoxReaderAddressInfo.Name = "textBoxReaderAddressInfo";
            this.textBoxReaderAddressInfo.Size = new System.Drawing.Size(196, 27);
            this.textBoxReaderAddressInfo.TabIndex = 4;
            // 
            // labelReaderAddressInfo
            // 
            this.labelReaderAddressInfo.AutoSize = true;
            this.labelReaderAddressInfo.Location = new System.Drawing.Point(507, 23);
            this.labelReaderAddressInfo.Name = "labelReaderAddressInfo";
            this.labelReaderAddressInfo.Size = new System.Drawing.Size(58, 20);
            this.labelReaderAddressInfo.TabIndex = 3;
            this.labelReaderAddressInfo.Text = "Địa chỉ:";
            // 
            // textBoxReaderNameInfo
            // 
            this.textBoxReaderNameInfo.Location = new System.Drawing.Point(253, 49);
            this.textBoxReaderNameInfo.Name = "textBoxReaderNameInfo";
            this.textBoxReaderNameInfo.Size = new System.Drawing.Size(196, 27);
            this.textBoxReaderNameInfo.TabIndex = 2;
            // 
            // labelReaderNameInfo
            // 
            this.labelReaderNameInfo.AutoSize = true;
            this.labelReaderNameInfo.Location = new System.Drawing.Point(253, 26);
            this.labelReaderNameInfo.Name = "labelReaderNameInfo";
            this.labelReaderNameInfo.Size = new System.Drawing.Size(89, 20);
            this.labelReaderNameInfo.TabIndex = 1;
            this.labelReaderNameInfo.Text = "Tên đọc giả:";
            // 
            // groupBoxDataReader
            // 
            this.groupBoxDataReader.Controls.Add(this.dataGridViewReader);
            this.groupBoxDataReader.Location = new System.Drawing.Point(3, 93);
            this.groupBoxDataReader.Name = "groupBoxDataReader";
            this.groupBoxDataReader.Size = new System.Drawing.Size(1015, 305);
            this.groupBoxDataReader.TabIndex = 1;
            this.groupBoxDataReader.TabStop = false;
            this.groupBoxDataReader.Text = "Danh sách đọc giả";
            // 
            // dataGridViewReader
            // 
            this.dataGridViewReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Reader_Id,
            this.dgv_Reader_Name,
            this.dgv_Reader_Address,
            this.dgv_Reader_Type,
            this.dgv_Reader_Email,
            this.dgv_Reader_Bod,
            this.dgv_Reader_Create_Date});
            this.dataGridViewReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReader.Location = new System.Drawing.Point(3, 23);
            this.dataGridViewReader.Name = "dataGridViewReader";
            this.dataGridViewReader.RowHeadersWidth = 51;
            this.dataGridViewReader.RowTemplate.Height = 29;
            this.dataGridViewReader.Size = new System.Drawing.Size(1009, 279);
            this.dataGridViewReader.TabIndex = 0;
            this.dataGridViewReader.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReader_CellClick);
            // 
            // dgv_Reader_Id
            // 
            this.dgv_Reader_Id.HeaderText = "Id";
            this.dgv_Reader_Id.MinimumWidth = 6;
            this.dgv_Reader_Id.Name = "dgv_Reader_Id";
            this.dgv_Reader_Id.Visible = false;
            this.dgv_Reader_Id.Width = 125;
            // 
            // dgv_Reader_Name
            // 
            this.dgv_Reader_Name.FillWeight = 200F;
            this.dgv_Reader_Name.HeaderText = "Họ và tên";
            this.dgv_Reader_Name.MinimumWidth = 6;
            this.dgv_Reader_Name.Name = "dgv_Reader_Name";
            this.dgv_Reader_Name.Width = 125;
            // 
            // dgv_Reader_Address
            // 
            this.dgv_Reader_Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Reader_Address.HeaderText = "Địa chỉ";
            this.dgv_Reader_Address.MinimumWidth = 6;
            this.dgv_Reader_Address.Name = "dgv_Reader_Address";
            // 
            // dgv_Reader_Type
            // 
            this.dgv_Reader_Type.HeaderText = "Loại đọc giả";
            this.dgv_Reader_Type.MinimumWidth = 6;
            this.dgv_Reader_Type.Name = "dgv_Reader_Type";
            this.dgv_Reader_Type.Width = 125;
            // 
            // dgv_Reader_Email
            // 
            this.dgv_Reader_Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgv_Reader_Email.FillWeight = 200F;
            this.dgv_Reader_Email.HeaderText = "Email";
            this.dgv_Reader_Email.MinimumWidth = 6;
            this.dgv_Reader_Email.Name = "dgv_Reader_Email";
            this.dgv_Reader_Email.ReadOnly = true;
            // 
            // dgv_Reader_Bod
            // 
            this.dgv_Reader_Bod.HeaderText = "Ngày sinh";
            this.dgv_Reader_Bod.MinimumWidth = 6;
            this.dgv_Reader_Bod.Name = "dgv_Reader_Bod";
            this.dgv_Reader_Bod.Width = 125;
            // 
            // dgv_Reader_Create_Date
            // 
            this.dgv_Reader_Create_Date.HeaderText = "Ngày lập thẻ";
            this.dgv_Reader_Create_Date.MinimumWidth = 6;
            this.dgv_Reader_Create_Date.Name = "dgv_Reader_Create_Date";
            this.dgv_Reader_Create_Date.Width = 125;
            // 
            // groupBoxReaderSearch
            // 
            this.groupBoxReaderSearch.Controls.Add(this.buttonReaderSearch);
            this.groupBoxReaderSearch.Controls.Add(this.textBoxSearchReader);
            this.groupBoxReaderSearch.Controls.Add(this.labelReaderSearch);
            this.groupBoxReaderSearch.Location = new System.Drawing.Point(3, 5);
            this.groupBoxReaderSearch.Name = "groupBoxReaderSearch";
            this.groupBoxReaderSearch.Size = new System.Drawing.Size(1018, 81);
            this.groupBoxReaderSearch.TabIndex = 0;
            this.groupBoxReaderSearch.TabStop = false;
            this.groupBoxReaderSearch.Text = "Tìm kiếm";
            // 
            // buttonReaderSearch
            // 
            this.buttonReaderSearch.Location = new System.Drawing.Point(355, 33);
            this.buttonReaderSearch.Name = "buttonReaderSearch";
            this.buttonReaderSearch.Size = new System.Drawing.Size(94, 29);
            this.buttonReaderSearch.TabIndex = 2;
            this.buttonReaderSearch.Text = "Tìm kiếm";
            this.buttonReaderSearch.UseVisualStyleBackColor = true;
            this.buttonReaderSearch.Click += new System.EventHandler(this.buttonReaderSearch_Click);
            // 
            // textBoxSearchReader
            // 
            this.textBoxSearchReader.Location = new System.Drawing.Point(123, 33);
            this.textBoxSearchReader.Name = "textBoxSearchReader";
            this.textBoxSearchReader.Size = new System.Drawing.Size(217, 27);
            this.textBoxSearchReader.TabIndex = 1;
            // 
            // labelReaderSearch
            // 
            this.labelReaderSearch.AutoSize = true;
            this.labelReaderSearch.Location = new System.Drawing.Point(29, 37);
            this.labelReaderSearch.Name = "labelReaderSearch";
            this.labelReaderSearch.Size = new System.Drawing.Size(89, 20);
            this.labelReaderSearch.TabIndex = 0;
            this.labelReaderSearch.Text = "Tên đọc giả:";
            // 
            // BorrowBookList
            // 
            this.BorrowBookList.Location = new System.Drawing.Point(4, 29);
            this.BorrowBookList.Name = "BorrowBookList";
            this.BorrowBookList.Padding = new System.Windows.Forms.Padding(3);
            this.BorrowBookList.Size = new System.Drawing.Size(1024, 590);
            this.BorrowBookList.TabIndex = 5;
            this.BorrowBookList.Text = "Danh sách mượn";
            this.BorrowBookList.UseVisualStyleBackColor = true;
            // 
            // STC_BookNew
            // 
            this.STC_BookNew.Location = new System.Drawing.Point(4, 29);
            this.STC_BookNew.Name = "STC_BookNew";
            this.STC_BookNew.Size = new System.Drawing.Size(1024, 590);
            this.STC_BookNew.TabIndex = 6;
            this.STC_BookNew.Text = "Thêm Sách";
            this.STC_BookNew.UseVisualStyleBackColor = true;
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
            this.STC_BookTP.ResumeLayout(false);
            this.QueryBookTab.ResumeLayout(false);
            this.LibraryConfigurationTab.ResumeLayout(false);
            this.LibraryConfigurationTab_MainContainer.Panel1.ResumeLayout(false);
            this.LibraryConfigurationTab_MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationTab_MainContainer)).EndInit();
            this.LibraryConfigurationTab_MainContainer.ResumeLayout(false);
            this.SearchLibraryConfigurationGroupBox.ResumeLayout(false);
            this.SearchLibraryConfigurationGroupBox.PerformLayout();
            this.LibraryConfigurationDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationDataGridView)).EndInit();
            this.Reader.ResumeLayout(false);
            this.groupBoxReaderInfo.ResumeLayout(false);
            this.groupBoxReaderInfo.PerformLayout();
            this.groupBoxDataReader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReader)).EndInit();
            this.groupBoxReaderSearch.ResumeLayout(false);
            this.groupBoxReaderSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl SystemMainTabControl;
        private TabPage STC_BookTP;
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
        private TextBox SearchConfigurationSearchCriteriaTextBox;
        private CheckBox SearchConfigurationByCodeCheckBox;
        private CheckBox SearchConfigurationByNameCheckBox;
        private Label label1;
        private TabPage Reader;
        private GroupBox groupBoxReaderSearch;
        private Button buttonReaderSearch;
        private TextBox textBoxSearchReader;
        private Label labelReaderSearch;
        private GroupBox groupBoxDataReader;
        private DataGridView dataGridViewReader;
        private GroupBox groupBoxReaderInfo;
        private ComboBox comboBoxReaderType;
        private Label labelReaderType;
        private TextBox textBoxReaderAddressInfo;
        private Label labelReaderAddressInfo;
        private TextBox textBoxReaderNameInfo;
        private Label labelReaderNameInfo;
        private TextBox textBoxReaderEmailInfo;
        private Label labelRaederEmailInfo;
        private Label labelReaderBodInfo;
        private Button buttonReaderEdit;
        private Button buttonReaderDelete;
        private Button buttonReaderAdd;
        private DateTimePicker dtpReaderCreateDate;
        private Label labelReaderCreate;
        private DateTimePicker dtpReaderBodInfo;
        private TabPage BorrowBookList;
        private TabPage STC_BookNew;
        private TabControl QueryBookTab;
        private TabPage QueryBookTab_BookViewPage;
        private TabPage QueryBookTab_ImportBookPage;
        private Label labelReaderId;
        private TextBox textBoxReaderIdInfo;
        private DataGridViewTextBoxColumn dgv_Reader_Id;
        private DataGridViewTextBoxColumn dgv_Reader_Name;
        private DataGridViewTextBoxColumn dgv_Reader_Address;
        private DataGridViewTextBoxColumn dgv_Reader_Type;
        private DataGridViewTextBoxColumn dgv_Reader_Email;
        private DataGridViewTextBoxColumn dgv_Reader_Bod;
        private DataGridViewTextBoxColumn dgv_Reader_Create_Date;
        private Button buttonReaderRefresh;
        private TabPage STC_HomeTP;
    }
}