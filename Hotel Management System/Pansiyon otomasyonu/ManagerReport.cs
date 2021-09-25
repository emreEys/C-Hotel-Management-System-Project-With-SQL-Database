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

namespace Pansiyon_otomasyonu
{
    public partial class ManagerReport : Form
    {
        public ManagerReport()
        {
            InitializeComponent();
        }
        SqlCon con = new SqlCon();
        private void BtnExit_Click(object sender, EventArgs e)
        {
            ManagerPanel mp = new ManagerPanel();

            mp.Show();
            this.Hide();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("select Complaint, ComplaintDate from tbl_Complaints", con.bgl());
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("Select Complaint, ComplaintDate from tbl_Complaints", con.bgl());
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.bgl().Close();
            }
            SqlCommand cmd3 = new SqlCommand("select Report, ReportDate from tbl_Reports", con.bgl());
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter("Select Report,  ReportDate from tbl_Reports", con.bgl());
                da3.Fill(dt3);
                dataGridView2.DataSource = dt3;
                con.bgl().Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From tbl_Reports", con.bgl());
            cmd.ExecuteNonQuery();
            con.bgl().Close();
            

            SqlCommand cmd1 = new SqlCommand("Delete From tbl_Complaints", con.bgl());
            cmd1.ExecuteNonQuery();
            con.bgl().Close();
            

            MessageBox.Show("Reports and Complaints Have Been Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
