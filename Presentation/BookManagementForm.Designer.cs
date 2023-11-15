namespace e_Journal
{
    partial class BookManagementForm
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtBookID = new TextBox();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            rdActive = new RadioButton();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dateRelease = new DateTimePicker();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(dateRelease);
            groupBox1.Controls.Add(rdActive);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1136, 288);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infomation";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Linen;
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(btnLogout);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(12, 306);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1136, 67);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "To-do";
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(145, 45);
            txtBookID.Name = "txtBookID";
            txtBookID.ReadOnly = true;
            txtBookID.Size = new Size(300, 31);
            txtBookID.TabIndex = 0;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(145, 101);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(300, 31);
            txtBookName.TabIndex = 2;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(653, 45);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(419, 31);
            txtAuthor.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(653, 101);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(419, 181);
            txtDescription.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 45);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 5;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 107);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 6;
            label2.Text = "Book Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 107);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 7;
            label3.Text = "Description";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 160);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 8;
            label4.Text = "Release Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(570, 48);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 9;
            label5.Text = "Author";
            // 
            // rdActive
            // 
            rdActive.AutoSize = true;
            rdActive.Location = new Point(145, 210);
            rdActive.Name = "rdActive";
            rdActive.Size = new Size(85, 29);
            rdActive.TabIndex = 10;
            rdActive.TabStop = true;
            rdActive.Text = "Active";
            rdActive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add ";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(175, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(316, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(960, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1136, 325);
            dataGridView1.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(800, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point);
            txtSearch.Location = new Point(456, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Type Book Name here ...";
            txtSearch.Size = new Size(317, 28);
            txtSearch.TabIndex = 5;
            // 
            // dateRelease
            // 
            dateRelease.Location = new Point(145, 154);
            dateRelease.Name = "dateRelease";
            dateRelease.Size = new Size(300, 31);
            dateRelease.TabIndex = 11;
            // 
            // PublicationManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1160, 716);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "PublicationManagementForm";
            Text = "Publication";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtBookName;
        private TextBox txtBookID;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton rdActive;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DateTimePicker dateRelease;
    }
}