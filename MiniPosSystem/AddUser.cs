using clsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiniPosSystem; // Added using directive for MiniPosSystem namespace

namespace MiniPosSystem
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNewName.Text) || string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsBL.IsFound(txtNewName.Text.Trim(), txtNewPassword.Text.Trim()))
            {
                txtNewName.Text = "";
                txtNewPassword.Text = "";
                MessageBox.Show("User already exists!", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clsBL.AddNewUser(txtNewName.Text.Trim(), txtNewPassword.Text.Trim()))
            {
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("User added failed!", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
