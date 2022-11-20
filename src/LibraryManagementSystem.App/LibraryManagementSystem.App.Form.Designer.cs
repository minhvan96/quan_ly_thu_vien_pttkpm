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
            this.MakeBorrow = new System.Windows.Forms.TabPage();
            this.LibraryConfigurationTab = new System.Windows.Forms.TabPage();
            this.LibraryConfigurationTab_MainContainer = new System.Windows.Forms.SplitContainer();
            this.SearchLibraryConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.LibraryConfigurationSearchButton = new System.Windows.Forms.Button();
            this.LibraryConfigurationDataGroupBox = new System.Windows.Forms.GroupBox();
            this.LibraryConfigurationDataGridView = new System.Windows.Forms.DataGridView();
            this.LibraryConfigurationCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryConfigurationNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryConfigurationValueeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SystemMainTabControl.SuspendLayout();
            this.STC_HomeTP.SuspendLayout();
            this.LibraryConfigurationTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationTab_MainContainer)).BeginInit();
            this.LibraryConfigurationTab_MainContainer.Panel1.SuspendLayout();
            this.LibraryConfigurationTab_MainContainer.Panel2.SuspendLayout();
            this.LibraryConfigurationTab_MainContainer.SuspendLayout();
            this.SearchLibraryConfigurationGroupBox.SuspendLayout();
            this.LibraryConfigurationDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SystemMainTabControl
            // 
            this.SystemMainTabControl.Controls.Add(this.STC_HomeTP);
            this.SystemMainTabControl.Controls.Add(this.STC_BookTP);
            this.SystemMainTabControl.Controls.Add(this.MakeBorrow);
            this.SystemMainTabControl.Controls.Add(this.LibraryConfigurationTab);
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
            this.STC_BookTP.Location = new System.Drawing.Point(4, 29);
            this.STC_BookTP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_BookTP.Name = "STC_BookTP";
            this.STC_BookTP.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STC_BookTP.Size = new System.Drawing.Size(1024, 590);
            this.STC_BookTP.TabIndex = 1;
            this.STC_BookTP.Text = "Tra cứu sách";
            this.STC_BookTP.UseVisualStyleBackColor = true;
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
            this.SearchLibraryConfigurationGroupBox.Controls.Add(this.LibraryConfigurationSearchButton);
            this.SearchLibraryConfigurationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLibraryConfigurationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SearchLibraryConfigurationGroupBox.Name = "SearchLibraryConfigurationGroupBox";
            this.SearchLibraryConfigurationGroupBox.Size = new System.Drawing.Size(1018, 100);
            this.SearchLibraryConfigurationGroupBox.TabIndex = 0;
            this.SearchLibraryConfigurationGroupBox.TabStop = false;
            this.SearchLibraryConfigurationGroupBox.Text = "Tìm kiếm";
            // 
            // LibraryConfigurationSearchButton
            // 
            this.LibraryConfigurationSearchButton.Location = new System.Drawing.Point(445, 42);
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
            this.LibraryConfigurationTab.ResumeLayout(false);
            this.LibraryConfigurationTab_MainContainer.Panel1.ResumeLayout(false);
            this.LibraryConfigurationTab_MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationTab_MainContainer)).EndInit();
            this.LibraryConfigurationTab_MainContainer.ResumeLayout(false);
            this.SearchLibraryConfigurationGroupBox.ResumeLayout(false);
            this.LibraryConfigurationDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LibraryConfigurationDataGridView)).EndInit();
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
    }
}