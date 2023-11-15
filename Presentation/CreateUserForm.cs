using Business.Entities;

using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Journal
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text) ||
                String.IsNullOrEmpty(txtGmail.Text) ||
                String.IsNullOrEmpty(txtPassword.Text) ||
                String.IsNullOrEmpty(txtPhone.Text)) 
            {
                MessageBox.Show("Required all fields!");
                return;
            }
            var user = new UserAccount();
            user.UserName = txtUserName.Text;
            user.UserAddress = txtGmail.Text;
            user.UserPassword = txtPassword.Text;
            user.UserPhone = txtPhone.Text;
            user.RoleId = 2;
            UserAccountRepository repo = new UserAccountRepository();
            repo.Create(user);
            MessageBox.Show("Create Successfully!");
            this.Close();
            
            
        }
    }
}
