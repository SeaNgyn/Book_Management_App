
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

namespace Project_PRN211
{
    public partial class frm_BookDetail : Form
    {
        private BookManagementContext db = new BookManagementContext();
        public Book SelectedBook { get; set; }

        public bool checkUpdateOrAdd { get; set; }

        public frm_BookDetail()
        {
            InitializeComponent();
        }

        private void frm_BookDetail_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = db.BookCategories.ToList();
            cbCategory.DisplayMember = "BookGenreType";
            cbCategory.ValueMember = "BookCategoryId";
            txtBookId.Enabled = !checkUpdateOrAdd;
            if (checkUpdateOrAdd == true)
            {
                lblHeader.Text = "Update Book";
                txtBookId.Text = SelectedBook.BookId.ToString();
                txtNamee.Text = SelectedBook.BookName;
                txtDescription.Text = SelectedBook.Description;
                dtpPubDate.Text = SelectedBook.PublicationDate.ToString();
                txtQuantity.Text = SelectedBook.Quantity.ToString();
                txtAuthor.Text = SelectedBook.Author;
                cbCategory.SelectedValue = SelectedBook.BookCategoryId;
            }

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book x = new Book();
            x.BookId = int.Parse(txtBookId.Text);
            x.BookName = txtNamee.Text;
            x.Description = txtDescription.Text;
            x.PublicationDate = DateTime.Parse(dtpPubDate.Text);
            x.Quantity = int.Parse(txtQuantity.Text);
            x.Author = txtAuthor.Text;
            x.BookCategoryId = int.Parse(cbCategory.SelectedValue.ToString());
            if (checkUpdateOrAdd == false)
            {
                Book? bookID = db.Books.FirstOrDefault(x => x.BookId == int.Parse(txtBookId.Text));
                if (bookID != null)
                {
                    MessageBox.Show("ID was existed");
                }
                else
                {
                    db.Books.Add(x);
                    db.SaveChanges();
                }

            }
            else
            {
                db.Books.Update(x);
                db.SaveChanges();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
