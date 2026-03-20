using clsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPosSystem
{
    public partial class Reports : Form
    {
        DataTable dtReports;
        DataView dv;
        public Reports()
        {
            InitializeComponent();
        }
        private void _RefreshData()
        {
            dtReports = clsBL.GetAllReports();
        }
      
        private void Reports_Load(object sender, EventArgs e)
        {
            lbDate.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month,1).ToShortDateString();
            lbDataNow.Text = DateTime.Now.ToString();
            _RefreshData();
            dv = new DataView(dtReports);
            dgv.DataSource = dv;
        }

        private void txDate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string ipDate = txDate.Text.Trim();
                if (dtReports == null)
                    return;


                DataView dtv = dtReports.DefaultView;
                    
                if (string.IsNullOrEmpty(ipDate))
                {
                    dtv.RowFilter = null;
                    return;
                }
                dv.RowFilter = $"CONVERT(Date , 'System.String') LIKE '*{ipDate}*'";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}");
                txDate.Clear();
            }
        }

        private void txDate_Enter(object sender, EventArgs e)
        {
            if (txDate.Text == "d/mm/yyy")
            {
                txDate.Text = "";
                txDate.ForeColor = Color.Black;
            }
        }

        private void txDate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txDate.Text))
            {
                txDate.Text = "d/mm/yyy";
                txDate.ForeColor = Color.Gray;
            }
        }
    }
}
