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
    public partial class Invoices : Form
    {
        decimal Total = 0;
        public Invoices()
        {
            InitializeComponent();
        }
        private void _RefreshData()
        {
            DataTable dt = clsBL.GetProducts();
            cbProd.DataSource = dt;
            cbProd.DisplayMember = "Name";
            cbProd.ValueMember = "id";
        }
        private void txQuan_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!string.IsNullOrEmpty(textBox.Text))
            {
                foreach (char c in textBox.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(textBox, "Please enter number only");
                        return;
                    }
                }
                errorProvider1.SetError(textBox, "");
            }
        }
        private void _GetTotal()
        {
            if (Total != 0)
                lbTotal.Text = $"Total: {Total}";
            else
                lbTotal.Text = $"Total: 0";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProd.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txQuan.Text))
            {
                MessageBox.Show("Please enter a value in Product and Quantity",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int productid = Convert.ToInt32(cbProd.SelectedValue);
            int quantity = Convert.ToInt32(txQuan.Text);

            int currentQty = clsBL.GetQuantity(productid);

            if (quantity > currentQty)
            {
                MessageBox.Show($"The quantity available is {currentQty}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txQuan.Clear();
                return;
            }

            int newqty = currentQty - quantity;

            clsBL.UpdateQty(productid, newqty);

            string productName = cbProd.Text;

            DataRowView row = (DataRowView)cbProd.SelectedItem;
            decimal price = Convert.ToDecimal(row["Price"]);

            decimal subTotal = price * quantity;

            dataGridView1.Rows.Add(productName, price, quantity, subTotal, productid);

            Total += subTotal;

            _GetTotal();

            txQuan.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to save", "Error", MessageBoxButtons.OK);
                return;
            }
            bool saved = false;
            int invoiceId = clsBL.SaveInvoice(DateTime.Now, Total);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow)
                    continue;
                int productId = Convert.ToInt32(row.Cells["clIdProd"].Value);
                int qty = Convert.ToInt32(row.Cells["clQuantity"].Value);
                decimal subtotal = Convert.ToDecimal(row.Cells["clSubTotal"].Value);

                saved = clsBL.SaveInvoiceDetails(invoiceId, productId, qty, subtotal);
            }
            if (saved)
            {
                MessageBox.Show("Saved Successufuly", "Pased", MessageBoxButtons.OKCancel);
            }
            dataGridView1.Rows.Clear();
            Total = 0;
            _GetTotal();
        }
        private void Invoices_Load(object sender, EventArgs e)
        {
            _RefreshData();
        }

       
    }
}

