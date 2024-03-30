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
    public partial class frm_BookCategory : Form
    {
        private BookManagementContext db = new BookManagementContext();
        BookCategory bc;
        private List<BookCategory> bookCate;
        public frm_BookCategory()
        {
            InitializeComponent();
        }

        private void frm_BookCategory_Load(object sender, EventArgs e)
        {
            bookCate = db.BookCategories.ToList();
            dgvCategoryBook.DataSource = bookCate;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCategoryBook.DataSource = null;
            dgvCategoryBook.DataSource = db.BookCategories.Select(x => new BookCategory
            {
                BookCategoryId = x.BookCategoryId,
                BookGenreType = x.BookGenreType,
                Description = x.Description
            }).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryDetail categoryDetail = new CategoryDetail();
            categoryDetail.ShowDialog();
        }

        private void dgvCategoryBook_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoryBook.SelectedRows.Count > 0)
            {
                bc = (BookCategory)dgvCategoryBook.SelectedRows[0].DataBoundItem;
            }

            CategoryDetail categoryDetail = new CategoryDetail();
            categoryDetail.InsertOrUpdate = true;
            categoryDetail.bookCate = bc;
            categoryDetail.ShowDialog();

        }

        private void frm_BookCategory_Activated(object sender, EventArgs e)
        {
            dgvCategoryBook.DataSource = null;
            dgvCategoryBook.DataSource = db.BookCategories.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Book> bookTemp = db.Books.Where(x => x.BookCategoryId == bc.BookCategoryId).ToList();
            if (bookTemp != null)
            {
                foreach (Book book in bookTemp)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
                db.BookCategories.Remove(bc);
                db.SaveChanges();

            }
        }

        private void dgvCategoryBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoryBook.SelectedRows.Count > 0)
            {
                bc = (BookCategory)dgvCategoryBook.SelectedRows[0].DataBoundItem;
            }
        }
    }
}
