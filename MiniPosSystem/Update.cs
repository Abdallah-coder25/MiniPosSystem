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
using static System.Net.Mime.MediaTypeNames;

namespace MiniPosSystem
{
    public partial class Update : Form
    {
        int _ID;
        clsBL _Product;
        public Update(int id)
        {
            InitializeComponent();
            _ID = id;
            _Product = clsBL.Find(id);
        }
        private void _FillProductsInTextbox()
        {
            if (_Product != null)
            {
                txName.Text = _Product.Name;
                txPrice.Text = _Product.Price.ToString();
                txQuantity.Text = _Product.Quantity.ToString();
                if(!string.IsNullOrEmpty(_Product.ImagePath) && System.IO.File.Exists(_Product.ImagePath))
                {
                    pictureBox1.Load(_Product.ImagePath);
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Product.id = _ID;
            _Product.Name = txName.Text;
            _Product.Price = decimal.Parse(txPrice.Text);
            _Product.Quantity = int.Parse(txQuantity.Text);
            _Product.ImagePath = pictureBox1.ImageLocation ?? "";

            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsBL.UpdateProduct(_ID, _Product.Name, _Product.Price, _Product.Quantity, _Product.ImagePath))
                {
                    MessageBox.Show("Product updated successfully !");
                    this.Close();
                }
                else
                {
                   MessageBox.Show("Failed to update the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Failed to update the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Update_Load(object sender, EventArgs e)
        {
            _FillProductsInTextbox();
        }
        private void lnbSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
        private void lnbRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pictureBox1.ImageLocation = null;
        }
    }
}

