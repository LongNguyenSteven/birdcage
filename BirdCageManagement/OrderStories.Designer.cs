namespace BirdCageManagement
{
    partial class OrderStories
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
            dgvOrderDetailList = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtOrderDetailID = new TextBox();
            txtProductID = new TextBox();
            txtOrderID = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).BeginInit();
            SuspendLayout();
            // 
            // dgvOrderDetailList
            // 
            dgvOrderDetailList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetailList.Location = new Point(12, 12);
            dgvOrderDetailList.Name = "dgvOrderDetailList";
            dgvOrderDetailList.RowHeadersWidth = 51;
            dgvOrderDetailList.RowTemplate.Height = 29;
            dgvOrderDetailList.Size = new Size(716, 252);
            dgvOrderDetailList.TabIndex = 0;
            dgvOrderDetailList.CellContentClick += dgvOrderDetailList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 283);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 1;
            label1.Text = "OrderDetailID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 327);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "ProductID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 374);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "OrderID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(418, 283);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 4;
            label4.Text = "Quantity: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 334);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "Price:";
            // 
            // txtOrderDetailID
            // 
            txtOrderDetailID.Location = new Point(139, 283);
            txtOrderDetailID.Name = "txtOrderDetailID";
            txtOrderDetailID.Size = new Size(253, 27);
            txtOrderDetailID.TabIndex = 6;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(139, 324);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(253, 27);
            txtProductID.TabIndex = 7;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(139, 371);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(253, 27);
            txtOrderID.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(495, 280);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(220, 27);
            txtQuantity.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(495, 334);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(220, 27);
            txtPrice.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(139, 424);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(482, 424);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // OrderStories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnClose);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtOrderID);
            Controls.Add(txtProductID);
            Controls.Add(txtOrderDetailID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvOrderDetailList);
            Name = "OrderStories";
            Text = "OrderStories";
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetailList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrderDetailList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtOrderDetailID;
        private TextBox txtProductID;
        private TextBox txtOrderID;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnAdd;
        private Button btnClose;
    }
}