namespace BirdCageManagement
{
    partial class CustomersList
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
            dgvCustomerList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUserID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtRole = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(26, 23);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.RowTemplate.Height = 29;
            dgvCustomerList.Size = new Size(743, 204);
            dgvCustomerList.TabIndex = 0;
            dgvCustomerList.CellContentClick += dgvCustomerList_CellClick;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(26, 254);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 289);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 321);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 254);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "FullName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 299);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 5;
            label5.Text = "Role";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(120, 251);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(226, 27);
            txtUserID.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(120, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(120, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(226, 27);
            txtPassword.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(450, 251);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(184, 27);
            txtFullName.TabIndex = 9;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(450, 296);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(184, 27);
            txtRole.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(146, 379);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(464, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // CustomersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtRole);
            Controls.Add(txtFullName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUserID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCustomerList);
            Name = "CustomersList";
            Text = "CustomersList";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUserID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtFullName;
        private TextBox txtRole;
        private Button btnAdd;
        private Button btnClose;
    }
}