namespace e_Journal
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label4 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(10, 116);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(621, 234);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 17F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(279, 11);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(104, 32);
            label4.TabIndex = 6;
            label4.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(279, 159);
            btnLogin.Margin = new Padding(2, 2, 2, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 27);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(186, 110);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(293, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(186, 67);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 27);
            txtEmail.TabIndex = 3;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Red;
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(214, 212);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(223, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't have account ? Create one";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(45, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 22);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(196, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(299, 57);
            label2.TabIndex = 2;
            label2.Text = "e-Journal";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private LinkLabel linkLabel1;
        private Label label4;
    }
}