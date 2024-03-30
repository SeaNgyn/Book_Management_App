using DataProcess;
using DataProcess.Models;
using Frm_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRN211
{
    public partial class login : Form
    {
        private BookManagementContext db = new BookManagementContext();
        public login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<UserAccount> accounts = db.UserAccounts.Where(x => x.Email.Equals(txtEmail.Text)).ToList();

            if (accounts.Count > 0)
            {
                foreach (UserAccount acc in accounts)
                {
                    if (acc.Password.Equals(txtPassword.Text))
                    {
                        frm_Menu frm_Menu = new frm_Menu();
                        if (acc.Role == 1 || acc.Role == 2)
                        {
                            this.Hide();
                            frm_Menu.accountName = acc.FullName;
                            frm_Menu.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            frm_Menu.accountName = acc.FullName;
                            frm_Menu.role = 1;
                            frm_Menu.ShowDialog();
                        }
                        return; 
                    }
                }
                MessageBox.Show("Invalid Password");
            }
            else
            {
                MessageBox.Show("Email not found");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
