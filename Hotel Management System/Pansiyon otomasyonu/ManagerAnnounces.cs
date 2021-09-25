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
    public partial class ManagerAnnounces : Form
    {
        public ManagerAnnounces()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();
        private void button1_Click(object sender, EventArgs e)
        {
            if(RchNotice.Text == "")
            {
                MessageBox.Show("Announcement cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("insert into tbl_Notice (Notice, NoticeDate) values (@p1, @p2)", con.bgl());
                cmd.Parameters.AddWithValue("@p1", RchNotice.Text);
                cmd.Parameters.AddWithValue("@p2", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Announcement has made!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Notice, NoticeDate from tbl_Notice", con.bgl());
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                RchNotice.Text = "";

                con.bgl().Close();
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ManagerPanel mp = new ManagerPanel();
            mp.Show();
            this.Hide();
        }

        private void ManagerAnnounces_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Notice, NoticeDate from tbl_Notice", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.bgl().Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(RchNotice.Text == "")
            {
                MessageBox.Show("Contents Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Delete from tbl_Notice where Notice=@p1", con.bgl());
                cmd.Parameters.AddWithValue("@p1", RchNotice.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Notice was deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RchNotice.Text = "";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select Notice, NoticeDate from tbl_Notice", con.bgl());
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                RchNotice.Text = "";

                con.bgl().Close();

            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = dataGridView1.SelectedCells[0].RowIndex;
            RchNotice.Text = dataGridView1.Rows[selection].Cells[0].Value.ToString();
        }
    }
}
