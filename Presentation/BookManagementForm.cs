using Business.Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace e_Journal
{
    public partial class BookManagementForm : Form
    {
        private BookService bookService = new BookService();
        public BookManagementForm()
        {
            InitializeComponent();
        }

        private void BookManagementForm_Load(object sender, EventArgs e)
        {
            var result = bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedRow = dgvBookList.SelectedRows[0];

                var dataItem = selectedRow.DataBoundItem;

                if (dataItem != null)
                {
                    var bookId = (int)dataItem.GetType().GetProperty("BookId").GetValue(dataItem, null);
                    var bookName = (string)dataItem.GetType().GetProperty("BookName").GetValue(dataItem, null);
                    var bookDescription = (string)dataItem.GetType().GetProperty("BookDescription").GetValue(dataItem, null);
                    var releaseDate = (DateTime)dataItem.GetType().GetProperty("ReleaseDate").GetValue(dataItem, null);
                    var author = (string)dataItem.GetType().GetProperty("Author").GetValue(dataItem, null);

                    txtBookID.Text = bookId.ToString();
                    txtBookName.Text = bookName;
                    txtDescription.Text = bookDescription;
                    dtpReleaseDate.Value = releaseDate;
                    txtAuthor.Text = author;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = bookService.SearchBooks(txtSearch.Text.Trim());

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(txtBookID.Text) || !int.TryParse(txtBookID.Text, out id))
            {
                MessageBox.Show("The Book ID is invalid. Please input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bookService.DeleteABook(id);

            var result = bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookForm bookForm = new AddBookForm();
            bookForm.ShowDialog();
            var result = bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookID.Text))
            {
                MessageBox.Show("Please select a book to update.",
                    "Book not selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = int.Parse(txtBookID.Text);
            Book selectedBook = bookService.GetABook(id);

            if (selectedBook == null)
            {
                MessageBox.Show("Invalid book ID. Please select a valid book to update.",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AddBookForm updateForm = new AddBookForm();
            updateForm.SetBookToUpdate(selectedBook);
            updateForm.ShowDialog();

            // After the update form is closed, refresh the data grid view
            var result = bookService.GetAllBooks();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }


        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
