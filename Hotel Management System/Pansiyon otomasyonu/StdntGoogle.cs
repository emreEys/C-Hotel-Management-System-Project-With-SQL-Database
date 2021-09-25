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
    public partial class StdntGoogle : Form
    {
        public StdntGoogle()
        {
            InitializeComponent();
        }

        private void StdntGoogle_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com.tr/");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            StdntPanel sp = new StdntPanel();
            sp.Show();
            this.Hide();
        }
    }
}
