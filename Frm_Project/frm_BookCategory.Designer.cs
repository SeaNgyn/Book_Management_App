namespace Frm_Project
{
    partial class frm_BookCategory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BookCategory));
            dgvCategoryBook = new DataGridView();
            btnAddBC = new Button();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            txtBookGenre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDelete = new Button();
            label8 = new Label();
            groupBox2 = new GroupBox();
            btnClose = new Button();
            ptbHeader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryBook).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHeader).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoryBook
            // 
            dgvCategoryBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryBook.Location = new Point(252, 83);
            dgvCategoryBook.Name = "dgvCategoryBook";
            dgvCategoryBook.RowHeadersWidth = 51;
            dgvCategoryBook.RowTemplate.Height = 29;
            dgvCategoryBook.ScrollBars = ScrollBars.Horizontal;
            dgvCategoryBook.Size = new Size(542, 309);
            dgvCategoryBook.TabIndex = 11;
            dgvCategoryBook.CellDoubleClick += dgvCategoryBook_CellDoubleClick;
            dgvCategoryBook.SelectionChanged += dgvCategoryBook_SelectionChanged;
            // 
            // btnAddBC
            // 
            btnAddBC.Location = new Point(18, 42);
            btnAddBC.Name = "btnAddBC";
            btnAddBC.Size = new Size(140, 41);
            btnAddBC.TabIndex = 0;
            btnAddBC.Text = "Add";
            btnAddBC.UseVisualStyleBackColor = true;
            btnAddBC.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtBookGenre);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox1.Location = new Point(12, 414);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 178);
            groupBox1.TabIndex = 9;
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
            // txtBookGenre
            // 
            txtBookGenre.Location = new Point(19, 52);
            txtBookGenre.Name = "txtBookGenre";
            txtBookGenre.Size = new Size(231, 30);
            txtBookGenre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 26);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 3;
            label2.Text = "Book genre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(355, 62);
            label1.TabIndex = 10;
            label1.Text = "Category Book";
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
            label8.Location = new Point(945, 605);
            label8.Name = "label8";
            label8.Size = new Size(106, 17);
            label8.TabIndex = 13;
            label8.Text = "© 2025 The Anh";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAddBC);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox2.Location = new Point(12, 70);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(179, 322);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnClose
            // 
            btnClose.ForeColor = Color.FromArgb(128, 64, 0);
            btnClose.Location = new Point(18, 167);
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
            ptbHeader.Location = new Point(718, 5);
            ptbHeader.Name = "ptbHeader";
            ptbHeader.Size = new Size(76, 69);
            ptbHeader.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHeader.TabIndex = 14;
            ptbHeader.TabStop = false;
            // 
            // frm_BookCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 594);
            Controls.Add(ptbHeader);
            Controls.Add(dgvCategoryBook);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Name = "frm_BookCategory";
            Text = "frm_BookCategory";
            Activated += frm_BookCategory_Activated;
            Load += frm_BookCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategoryBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoryBook;
        private Button btnAddBC;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox txtSearchDescription;
        private TextBox txtBookGenre;
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