namespace Project_PRN211
{
    partial class frm_BookDetail
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
            btnSave = new Button();
            cbCategory = new ComboBox();
            dtpPubDate = new DateTimePicker();
            label6 = new Label();
            txtAuthor = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtDescription = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label7 = new Label();
            btnClose = new Button();
            groupBox2 = new GroupBox();
            lblHeader = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBookId = new TextBox();
            txtNamee = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(16, 41);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 41);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnAdd_Click;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(235, 435);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(216, 31);
            cbCategory.TabIndex = 7;
            // 
            // dtpPubDate
            // 
            dtpPubDate.Format = DateTimePickerFormat.Short;
            dtpPubDate.Location = new Point(235, 292);
            dtpPubDate.Name = "dtpPubDate";
            dtpPubDate.Size = new Size(216, 30);
            dtpPubDate.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(531, 344);
            label6.Name = "label6";
            label6.Size = new Size(49, 23);
            label6.TabIndex = 13;
            label6.Text = "Price";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(235, 389);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(568, 30);
            txtAuthor.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(603, 337);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(200, 30);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(235, 337);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(216, 30);
            txtQuantity.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(235, 144);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(568, 130);
            txtDescription.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 389);
            label8.Name = "label8";
            label8.Size = new Size(66, 23);
            label8.TabIndex = 14;
            label8.Text = "Author";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 438);
            label9.Name = "label9";
            label9.Size = new Size(84, 23);
            label9.TabIndex = 15;
            label9.Text = "Category";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 344);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 12;
            label7.Text = "Quantity";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(16, 109);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(168, 41);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(btnSave);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox2.Location = new Point(932, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(205, 511);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.FromArgb(128, 64, 0);
            lblHeader.Location = new Point(33, 20);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(354, 50);
            lblHeader.TabIndex = 5;
            lblHeader.Text = "Add | Update Book";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 144);
            label4.Name = "label4";
            label4.Size = new Size(102, 23);
            label4.TabIndex = 10;
            label4.Text = "Description";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 298);
            label5.Name = "label5";
            label5.Size = new Size(143, 23);
            label5.TabIndex = 11;
            label5.Text = "Publication Date";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(235, 52);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(568, 30);
            txtBookId.TabIndex = 0;
            // 
            // txtNamee
            // 
            txtNamee.Location = new Point(235, 97);
            txtNamee.Name = "txtNamee";
            txtNamee.Size = new Size(568, 30);
            txtNamee.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 55);
            label3.Name = "label3";
            label3.Size = new Size(74, 23);
            label3.TabIndex = 8;
            label3.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 100);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 9;
            label2.Text = "Book Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(dtpPubDate);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtBookId);
            groupBox1.Controls.Add(txtNamee);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(128, 64, 0);
            groupBox1.Location = new Point(33, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(872, 511);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "   Book Information";
            // 
            // frm_BookDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 633);
            Controls.Add(groupBox2);
            Controls.Add(lblHeader);
            Controls.Add(groupBox1);
            Name = "frm_BookDetail";
            Text = "frm_BookDetail";
            Load += frm_BookDetail_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private ComboBox cbCategory;
        private DateTimePicker dtpPubDate;
        private Label label6;
        private TextBox txtAuthor;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtDescription;
        private Label label8;
        private Label label9;
        private Label label7;
        private Button btnClose;
        private GroupBox groupBox2;
        private Label lblHeader;
        private Label label4;
        private Label label5;
        private TextBox txtBookId;
        private TextBox txtNamee;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
    }
}