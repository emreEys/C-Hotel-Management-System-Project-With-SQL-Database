using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace Pansiyon_otomasyonu
{
    public partial class PersonalForgotPassword : Form
    {
        public PersonalForgotPassword()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
        Random rnd = new Random();
        public static string code = "1";
        public static string username;

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (TxtMail.Text == "" && TxtUserName.Text == "")
            {
                MessageBox.Show("Texts Can't Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * from tbl_Personal where PUsername=@p1 and PMail=@p2", con.bgl());
                cmd.Parameters.AddWithValue("@p1", TxtUserName.Text);
                cmd.Parameters.AddWithValue("@p2", TxtMail.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    code = rnd.Next(1000, 9999).ToString();

                    StdntPasswordCode pc = new StdntPasswordCode();
                    System.Threading.Thread.Sleep(1000);
                    pc.Show();
                    this.Hide();

                    string from = "yourMail@gmail.com";
                    string topic = "Password reset request";
                    string messageCode = "have a nice day;\n" +
                    "your requested security code: " + code +
                    "\nPlease do not share your code with anyone!";

                    MailMessage sms = new MailMessage(from, TxtMail.Text, topic, messageCode);
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(from, "yourMailPassword");
                    smtpClient.Send(sms);

                    MessageBox.Show("Check your mail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.bgl().Close();
                }

                else
                {
                    MessageBox.Show("e-Mail or Username is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.bgl().Close();

                username = TxtUserName.Text;



            }
        }
    }
}
