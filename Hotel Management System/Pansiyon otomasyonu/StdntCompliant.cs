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
    public partial class StdntCompliant : Form
    {
        public StdntCompliant()
        {
            InitializeComponent();
        }
        SqlCon con = new SqlCon();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            StdntPanel sp = new StdntPanel();
            sp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RchComplaint.Text == "")
            {
                MessageBox.Show("Complaint cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_Complaints (Complaint, ComplaintDate) values (@p1, @p2)", con.bgl());
                cmd.Parameters.AddWithValue("@p1", RchComplaint.Text);
                cmd.Parameters.AddWithValue("@p2", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Complaint has made!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RchComplaint.Text = "";

                con.bgl().Close();
            }
        }
    }
}
