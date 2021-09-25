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
    public partial class ManagerMailcod : Form
    {
        public ManagerMailcod()
        {
            InitializeComponent();
        
        }

        public static string sendCode;
        

        private void Mailcod_Load(object sender, EventArgs e)
        {
            lblMail.Visible = false;
            lblMail.Text = ManagerSingUp.code.ToString();
            sendCode = lblMail.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text != "")
            {
                ManagerSingUp msu = new ManagerSingUp();
                if (TxtCode.Text == lblMail.Text)
                {
                    MessageBox.Show("Email verification was confirmed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    msu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The code is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Text is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            ManagerSingUp msu = new ManagerSingUp();
            msu.Show();
            this.Hide();
        }
    }
}
