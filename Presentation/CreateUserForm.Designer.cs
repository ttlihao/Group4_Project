namespace e_Journal
{
    partial class CreateUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnCreate = new Button();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            txtGmail = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 61);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 179);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Gmail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 61);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 179);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreate);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtGmail);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(51, 93);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(710, 332);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Detail";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(301, 274);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 8;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(488, 179);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(488, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(188, 176);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(125, 27);
            txtGmail.TabIndex = 5;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(188, 61);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(125, 27);
            txtUserName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(352, 31);
            label5.Name = "label5";
            label5.Size = new Size(111, 32);
            label5.TabIndex = 5;
            label5.Text = "Sign In";
            // 
            // CreateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Name = "CreateUserForm";
            Text = "CreateUserForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox txtGmail;
        private TextBox txtUserName;
        private Label label5;
        private Button btnCreate;
        private TextBox txtPhone;
        private TextBox txtPassword;
    }
}