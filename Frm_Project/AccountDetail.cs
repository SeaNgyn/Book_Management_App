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

    public partial class AccountDetail : Form
    {
        private BookManagementContext db = new BookManagementContext();
        public UserAccount UserAccInfor { get; set; }
        public bool insertOrUpdate { get; set; }
        public AccountDetail()
        {
            InitializeComponent();
        }

        private void AccountDetail_Load(object sender, EventArgs e)
        {
            txtId.Enabled = !insertOrUpdate;
            if (insertOrUpdate == true)
            {
                txtId.Text = UserAccInfor.MemberId.ToString();
                txtPass.Text = UserAccInfor.Password.ToString();
                txtEmail.Text = UserAccInfor.Email.ToString();
                txtFullname.Text = UserAccInfor.FullName.ToString();
                txtRole.Text = UserAccInfor.Role == 1 ? "Admin" : "Member";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserAccount acc = new UserAccount();
            acc.MemberId = int.Parse(txtId.Text);
            acc.Password = txtPass.Text;
            acc.Email = txtEmail.Text;
            acc.FullName = txtFullname.Text;
            acc.Role = int.Parse(txtRole.Text);
            if(insertOrUpdate != false)
            {
                db.UserAccounts.Update(acc);
                db.SaveChanges();
            } else
            {
                UserAccount? checkId = db.UserAccounts.FirstOrDefault(x => x.MemberId == int.Parse(txtId.Text));
                if(checkId != null)
                {
                    MessageBox.Show("Id was existed!!");
                } else
                {
                    db.UserAccounts.Add(acc);
                    db.SaveChanges();
                }
            }
        }
    }
}
