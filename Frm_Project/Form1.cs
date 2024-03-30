using DataProcess;
using DataProcess.Models;
using Microsoft.EntityFrameworkCore;
namespace Project_PRN211
{
    public partial class Form1 : Form
    {
        private BookManagementContext db = new BookManagementContext();
        private List<Book> books;
        Book book;
        public int role { get; set; }
        public Form1()
        {
            InitializeComponent();
            btnLoadFile.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Image image = Image.FromFile("Image\\img1.jpg");
            //ptbHeader.Image = image;
            books = db.Books.ToList();
            dgvManageBook.DataSource = books;
            if (role == 1)
            {
                btnLoadFile.Hide();
                btnAdd.Hide();
                btnDelete.Hide();
            }
        }




        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        foreach (var item in books)
                        {
                            writer.WriteLine(item.ToString());
                        }
                        MessageBox.Show("Save file successfully");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_BookDetail frm_BookDetail = new frm_BookDetail();
            frm_BookDetail.ShowDialog();

        }

        private void dgvManageBook_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (role != 1) 
            {
                //DataGridViewRow selectedRow = dgvManageBook.SelectedRows[0];
                //book.BookId = Convert.ToInt32(selectedRow.Cells[0].Value.ToString());
                //book.BookName = selectedRow.Cells[1].Value.ToString();
                //book.Description = selectedRow.Cells[2].Value.ToString();
                //book.PublicationDate = DateTime.Parse(selectedRow.Cells[3].Value.ToString());
                //book.Quantity = Convert.ToInt32(selectedRow.Cells[4].Value.ToString());
                //book.Price = Convert.ToDouble(selectedRow.Cells[5].Value.ToString());
                //book.Author = selectedRow.Cells[6].Value.ToString();
                //book.BookCategoryId = Convert.ToInt32(selectedRow.Cells[7].Value.ToString());
                frm_BookDetail f = new frm_BookDetail();
                f.SelectedBook = book;
                f.checkUpdateOrAdd = true;
                f.ShowDialog();
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvManageBook.DataSource = null;
            dgvManageBook.DataSource = books.Where(x => x.BookName.ToLower().Contains(txtSearchName.Text.ToLower()) ||
            x.Description.ToLower().Contains(txtSearchDescription.Text.ToLower())).ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to delete this book", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        private void dgvManageBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvManageBook.SelectedRows.Count > 0)
            {
                book = (Book)dgvManageBook.SelectedRows[0].DataBoundItem;
            }

        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] arr = line.Split(';');
                            Book bk = new Book();
                            bk.BookId = Convert.ToInt32(arr[0]);
                            bk.BookName = arr[1];
                            bk.Description = arr[2];
                            bk.PublicationDate = DateTime.Parse(arr[3]);
                            bk.Quantity = Convert.ToInt32(arr[4]);
                            bk.Price = Convert.ToDouble(arr[5]);
                            bk.Author = arr[6];
                            bk.BookCategoryId = Convert.ToInt32(arr[7]);
                            books.Add(bk);
                        }
                        if (books.Count > 0)
                        {
                            MessageBox.Show("Load Successfully");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Dont have any data");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void Form1_Activated(object sender, EventArgs e)
        {
            dgvManageBook.DataSource = books;
        }
    }
}
