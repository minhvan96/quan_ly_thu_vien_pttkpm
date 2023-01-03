namespace LibraryManagementSystem.App
{
    partial class BookReturn
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.pn_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pn_infoReader = new System.Windows.Forms.Panel();
            this.txt_AuthorName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gb_selelcted = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_header.SuspendLayout();
            this.pn_infoReader.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gb_selelcted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(479, 18);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(94, 29);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Xác nhận";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // pn_header
            // 
            this.pn_header.Controls.Add(this.label1);
            this.pn_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_header.Location = new System.Drawing.Point(0, 0);
            this.pn_header.Name = "pn_header";
            this.pn_header.Size = new System.Drawing.Size(1024, 86);
            this.pn_header.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "GHI NHẬN TRẢ SÁCH";
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
            // pn_infoReader
            // 
            this.pn_infoReader.Controls.Add(this.txt_AuthorName);
            this.pn_infoReader.Controls.Add(this.label2);
            this.pn_infoReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_infoReader.Location = new System.Drawing.Point(0, 0);
            this.pn_infoReader.Name = "pn_infoReader";
            this.pn_infoReader.Size = new System.Drawing.Size(1024, 163);
            this.pn_infoReader.TabIndex = 0;
            // 
            // txt_AuthorName
            // 
            this.txt_AuthorName.Enabled = false;
            this.txt_AuthorName.Location = new System.Drawing.Point(129, 110);
            this.txt_AuthorName.Name = "txt_AuthorName";
            this.txt_AuthorName.Size = new System.Drawing.Size(326, 27);
            this.txt_AuthorName.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_submit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 69);
            this.panel3.TabIndex = 7;
            // 
            // gb_selelcted
            // 
            this.gb_selelcted.Controls.Add(this.dataGridView2);
            this.gb_selelcted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_selelcted.Location = new System.Drawing.Point(0, 163);
            this.gb_selelcted.Name = "gb_selelcted";
            this.gb_selelcted.Size = new System.Drawing.Size(1024, 437);
            this.gb_selelcted.TabIndex = 2;
            this.gb_selelcted.TabStop = false;
            this.gb_selelcted.Text = "Sách đọc giả đã mượn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(1018, 411);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gb_selelcted);
            this.panel1.Controls.Add(this.pn_infoReader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 600);
            this.panel1.TabIndex = 5;
            // 
            // BookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_header);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "BookReturn";
            this.Size = new System.Drawing.Size(1024, 600);
            this.pn_header.ResumeLayout(false);
            this.pn_header.PerformLayout();
            this.pn_infoReader.ResumeLayout(false);
            this.pn_infoReader.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gb_selelcted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_submit;
        private Panel pn_header;
        private Label label1;
        private Label label2;
        private Panel pn_infoReader;
        private TextBox txt_AuthorName;
        private Panel panel3;
        private GroupBox gb_selelcted;
        private DataGridView dataGridView2;
        private Panel panel1;
    }
}
