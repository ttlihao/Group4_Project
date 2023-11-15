using Business.Entities;
using Business.Repositories;
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
            UserAccountService  se = new UserAccountService(); ;

            UserAccount account = se.CheckLogin(email, password);
            if (account == null)
            {
                MessageBox.Show("Login failed. Please check your credentials",
                                 "Wrong credentials", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }
            if (account.RoleId != 1)
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
    }
}