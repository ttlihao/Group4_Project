using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using System.Xml.Linq;
using Service;

namespace Ejournal_group4
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
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BookManagementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count > 0)
            {
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                tbId.Text = selectedBook.BookId.ToString();
                tbName.Text = selectedBook.BookName;
                tbDescription.Text = selectedBook.BookDescription;
                dtpReleaseDate.Value = selectedBook.ReleaseDate;
                tbAuthor.Text = selectedBook.Author;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearch.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = bookService.SearchBooks(tbSearch.Text.Trim());

            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(tbId.Text) || !int.TryParse(tbId.Text, out id))
            {
                MessageBox.Show("The Book ID is invalid. Please input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bookService.DeleteABook(id);

            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(tbId.Text) || !int.TryParse(tbId.Text, out id))
            {
                MessageBox.Show("The Book ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            AddBookForm bookForm = new AddBookForm();
            bookForm.BookId = int.Parse(tbId.Text);
            bookForm.ShowDialog();
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBookForm bookForm = new AddBookForm();
            bookForm.BookId = null;
            bookForm.ShowDialog();
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;  
            dgvBookList.DataSource = result;
        }
    }
}