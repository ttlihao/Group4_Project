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
            var result = bookService.GetAllBookID();
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
                var selectedBook = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                txtBookID.Text = selectedBook.BookId.ToString();
                txtBookName.Text = selectedBook.BookName;
                txtDescription.Text = selectedBook.BookDescription;
                dtpReleaseDate.Value = selectedBook.ReleaseDate;
                txtAuthor.Text = selectedBook.Author;
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
                MessageBox.Show("The Book ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBookForm bookForm = new AddBookForm();
            bookForm.ShowDialog();
            var result = bookService.GetAllBookID();
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = result;
        }


        private void txtBookID_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }


        private void dgvBookList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
