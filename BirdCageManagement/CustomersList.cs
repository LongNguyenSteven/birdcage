using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using Services;

namespace BirdCageManagement
{
    public partial class CustomersList : Form
    {
        private readonly IUserService userService;
        public CustomersList()
        {
            InitializeComponent();
            userService = new UserService();

        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
            dgvCustomerList.DataSource = userService.GetUsers().Select(c => new { c.UserId, c.Email, c.Password, c.Fullname, c.Role }).ToList();

        }

        private void dgvCustomerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvCustomerList.CurrentRow.Cells[0].Value.ToString();
            txtEmail.Text = dgvCustomerList.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dgvCustomerList.CurrentRow.Cells[2].Value.ToString();
            txtFullName.Text = dgvCustomerList.CurrentRow.Cells[3].Value.ToString();
            txtRole.Text = dgvCustomerList.CurrentRow.Cells[4].Value.ToString();

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                User usr = new User();
                usr.UserId = txtUserID.Text.Trim();
                usr.Email = txtEmail.Text.Trim();
                usr.Password = txtPassword.Text.Trim();
                usr.Fullname = txtFullName.Text.Trim();
                usr.Role = int.Parse(txtRole.Text.Trim());

                userService.AddUser(usr);
                MessageBox.Show("Add successfully");
                dgvCustomerList.DataSource = userService.GetUsers();
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

