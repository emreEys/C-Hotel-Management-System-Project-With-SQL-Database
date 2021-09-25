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
    public partial class StdntNewspaper : Form
    {
        public StdntNewspaper()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            StdntPanel sp = new StdntPanel();
            sp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.aksam.com.tr/");
            lblNews.Text = btnAksam.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.haberturk.com/");
            lblNews.Text = btnHbrTurk.Text;
        }

        private void btnSabah_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.sabah.com.tr/");
            lblNews.Text = btnSabah.Text;
        }

        private void btnMilliyet_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.milliyet.com.tr/");
            lblNews.Text = btnMilliyet.Text;
        }

        private void btnYenisafak_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnYenisafak.Text;
            webBrowser1.Navigate("https://www.yenisafak.com/");
        }

        private void btnTakvim_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnTakvim.Text;
            webBrowser1.Navigate("https://www.takvim.com.tr/");
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnStar.Text;
            webBrowser1.Navigate("https://www.star.com.tr/");
        }

        private void btnKarar_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnKarar.Text;
            webBrowser1.Navigate("https://www.karar.com/");
        }

        private void btnPosta_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnPosta.Text;
            webBrowser1.Navigate("https://www.posta.com.tr/");
        }

        private void btnSonDakika_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnSonDakika.Text;
            webBrowser1.Navigate("https://www.sondakika.com/");
        }

        private void btnHurriyet_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnHurriyet.Text;
            webBrowser1.Navigate("https://www.hurriyet.com.tr/");
        }

        private void btnYurt_Click(object sender, EventArgs e)
        {
            lblNews.Text = btnYurt.Text;
            webBrowser1.Navigate("https://www.yurtgazetesi.com.tr/");
        }
    }
}
