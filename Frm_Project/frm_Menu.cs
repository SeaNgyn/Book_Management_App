using Project_PRN211;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_Project
{
    public partial class frm_Menu : Form
    {
        public string accountName { get; set; }
        public int role { get; set; }
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            
            form1.role = role;
            form1.ShowDialog();

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            lblHeader.Text = $"Hello {accountName}";
            if (role == 1)
            {
                btnAccount.Hide();
                btnCategory.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_BookCategory frm_BookCategory = new frm_BookCategory();
            frm_BookCategory.ShowDialog();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            frm_Account frm_Account = new frm_Account();
            frm_Account.ShowDialog();
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
