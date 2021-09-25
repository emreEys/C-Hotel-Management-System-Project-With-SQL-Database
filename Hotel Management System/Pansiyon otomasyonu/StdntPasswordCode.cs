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
    public partial class StdntPasswordCode : Form
    {
        public StdntPasswordCode()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();
        public static string sendCode;

        private void PasswordCode_Load(object sender, EventArgs e)
        {
            lblCode.Visible = false;
            lblCode.Text = StdntForgotPassword.code.ToString();
            sendCode = lblCode.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                if (TxtCode.Text == lblCode.Text)
                {
                    MessageBox.Show("Email verification was confirmed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label1.Visible = true;
                    label2.Visible = true;
                    TxtPasswprd1.Visible = true;
                    TxtPassword2.Visible = true;
                    BtnOkey.Visible = true;
                    checkBox1.Visible = true;
                    lblCheckCode.Visible = false;
                    TxtCode.Visible = false;
                    BtnCheck.Visible = false;           
                }
                else
                {
                    MessageBox.Show("Code is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void BtnOkey_Click(object sender, EventArgs e)
        {
            if (TxtPasswprd1.Text != "" && TxtPassword2.Text != "")
            {
                if (TxtPasswprd1.Text == TxtPassword2.Text)
                {
                    SqlCommand cmd = new SqlCommand("Update tbl_Stdnt set SPass=@p1 where SUsername=@p2", con.bgl());
                    cmd.Parameters.AddWithValue("@p2", StdntForgotPassword.username);
                    cmd.Parameters.AddWithValue("@p1", Sha256.pass256(TxtPasswprd1.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password Has Been Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mf = new MainForm();
                    mf.Show();
                    this.Hide();
                    con.bgl().Close();
                }
                else
                {
                    MessageBox.Show("Passwords are not the same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Texts cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtPasswprd1.UseSystemPasswordChar = false;
                TxtPassword2.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPasswprd1.UseSystemPasswordChar = true;
                TxtPassword2.UseSystemPasswordChar = true;
            }
        }
    }
    
}
