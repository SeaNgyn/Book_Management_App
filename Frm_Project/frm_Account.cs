using DataProcess;
using DataProcess.Models;
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
    public partial class frm_Account : Form
    {
        private BookManagementContext db = new BookManagementContext();
        UserAccount usera;
        public frm_Account()
        {
            InitializeComponent();
        }

        private void frm_Account_Load(object sender, EventArgs e)
        {
            dgvAccount.DataSource = db.UserAccounts.ToList();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                usera = (UserAccount)dgvAccount.SelectedRows[0].DataBoundItem;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            db.UserAccounts.Remove(usera);
            db.SaveChanges();
        }

        private void dgvAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.SelectedRows.Count > 0)
            {
                usera = (UserAccount)dgvAccount.SelectedRows[0].DataBoundItem;
            }

            AccountDetail accountDetail = new AccountDetail();
            accountDetail.insertOrUpdate = true;
            accountDetail.UserAccInfor = usera;
            accountDetail.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AccountDetail accountDetail = new AccountDetail();
            accountDetail.insertOrUpdate = false;
            accountDetail.ShowDialog();
        }
    }
}
