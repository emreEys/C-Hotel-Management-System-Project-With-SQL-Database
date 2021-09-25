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
    public partial class ManagerSelf : Form
    {
        public ManagerSelf()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();

        void clean()
        {
            MskPhone.Text = "";
            TxtMail.Text = "";
            TxtName.Text = "";
            TxtPass.Text = "";
            TxtSurname.Text = "";
            TxtUserName.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void ManagerSelf_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = ManagerLogın.username;
            TxtUserName.Enabled = false;
            SqlCommand cmd = new SqlCommand("select MName, MSurname, MMail, MPhone, MImage from tbl_Manager where MUsername=@p1", con.bgl());
            cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                TxtName.Text = dr[0].ToString();
                TxtSurname.Text = dr[1].ToString();
                TxtMail.Text = dr[2].ToString();
                MskPhone.Text = dr[3].ToString();
                pictureBox1.ImageLocation = dr[4].ToString();
            }
            con.bgl().Close();
            
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ManagerPanel mp = new ManagerPanel();
            mp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean(); 
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtPass.Text != "")
            {
                SqlCommand cmd = new SqlCommand("Update tbl_Manager set MImage=@p1, MName=@p2, MSurname=@p3, MPass=@p4, MMail=@p5, MPhone=@p6 where MUsername=@p7", con.bgl());
                cmd.Parameters.AddWithValue("@p1", pictureBox1.ImageLocation);
                cmd.Parameters.AddWithValue("@p2", TxtName.Text);
                cmd.Parameters.AddWithValue("@p3", TxtSurname.Text);
                cmd.Parameters.AddWithValue("@p4", Sha256.pass256(TxtPass.Text));
                cmd.Parameters.AddWithValue("@p5", TxtMail.Text);
                cmd.Parameters.AddWithValue("@p6", MskPhone.Text);
                cmd.Parameters.AddWithValue("@p7", TxtUserName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(TxtName.Text + " Has Been Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.bgl().Close();
            }
            else
            {
                MessageBox.Show("Password hasn't to empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            lblPictureWay.Text = openFileDialog1.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtPass.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPass.UseSystemPasswordChar = true;
            }
        }
    }
}
