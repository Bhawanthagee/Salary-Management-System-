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
    public partial class AddEmp : Form

    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\semester 02\Assignments\C#\final one\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbackToDash_Click(object sender, EventArgs e)
        {
            frmMain objFrmMain = new frmMain();
            this.Hide();
            objFrmMain.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtfname.Text = "";
            txtlname.Text = "";
            txttel.Text = "";
            txtaddress.Text = "";
            txtdesignation.Text = "";
            txtbsal.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into newEmp values('" + IDno.Text + "','" + txtfname.Text + "','" + txtlname.Text + "','" + txttel.Text + "','" + txtaddress.Text + "','" + txtdesignation.Text + "','" + txtbsal.Text + "')";
            cmd.ExecuteNonQuery();

            
            con.Close();

            txtfname.Text = "";
            txtlname.Text = "";
            txttel.Text = "";
            txtaddress.Text = "";
            txtdesignation.Text = "";
            txtbsal.Text = "";
            IDno.Text = ""; 


            dips_data();
            MessageBox.Show("Record added");

        }
        public void dips_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from newEmp";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddEmp_Load(object sender, EventArgs e)
        {
            dips_data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from newEmp where ID ='" + txtDelete.Text + "'";
            cmd.ExecuteNonQuery();


            con.Close();
            dips_data();
            MessageBox.Show("Record Deleted");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from newEmp where ID ='" + IDno.Text + "'";
            cmd.ExecuteNonQuery();


            con.Close();
            IDno.Text = "";
            dips_data();
            MessageBox.Show("Record Deleted");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from newEmp where Id='"+ txtSearch .Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            txtSearch.Text = "";
            con.Close();
            
        }

        private void IDno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
