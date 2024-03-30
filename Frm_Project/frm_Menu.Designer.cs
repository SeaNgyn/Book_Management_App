namespace Frm_Project
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            lblHeader = new Label();
            btnAccount = new Button();
            button2 = new Button();
            btnCategory = new Button();
            ptbHeader = new PictureBox();
            btnCLose = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbHeader).BeginInit();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeader.ForeColor = Color.Maroon;
            lblHeader.Location = new Point(117, 35);
            lblHeader.Margin = new Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(84, 38);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Hello";
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(117, 285);
            btnAccount.Margin = new Padding(4);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(241, 60);
            btnAccount.TabIndex = 1;
            btnAccount.Text = "Account Management";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // button2
            // 
            button2.Location = new Point(117, 94);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(241, 60);
            button2.TabIndex = 2;
            button2.Text = "List Book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(117, 187);
            btnCategory.Margin = new Padding(4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(241, 60);
            btnCategory.TabIndex = 3;
            btnCategory.Text = "Category Book";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += button3_Click;
            // 
            // ptbHeader
            // 
            ptbHeader.Image = (Image)resources.GetObject("ptbHeader.Image");
            ptbHeader.InitialImage = (Image)resources.GetObject("ptbHeader.InitialImage");
            ptbHeader.Location = new Point(12, 12);
            ptbHeader.Name = "ptbHeader";
            ptbHeader.Size = new Size(76, 69);
            ptbHeader.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHeader.TabIndex = 10;
            ptbHeader.TabStop = false;
            // 
            // btnCLose
            // 
            btnCLose.Location = new Point(117, 373);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(241, 63);
            btnCLose.TabIndex = 11;
            btnCLose.Text = "Close";
            btnCLose.UseVisualStyleBackColor = true;
            btnCLose.Click += btnCLose_Click;
            // 
            // frm_Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 448);
            Controls.Add(btnCLose);
            Controls.Add(ptbHeader);
            Controls.Add(btnCategory);
            Controls.Add(button2);
            Controls.Add(btnAccount);
            Controls.Add(lblHeader);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(128, 64, 0);
            Margin = new Padding(4);
            Name = "frm_Menu";
            Text = "frm_Menu";
            Load += frm_Menu_Load;
            ((System.ComponentModel.ISupportInitialize)ptbHeader).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private Button btnAccount;
        private Button button2;
        private Button btnCategory;
        private PictureBox ptbHeader;
        private Button btnCLose;
    }
}