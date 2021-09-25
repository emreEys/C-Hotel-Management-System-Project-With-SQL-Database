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
    public partial class Rooms : Form
    {
        public Rooms()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();
        public static string roomNo;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            
            ManagerSingUp msu = new ManagerSingUp();
            msu.Show();
            this.Hide();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            
            ManagerSingUp msu = new ManagerSingUp();
            msu.Show();
            this.Hide();
            
        }
        int counter = 1;
        private void Rooms_Load(object sender, EventArgs e)
        {
           

            for (int j = 1; j <= 8; j++)
            {
                for (int i = 1; i <= 6; i++)
                {

                    Button btn = new Button();
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.Text = counter.ToString();
                    btn.Name = counter.ToString();
                    btn.Size = new Size(75, 30);
                    btn.Location = new Point(114 * j, 95 * i);
                    Controls.Add(btn);
                    SqlCommand cmd = new SqlCommand("Select Rno, REmptyFull from tbl_Rooms", con.bgl());
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[0].ToString() == btn.Text && dr[1].ToString() == "True")
                        {
                            btn.BackColor = Color.Red;
                            btn.Enabled = false;
                        }
                        else
                        {
                            if (btn.BackColor != Color.Red)
                            {
                                btn.BackColor = Color.Green;
                            }
                        }
                        
                    }
                    con.bgl().Close();
                    counter++;

                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click (object sender, EventArgs e)
        {
            Button room = (Button)sender;
            if (room.BackColor != Color.Red)
            {
                roomNo = room.Text;
            }
        }
            
       
    }
}
