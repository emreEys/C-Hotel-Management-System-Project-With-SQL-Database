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
    public partial class Announces : Form
    {
        public Announces()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Announces_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Notice, NoticeDate from tbl_Notice", con.bgl());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }
    }
}
