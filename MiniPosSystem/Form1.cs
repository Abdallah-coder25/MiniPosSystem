using clsBusinessLayer;
using MiniPosSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniPosSystem
{
public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsBL.IsFound(txName.Text.Trim(), txPass.Text.Trim()))
            {
                MainForm mf = new MainForm();
                mf.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Username or password not fount", "Error", MessageBoxButtons.OKCancel);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            AddUser add = new AddUser();
            add.ShowDialog();
        }
    }
}
