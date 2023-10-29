using BussinessObject.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdCageManagement
{
    public partial class OrderStories : Form
    {
        private readonly IOrderDetailService orderDetailService;

        public OrderStories()
        {
            InitializeComponent();
            orderDetailService = new OrderDetailService();

        }
        private void OrderDetailList_Load(object sender, EventArgs e)
        {
            dgvOrderDetailList.DataSource = orderDetailService.GetOrderDetails().Select(c => new { c.OrderDetailId, c.ProductId, c.OrderId, c.Quantity, c.Price }).ToList();

        }

        private void dgvOrderDetailList_Click(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderDetailID.Text = dgvOrderDetailList.CurrentRow.Cells[0].Value.ToString();
            txtProductID.Text = dgvOrderDetailList.CurrentRow.Cells[1].Value.ToString();
            txtOrderID.Text = dgvOrderDetailList.CurrentRow.Cells[2].Value.ToString();
            txtQuantity.Text = dgvOrderDetailList.CurrentRow.Cells[3].Value.ToString();
            txtPrice.Text = dgvOrderDetailList.CurrentRow.Cells[4].Value.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail od = new OrderDetail();
                od.OrderDetailId = txtOrderDetailID.Text.Trim();
                od.ProductId = txtProductID.Text.Trim();
                od.OrderId = txtOrderID.Text.Trim();
                od.Quantity = int.Parse(txtQuantity.Text.Trim());
                od.Price = int.Parse(txtPrice.Text.Trim());

                orderDetailService.AddOrderDetail(od);
                MessageBox.Show("Add successfully");
                dgvOrderDetailList.DataSource = orderDetailService.GetOrderDetails();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid data type for one or more fields.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
