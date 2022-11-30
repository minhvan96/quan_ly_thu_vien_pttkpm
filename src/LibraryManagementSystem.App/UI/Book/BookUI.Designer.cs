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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookPageDataGridView = new System.Windows.Forms.DataGridView();
            this.BookPageDataIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPageDataStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageContainer)).BeginInit();
            this.BookPageContainer.Panel1.SuspendLayout();
            this.BookPageContainer.Panel2.SuspendLayout();
            this.BookPageContainer.SuspendLayout();
            this.BookPageSearchGroup.SuspendLayout();
            this.BookPageDataGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookPageContainer
            // 
            this.BookPageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookPageContainer.Location = new System.Drawing.Point(0, 0);
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
            this.BookPageContainer.Size = new System.Drawing.Size(1024, 600);
            this.BookPageContainer.SplitterDistance = 101;
            this.BookPageContainer.TabIndex = 1;
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
            this.BookPageSearchGroup.Size = new System.Drawing.Size(1024, 101);
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
            this.BookPageDataGroup.Controls.Add(this.groupBox1);
            this.BookPageDataGroup.Controls.Add(this.BookPageDataGridView);
            this.BookPageDataGroup.Dock = System.Windows.Forms.DockStyle.Left;
            this.BookPageDataGroup.Location = new System.Drawing.Point(0, 0);
            this.BookPageDataGroup.Name = "BookPageDataGroup";
            this.BookPageDataGroup.Size = new System.Drawing.Size(1024, 495);
            this.BookPageDataGroup.TabIndex = 0;
            this.BookPageDataGroup.TabStop = false;
            this.BookPageDataGroup.Text = "Thông tin sách";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(761, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thao tác";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(95, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(13, 346);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(241, 27);
            this.textBox4.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Nhà xuất bản";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 286);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Năm xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tác giả";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 157);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 223);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(241, 27);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thể loại";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(241, 27);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Sách";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(41, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(39, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
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
            this.BookPageDataGridView.Dock = System.Windows.Forms.DockStyle.Left;
            this.BookPageDataGridView.Location = new System.Drawing.Point(3, 23);
            this.BookPageDataGridView.Name = "BookPageDataGridView";
            this.BookPageDataGridView.RowHeadersWidth = 51;
            this.BookPageDataGridView.RowTemplate.Height = 29;
            this.BookPageDataGridView.Size = new System.Drawing.Size(752, 469);
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
            // BookUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BookPageContainer);
            this.Name = "BookUI";
            this.Size = new System.Drawing.Size(1024, 600);
            this.BookPageContainer.Panel1.ResumeLayout(false);
            this.BookPageContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BookPageContainer)).EndInit();
            this.BookPageContainer.ResumeLayout(false);
            this.BookPageSearchGroup.ResumeLayout(false);
            this.BookPageSearchGroup.PerformLayout();
            this.BookPageDataGroup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookPageDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
    }
}
