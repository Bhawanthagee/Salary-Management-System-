using System;
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
    public partial class calculation : Form
    {
        SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\semester 02\Assignments\C#\final one\DB\cal.mdf;Integrated Security=True;Connect Timeout=30");

        double ot, bonus, netsal, totreduction, totadditiont,oAdd,oRedd,loan,bsal,etep;
        double epf = 0.08, etf = 0.03;

        private void addDB_Click(object sender, EventArgs e)
        {
            con1.Open();
            SqlCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "insert into calc values('" + textBox1.Text + "','" + ot + "','" + bonus + "','" + oAdd + "','" + loan + "','" + oRedd + "','" + totadditiont + "','" + totreduction + "','" + netsal + "','" + bsal + "')";
            cmd1.ExecuteNonQuery();

            con1.Close();

            textBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox2.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox3.Text = "";


            MessageBox.Show("Record added");
        }

        

        private void btnsubmitsal_Click(object sender, EventArgs e)
        {
           double bsal = Convert.ToDouble(textBox3.Text);
            etep = (bsal * (epf + etf));
            netsal=bsal+ totadditiont - (totreduction+etep);
            textBox12.Text = netsal.ToString();

            
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        
        //aditions
        private void btnsubmit2_Click(object sender, EventArgs e)
        {
            loan = Convert.ToDouble(textBox11.Text);
            oRedd = Convert.ToDouble(textBox10.Text);
            totreduction = loan + oRedd ;
            textBox13.Text = totreduction.ToString();
        }
        //reductions
        private void btnsubmit1_Click(object sender, EventArgs e)
        {
            bonus = Convert.ToDouble(textBox5.Text);
            ot = Convert.ToDouble(textBox4.Text);
            oAdd = Convert.ToDouble(textBox6.Text);
            totadditiont = bonus + ot + oAdd;
            textBox2.Text = totadditiont.ToString();
        }
        //back to dash board
        private void button1_Click(object sender, EventArgs e)
        {

            frmMain objFrmMain = new frmMain();
            this.Hide();
            objFrmMain.Show();
        }

        
        public calculation()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
