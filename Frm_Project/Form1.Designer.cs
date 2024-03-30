namespace Project_PRN211
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvManageBook = new DataGridView();
            btnSaveFile = new Button();
            btnLoadFile = new Button();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtSearchDescription = new TextBox();
            txtSearchName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnClose = new Button();
            ptbHeader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvManageBook).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHeader).BeginInit();
            SuspendLayout();
            // 
            // dgvManageBook
            // 
            dgvManageBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvManageBook.Location = new Point(251, 84);
            dgvManageBook.Name = "dgvManageBook";
            dgvManageBook.RowHeadersWidth = 51;
            dgvManageBook.RowTemplate.Height = 29;
            dgvManageBook.Size = new Size(998, 309);
            dgvManageBook.TabIndex = 6;
            dgvManageBook.CellMouseDoubleClick += dgvManageBook_CellMouseDoubleClick;
            dgvManageBook.SelectionChanged += dgvManageBook_SelectionChanged;
            // 
            // btnSaveFile
            // 
            btnSaveFile.ForeColor = Color.FromArgb(128, 64, 0);
            btnSaveFile.Location = new Point(18, 165);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(139, 41);
            btnSaveFile.TabIndex = 4;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(18, 293);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(139, 41);
            btnLoadFile.TabIndex = 3;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 42);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(140, 41);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearchDescription);
            groupBox1.Controls.Add(txtSearchName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox1.Location = new Point(251, 412);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "   Search";
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(19, 108);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(157, 45);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchDescription
            // 
            txtSearchDescription.Location = new Point(334, 52);
            txtSearchDescription.Multiline = true;
            txtSearchDescription.Name = "txtSearchDescription";
            txtSearchDescription.ScrollBars = ScrollBars.Vertical;
            txtSearchDescription.Size = new Size(231, 101);
            txtSearchDescription.TabIndex = 1;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(19, 52);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(231, 30);
            txtSearchName.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 26);
            label3.Name = "label3";
            label3.Size = new Size(148, 23);
            label3.TabIndex = 4;
            label3.Text = "Book Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 3;
            label2.Text = "Book Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(350, 62);
            label1.TabIndex = 5;
            label1.Text = "Book Manager";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(17, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(140, 41);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(128, 64, 0);
            label8.Location = new Point(963, 609);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 8;
            label8.Text = "© 2025 The Anh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnSaveFile);
            groupBox2.Controls.Add(btnLoadFile);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox2.Location = new Point(30, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 516);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnClose
            // 
            btnClose.ForeColor = Color.FromArgb(128, 64, 0);
            btnClose.Location = new Point(19, 230);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 41);
            btnClose.TabIndex = 5;
            btnClose.Text = "Exit";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // ptbHeader
            // 
            ptbHeader.Image = (Image)resources.GetObject("ptbHeader.Image");
            ptbHeader.InitialImage = (Image)resources.GetObject("ptbHeader.InitialImage");
            ptbHeader.Location = new Point(1158, 9);
            ptbHeader.Name = "ptbHeader";
            ptbHeader.Size = new Size(91, 69);
            ptbHeader.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHeader.TabIndex = 9;
            ptbHeader.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1257, 598);
            Controls.Add(ptbHeader);
            Controls.Add(dgvManageBook);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvManageBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvManageBook;
        private Button btnSaveFile;
        private Button btnLoadFile;
        private Button btnAdd;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearchDescription;
        private TextBox txtSearchName;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Label label8;
        private GroupBox groupBox2;
        private Button btnClose;
        private PictureBox ptbHeader;
    }
}
