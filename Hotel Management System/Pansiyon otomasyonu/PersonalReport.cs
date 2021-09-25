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
    public partial class PersonalReport : Form
    {
        public PersonalReport()
        {
            InitializeComponent();
        }
        SqlCon con = new SqlCon();

        private void button1_Click(object sender, EventArgs e)
        {
            if (RchReports.Text == "")
            {
                MessageBox.Show("Reports cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_Report (Report, ReportDate) values (@p1, @p2)", con.bgl());
                cmd.Parameters.AddWithValue("@p1", RchReports.Text);
                cmd.Parameters.AddWithValue("@p2", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Report has made!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RchReports.Text = "";

                con.bgl().Close();
            }
        }

        private void PersonalReport_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Report, ReportDate from tbl_Reports", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();
        }
    }
}
