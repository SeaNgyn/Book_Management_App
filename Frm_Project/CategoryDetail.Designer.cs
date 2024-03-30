namespace Frm_Project
{
    partial class CategoryDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryDetail));
            txtCategoryId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtGenreType = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            label4 = new Label();
            ptbHeader = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbHeader).BeginInit();
            SuspendLayout();
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(259, 86);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(257, 27);
            txtCategoryId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 64);
            label1.Location = new Point(63, 87);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 1;
            label1.Text = "Book Category ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 64);
            label2.Location = new Point(63, 143);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 3;
            label2.Text = "Book Genre Type";
            // 
            // txtGenreType
            // 
            txtGenreType.Location = new Point(259, 142);
            txtGenreType.Name = "txtGenreType";
            txtGenreType.Size = new Size(257, 27);
            txtGenreType.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(128, 64, 64);
            label3.Location = new Point(63, 196);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(259, 195);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(257, 113);
            txtDescription.TabIndex = 4;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(63, 253);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 55);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(128, 64, 0);
            label4.Location = new Point(63, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 46);
            label4.TabIndex = 11;
            label4.Text = "Category Detail";
            // 
            // ptbHeader
            // 
            ptbHeader.Image = (Image)resources.GetObject("ptbHeader.Image");
            ptbHeader.InitialImage = (Image)resources.GetObject("ptbHeader.InitialImage");
            ptbHeader.Location = new Point(506, 9);
            ptbHeader.Name = "ptbHeader";
            ptbHeader.Size = new Size(76, 69);
            ptbHeader.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHeader.TabIndex = 12;
            ptbHeader.TabStop = false;
            // 
            // CategoryDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 375);
            Controls.Add(ptbHeader);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtGenreType);
            Controls.Add(label1);
            Controls.Add(txtCategoryId);
            Name = "CategoryDetail";
            Text = "CategoryDetail";
            Load += CategoryDetail_Load;
            ((System.ComponentModel.ISupportInitialize)ptbHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoryId;
        private Label label1;
        private Label label2;
        private TextBox txtGenreType;
        private Label label3;
        private TextBox txtDescription;
        private Button btnSave;
        private Label label4;
        private PictureBox ptbHeader;
    }
}