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
    public partial class ManagerTotalGrafic : Form
    {
        public ManagerTotalGrafic()
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

        private void ManagerTotalGrafic_Load(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("Select SGender, Count(*) from tbl_Stdnt Group by SGender", con.bgl());
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ChrtGender.Series["Male-Female"].Points.AddXY(dr[0], dr[1]);
            }
            con.bgl().Close();

            SqlCommand cmd1 = new SqlCommand("Select REmptyFull, Count(*) from tbl_Rooms Group by REmptyFull", con.bgl());
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {

                ChrtEmpty.Series["Empty Room - Full Room"].Points.AddXY(dr[0], dr[1]);

            }
            con.bgl().Close();
        }


        }
}
