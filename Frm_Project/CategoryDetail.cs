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

    public partial class CategoryDetail : Form
    {
        private BookManagementContext db = new BookManagementContext();
        public BookCategory bookCate { get; set; }
        public bool InsertOrUpdate { get; set; }
        public CategoryDetail()
        {
            InitializeComponent();
        }

        private void CategoryDetail_Load(object sender, EventArgs e)
        {
            txtCategoryId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtCategoryId.Text = bookCate.BookCategoryId.ToString();
                txtGenreType.Text = bookCate.BookGenreType;
                txtDescription.Text = bookCate.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BookCategory bc = new BookCategory();
            bc.BookCategoryId = int.Parse(txtCategoryId.Text);
            bc.BookGenreType = txtGenreType.Text;
            bc.Description = txtDescription.Text;
            if(InsertOrUpdate == false)
            {
                BookCategory? checkId = db.BookCategories.FirstOrDefault(x => x.BookCategoryId == bc.BookCategoryId);
                if (checkId != null)
                {
                    MessageBox.Show("ID was existed");
                } else
                {
                    db.BookCategories.Add(bc);
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show("Update Success", "Add", MessageBoxButtons.OK);
                    if(result == DialogResult.OK) {
                        this.Close();
                    }
                }
            } else
            {
                db.BookCategories.Update(bc);
                db.SaveChanges();
                DialogResult result = MessageBox.Show("Add Success","Update", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

            
        }
    }
}
