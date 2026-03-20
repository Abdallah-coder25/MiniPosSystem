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

namespace MiniPosSystem
{
    public partial class Products : Form
    {
        DataTable dtProducts;
        public Products()
        {
            InitializeComponent();
        }
        private void _RefreshProductsList()
        {
            dtProducts = clsBL.GetProducts();
            dataGridView1.DataSource = dtProducts;
        }
        private bool _checkEmptyFields()
        {
            if (txName.Text == "" || txPrice.Text == "" || txQuantity.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Input Error");
                return false;
            }
            else
                return true;
        }
        public bool _CheckPrice()
        {
            if (!decimal.TryParse(txPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.", "Input Error");
                return false;
            }
            else
                return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!_checkEmptyFields() || !_CheckPrice())
                return;
            string imagePath = pictureBox1.ImageLocation ?? "";
            if (MessageBox.Show("Are you sure you want to add this product?", "Add product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBL.IsAdded(txName.Text, decimal.Parse(txPrice.Text), int.Parse(txQuantity.Text), imagePath))
                {
                    MessageBox.Show("Added successfly?", "Add product");
                    _RefreshProductsList();
                }
                txName.Clear();
                txPrice.Clear();
                txQuantity.Clear();
                pictureBox1.Image = null;
            }
        }
        private void Products_Load(object sender, EventArgs e)
        {
            _RefreshProductsList();
        }
        private void cmDelete_Click(object sender, EventArgs e)
        {
            if (clsBL.UsingProduct((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                MessageBox.Show("This product cannot be deleted beceause it is used in invoiced", "Wraning", MessageBoxButtons.OK);
                return;
            }
            MessageBox.Show("Are you sure you want to delete this product?", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (MessageBox.Show("Are you sure you want to delete this product?", "Delete product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clsBL.DeleteProduct((int)dataGridView1.CurrentRow.Cells[0].Value);
                _RefreshProductsList();
            }
        }
        private void cmEdit_Click(object sender, EventArgs e)
        {
            Update up = new Update((int)dataGridView1.CurrentRow.Cells[0].Value);
            up.ShowDialog();
            _RefreshProductsList();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                pictureBox1.Load(selectedFilePath);
            }
        }
     
        private void txSearch_Enter(object sender, EventArgs e)
        {
            if (txSearch.Text == "Search")
            {
                txSearch.Text = "";
                txSearch.ForeColor = Color.Black;
            }
        }
        private void txSearch_Leave(object sender, EventArgs e)
        {
            if (txSearch.Text == "")
            {
                txSearch.Text = "Search";
                txSearch.ForeColor = Color.Gray;
            }
        }

        private void txSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txSearch.Text == "" || txSearch.Text == "Search")
            {
                _RefreshProductsList();
                return;
            }
            else
            {
                DataView dv = dtProducts.DefaultView;
                dv.RowFilter = $"Name LIKE '%{txSearch.Text}%'";
            }
        }
    }
}
