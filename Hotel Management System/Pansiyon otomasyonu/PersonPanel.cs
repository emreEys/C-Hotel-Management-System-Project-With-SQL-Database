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
    public partial class PersonPanel : Form
    {
        public PersonPanel()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnNotices_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonalSelf ps = new PersonalSelf();
            ps.Show();
            this.Hide();
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            PersonalReport pr = new PersonalReport();
            pr.Show();
            this.Hide();
        }

        private void PersonPanel_Load(object sender, EventArgs e)
        {
            lblUser.Text = PersonLogın.user;
            PictureBox.ImageLocation = PersonLogın.picture;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Announces a = new Announces();
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
