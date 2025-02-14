﻿namespace BirdCageManagement;

partial class BirdCageShop
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
        dgvProduct = new DataGridView();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        txtName = new TextBox();
        txtPrice = new TextBox();
        txtDescription = new TextBox();
        txtSpoke = new TextBox();
        btnCompare = new Button();
        btn_ViewCustomer = new Button();
        btn_OrderStory = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
        SuspendLayout();
        // 
        // dgvProduct
        // 
        dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvProduct.Location = new Point(149, 1);
        dgvProduct.Name = "dgvProduct";
        dgvProduct.RowHeadersWidth = 51;
        dgvProduct.RowTemplate.Height = 29;
        dgvProduct.Size = new Size(532, 212);
        dgvProduct.TabIndex = 0;
        dgvProduct.CellClick += dgvProduct_CellClick;
        dgvProduct.CellContentClick += dgvProduct_CellContentClick;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(21, 248);
        label1.Name = "label1";
        label1.Size = new Size(52, 20);
        label1.TabIndex = 1;
        label1.Text = "Name:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(21, 301);
        label2.Name = "label2";
        label2.Size = new Size(44, 20);
        label2.TabIndex = 2;
        label2.Text = "Price:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(21, 355);
        label3.Name = "label3";
        label3.Size = new Size(88, 20);
        label3.TabIndex = 3;
        label3.Text = "Description:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(21, 406);
        label4.Name = "label4";
        label4.Size = new Size(53, 20);
        label4.TabIndex = 4;
        label4.Text = "Spoke:";
        // 
        // txtName
        // 
        txtName.Location = new Point(107, 241);
        txtName.Name = "txtName";
        txtName.Size = new Size(239, 27);
        txtName.TabIndex = 5;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(107, 298);
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(239, 27);
        txtPrice.TabIndex = 6;
        // 
        // txtDescription
        // 
        txtDescription.Location = new Point(107, 348);
        txtDescription.Name = "txtDescription";
        txtDescription.Size = new Size(239, 27);
        txtDescription.TabIndex = 7;
        // 
        // txtSpoke
        // 
        txtSpoke.Location = new Point(107, 399);
        txtSpoke.Name = "txtSpoke";
        txtSpoke.Size = new Size(239, 27);
        txtSpoke.TabIndex = 8;
        // 
        // btnCompare
        // 
        btnCompare.Location = new Point(694, 239);
        btnCompare.Name = "btnCompare";
        btnCompare.Size = new Size(94, 29);
        btnCompare.TabIndex = 9;
        btnCompare.Text = "Compare";
        btnCompare.UseVisualStyleBackColor = true;
        btnCompare.Click += btnCompare_Click;
        // 
        // btn_ViewCustomer
        // 
        btn_ViewCustomer.Location = new Point(650, 355);
        btn_ViewCustomer.Name = "btn_ViewCustomer";
        btn_ViewCustomer.Size = new Size(138, 29);
        btn_ViewCustomer.TabIndex = 10;
        btn_ViewCustomer.Text = "View Customers";
        btn_ViewCustomer.UseVisualStyleBackColor = true;
        btn_ViewCustomer.Click += btn_ViewCustomer_Click;
        // 
        // btn_OrderStory
        // 
        btn_OrderStory.Location = new Point(650, 406);
        btn_OrderStory.Name = "btn_OrderStory";
        btn_OrderStory.Size = new Size(138, 29);
        btn_OrderStory.TabIndex = 11;
        btn_OrderStory.Text = "Latest Order ";
        btn_OrderStory.UseVisualStyleBackColor = true;
        btn_OrderStory.Click += btn_OrderStory_Click;
        // 
        // BirdCageShop
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 524);
        Controls.Add(btn_OrderStory);
        Controls.Add(btn_ViewCustomer);
        Controls.Add(btnCompare);
        Controls.Add(txtSpoke);
        Controls.Add(txtDescription);
        Controls.Add(txtPrice);
        Controls.Add(txtName);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(dgvProduct);
        Name = "BirdCageShop";
        Text = "BirdCageShop";
        Load += BirdCageShop_Load;
        ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dgvProduct;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private TextBox txtName;
    private TextBox txtPrice;
    private TextBox txtDescription;
    private TextBox txtSpoke;
    private Button btnCompare;
    private Button btn_ViewCustomer;
    private Button btn_OrderStory;
}