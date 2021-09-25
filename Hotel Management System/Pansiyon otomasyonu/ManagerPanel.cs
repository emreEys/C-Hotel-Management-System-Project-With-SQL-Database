using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pansiyon_otomasyonu
{
    public partial class ManagerPanel : Form
    {
        public ManagerPanel()
        {
            InitializeComponent();
        }

        
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGoogle_Click(object sender, EventArgs e)
        {
            ManagerSingUp msu = new ManagerSingUp();
            ManagerSingUp.position = "Student";
            msu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ManagerSingUp msu = new ManagerSingUp();
            ManagerSingUp.position = "Personal";
            msu.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerAnnounces ma = new ManagerAnnounces();
            ma.Show();
            this.Hide();
        }

        private void ManagerPanel_Load(object sender, EventArgs e)
        {
            lblUser.Text =  ManagerLogın.user;
            PictureBox.ImageLocation = ManagerLogın.picture;
        }

        private void BtnFilms_Click(object sender, EventArgs e)
        {
            ManagerTotalGrafic mtg = new ManagerTotalGrafic();
            mtg.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ManagerSelf ms = new ManagerSelf();
            ms.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerReport r = new ManagerReport();
            r.Show();
            this.Hide();
        }
    }
}
