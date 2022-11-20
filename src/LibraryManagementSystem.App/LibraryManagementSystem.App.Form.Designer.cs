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
            this.SystemMainTabControl.SuspendLayout();
            this.STC_HomeTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // SystemMainTabControl
            // 
            this.SystemMainTabControl.Controls.Add(this.STC_HomeTP);
            this.SystemMainTabControl.Controls.Add(this.STC_BookTP);
            this.SystemMainTabControl.Controls.Add(this.MakeBorrow);
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
            this.STC_BookTP.Size = new System.Drawing.Size(1024, 600);
            this.STC_BookTP.TabIndex = 1;
            this.STC_BookTP.Text = "Tra cứu sách";
            this.STC_BookTP.UseVisualStyleBackColor = true;
            // 
            // MakeBorrow
            // 
            this.MakeBorrow.Location = new System.Drawing.Point(4, 29);
            this.MakeBorrow.Name = "MakeBorrow";
            this.MakeBorrow.Padding = new System.Windows.Forms.Padding(3);
            this.MakeBorrow.Size = new System.Drawing.Size(1024, 600);
            this.MakeBorrow.TabIndex = 2;
            this.MakeBorrow.Text = "Make Borrow Voucher";
            this.MakeBorrow.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl SystemMainTabControl;
        private TabPage STC_HomeTP;
        private TabPage STC_BookTP;
        private Button button1;
        private TextBox txtTest;
        private TabPage MakeBorrow;
    }
}