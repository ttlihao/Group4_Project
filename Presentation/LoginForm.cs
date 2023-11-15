using Business.Entities;
using DataAccess.Repositories;
using DataAccess;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace e_Journal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text; //TODO:kiểm tra rỗng!!!
            string password = txtPassword.Text; //TODO: kiểm tra rỗng
            UserAccountService se = new UserAccountService(); ;

            UserAccount account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            else if (account.RoleId == 1)
            {
                BookManagementForm bookMg = new BookManagementForm();
                bookMg.ShowDialog();
                this.Hide();

            }
            else if (account.RoleId == 2)
            {
                User_BookForm bookForm = new User_BookForm();
                try
                {
                    bookForm.Show();
                    this.Hide();
                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            else
            {
                MessageBox.Show("You are not allowed to access this function!",
                                    "Access denied", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return;
            }


            BookManagementForm bookMgt = new BookManagementForm();
            bookMgt.Show();
            this.Hide();

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            CreateUserForm createUserForm = new CreateUserForm();
            createUserForm.Show();
            
        }

       
    }
}