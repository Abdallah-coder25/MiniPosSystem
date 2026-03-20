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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            plPage.Controls.Clear();
            Products frm = new Products();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            plPage.Controls.Add(frm);
            frm.Show();
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            plPage.Controls.Clear();
            Invoices frm = new Invoices();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            plPage.Controls.Add(frm);
            frm.Show();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            plPage.Controls.Clear();
            Reports frm = new Reports();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            plPage.Controls.Add(frm);
            frm.Show();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You have been logged out.", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
            else
              return;
            
        }
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
