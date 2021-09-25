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
    public partial class StdntPanel : Form
    {
        public StdntPanel()
        {
            InitializeComponent();
        }

        public static string username;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGoogle_Click(object sender, EventArgs e)
        {
            StdntGoogle sg = new StdntGoogle();
            sg.Show();
            this.Hide();
        }

        private void BtnComplaint_Click(object sender, EventArgs e)
        {
            StdntCompliant sc = new StdntCompliant();
            sc.Show();
            this.Hide();
        }

        private void BtnNewspaper_Click(object sender, EventArgs e)
        {
            StdntNewspaper sn = new StdntNewspaper();
            sn.Show();
            this.Hide();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            StdntSelf ss = new StdntSelf();
            ss.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Announces a = new Announces();
            a.Show();
            this.Hide();
        }

        private void groupbox_Enter(object sender, EventArgs e)
        {

        }

        private void StdntPanel_Load(object sender, EventArgs e)
        {
            lblUser.Text = StdntLogın.user;
            PictureBox.ImageLocation = StdntLogın.picture;
        }
    }
}
