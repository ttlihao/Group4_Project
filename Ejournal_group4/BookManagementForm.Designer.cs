namespace Ejournal_group4
{
    partial class BookManagementForm
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
            gbBookInfo = new GroupBox();
            dtpReleaseDate = new DateTimePicker();
            tbAuthor = new TextBox();
            tbDescription = new TextBox();
            tbName = new TextBox();
            tbId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            gpTask = new GroupBox();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            gbSearch = new GroupBox();
            tbSearch = new TextBox();
            btnSearch = new Button();
            label7 = new Label();
            dgvBookList = new DataGridView();
            gbBookInfo.SuspendLayout();
            gpTask.SuspendLayout();
            gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            SuspendLayout();
            // 
            // gbBookInfo
            // 
            gbBookInfo.Controls.Add(dtpReleaseDate);
            gbBookInfo.Controls.Add(tbAuthor);
            gbBookInfo.Controls.Add(tbDescription);
            gbBookInfo.Controls.Add(tbName);
            gbBookInfo.Controls.Add(tbId);
            gbBookInfo.Controls.Add(label6);
            gbBookInfo.Controls.Add(label5);
            gbBookInfo.Controls.Add(label4);
            gbBookInfo.Controls.Add(label3);
            gbBookInfo.Controls.Add(label2);
            gbBookInfo.Location = new Point(12, 66);
            gbBookInfo.Name = "gbBookInfo";
            gbBookInfo.Size = new Size(517, 457);
            gbBookInfo.TabIndex = 0;
            gbBookInfo.TabStop = false;
            gbBookInfo.Text = "Book Information";
            // 
            // dtpReleaseDate
            // 
            dtpReleaseDate.Location = new Point(166, 383);
            dtpReleaseDate.Name = "dtpReleaseDate";
            dtpReleaseDate.Size = new Size(295, 27);
            dtpReleaseDate.TabIndex = 9;
            // 
            // tbAuthor
            // 
            tbAuthor.Location = new Point(166, 309);
            tbAuthor.Name = "tbAuthor";
            tbAuthor.Size = new Size(295, 27);
            tbAuthor.TabIndex = 8;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(166, 187);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.ScrollBars = ScrollBars.Vertical;
            tbDescription.Size = new Size(295, 76);
            tbDescription.TabIndex = 7;
            // 
            // tbName
            // 
            tbName.Location = new Point(166, 113);
            tbName.Name = "tbName";
            tbName.Size = new Size(295, 27);
            tbName.TabIndex = 6;
            // 
            // tbId
            // 
            tbId.Location = new Point(166, 50);
            tbId.Name = "tbId";
            tbId.Size = new Size(141, 27);
            tbId.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 116);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 190);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 3;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 312);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 2;
            label4.Text = "Author:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 388);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 1;
            label3.Text = "Date Publish:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 53);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 0;
            label2.Text = "Accession No. :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(299, 54);
            label1.TabIndex = 1;
            label1.Text = "Book Manager";
            // 
            // gpTask
            // 
            gpTask.Controls.Add(btnClose);
            gpTask.Controls.Add(btnDelete);
            gpTask.Controls.Add(btnUpdate);
            gpTask.Controls.Add(btnSave);
            gpTask.Location = new Point(12, 529);
            gpTask.Name = "gpTask";
            gpTask.Size = new Size(517, 110);
            gpTask.TabIndex = 2;
            gpTask.TabStop = false;
            gpTask.Text = "Task Manager";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(403, 46);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 42);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(274, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 42);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(142, 46);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(17, 46);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 42);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(tbSearch);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(label7);
            gbSearch.Location = new Point(559, 66);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(530, 77);
            gbSearch.TabIndex = 3;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search Manager";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(131, 35);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(267, 27);
            tbSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(415, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 38);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 0;
            label7.Text = "Keyword:";
            // 
            // dgvBookList
            // 
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(559, 164);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.RowHeadersWidth = 51;
            dgvBookList.RowTemplate.Height = 29;
            dgvBookList.Size = new Size(530, 475);
            dgvBookList.TabIndex = 4;
            dgvBookList.SelectionChanged += dgvBookList_SelectionChanged;
            // 
            // BookManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 671);
            Controls.Add(dgvBookList);
            Controls.Add(gbSearch);
            Controls.Add(gpTask);
            Controls.Add(label1);
            Controls.Add(gbBookInfo);
            Name = "BookManagementForm";
            Text = "Book Manager";
            FormClosing += BookManagementForm_FormClosing;
            Load += BookManagementForm_Load;
            gbBookInfo.ResumeLayout(false);
            gbBookInfo.PerformLayout();
            gpTask.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbBookInfo;
        private DateTimePicker dtpReleaseDate;
        private TextBox tbAuthor;
        private TextBox tbDescription;
        private TextBox tbName;
        private TextBox tbId;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox gpTask;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private GroupBox gbSearch;
        private Label label7;
        private DataGridView dgvBookList;
        private TextBox tbSearch;
        private Button btnSearch;
    }
}