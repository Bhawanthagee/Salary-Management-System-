﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LoginApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\semester 02\Assignments\C#\final one\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from tbl_Login Where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'",sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if(dtbl.Rows[0][0].ToString()=="1")
            {
                frmMain objFrmMain = new frmMain();
                this.Hide();
                objFrmMain.Show();

            }
            else
            {
                MessageBox.Show("Check username and password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
