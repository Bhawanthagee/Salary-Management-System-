using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            AddEmp objAddEmp = new AddEmp();
            this.Hide();
            objAddEmp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateSal_Click(object sender, EventArgs e)
        {

            calculation objcal = new calculation();
            this.Hide();
            objcal.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            frmLogin objlo = new frmLogin();
            this.Hide();
            objlo.Show();
        }
    }
}
