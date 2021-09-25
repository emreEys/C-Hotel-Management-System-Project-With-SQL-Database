using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Pansiyon_otomasyonu
{
    public partial class ManagerSingUp : Form
    {
        public ManagerSingUp()
        {
            InitializeComponent();
        }

        SqlCon con = new SqlCon();


        void clean()
        {

            CmbGender.Text = "";
            MskPhone.Text = "";
            TxtMail.Text = "";
            TxtName.Text = "";
            TxtPass.Text = "";
            TxtRoom.Text = "";
            TxtSurname.Text = "";
            TxtUserName.Text = "";
            pictureBox1.ImageLocation = "";
        }
        public static string position;



        private void BtnExit_Click(object sender, EventArgs e)
        {

            ManagerPanel mp = new ManagerPanel();
            mp.Show();
            this.Hide();
        }

        private void TxtMailCode_Enter(object sender, EventArgs e)
        {
            if (TxtMailCode.Text == "example@gmail.com")
            {
                TxtMailCode.Text = "";
                TxtMailCode.ForeColor = Color.Black;
            }
        }

        private void TxtMailCode_Leave(object sender, EventArgs e)
        {
            if (TxtMailCode.Text == "")
            {
                TxtMailCode.Text = "example@gmail.com";
                TxtMailCode.ForeColor = Color.Silver;
            }
        }

        Random rnd = new Random();
        public static string code = "1";
        public static string mail;


        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (TxtMailCode.Text == "example@gmail.com")
            {
                MessageBox.Show("Text Can't Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                code = rnd.Next(1000, 9999).ToString();

                ManagerMailcod mc = new ManagerMailcod();
                System.Threading.Thread.Sleep(1000);
                mc.Show();
                this.Hide();

                string from = "yourMail@gmail.com";
                string topic = "Mail Security Code";
                string messageCode = "have a nice day;\n" +
                "your requested security code: " + code +
                "\nPlease do not share your code with anyone!";

                MailMessage sms = new MailMessage(from, TxtMailCode.Text, topic, messageCode);
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(from, "yourMailPassword");
                smtpClient.Send(sms);

                MessageBox.Show("Check your mail", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mail = TxtMailCode.Text;
                con.bgl().Close();
            }

        }

        private void ManagerSingUp_Load(object sender, EventArgs e)
        {
            TxtRoom.Text = Rooms.roomNo;
            checkBox1.Checked = false;
            TxtPosition.Enabled = false;
            TxtPosition.Text = position;
            if (TxtPosition.Text == "Student")
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Stdnt", con.bgl());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.bgl().Close();
            }

            else if (TxtPosition.Text == "Personal")
            {
                TxtRoom.Visible = false;
                label11.Visible = false;
                BtnRooms.Visible = false;
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_Personal", con.bgl());
                da2.Fill(dt2);
                dataGridView1.DataSource = dt2;
                con.bgl().Close();
            }

            dateTimePicker1.Text = DateTime.Now.ToString();
            if (code == ManagerMailcod.sendCode)
            {
                lblMail.Visible = false;
                TxtMailCode.Visible = false;
                BtnSend.Visible = false;
                TxtMail.Text = mail;
                BtnSave.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            lblPictureWay.Text = openFileDialog1.FileName;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (TxtPosition.Text == "Personal")
            {
                SqlCommand cmd1 = new SqlCommand("select PUserName from tbl_Personal", con.bgl());
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    if (dr1[0].ToString() == TxtUserName.Text)
                    {
                        MessageBox.Show("This username is taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUserName.ForeColor = Color.Red;           
                    }
                    else
                    {
                        SqlCommand cmd2 = new SqlCommand("insert into tbl_Personal (PName, PSurname, PGender, PUserName, PPass, PMail, PPhone, PEntry, PImage)"
                            + "values (@p1, @p2, @p3, @p4, @p5, @p6 , @p7, @p8, @p9)", con.bgl());
                        cmd2.Parameters.AddWithValue("@p1", TxtName.Text);
                        cmd2.Parameters.AddWithValue("@p2", TxtSurname.Text);
                        cmd2.Parameters.AddWithValue("@p3", CmbGender.Text);
                        cmd2.Parameters.AddWithValue("@p4", TxtUserName.Text);
                        cmd2.Parameters.AddWithValue("@p5", Sha256.pass256(TxtPass.Text));
                        cmd2.Parameters.AddWithValue("@p6", TxtMail.Text);
                        cmd2.Parameters.AddWithValue("@p7", MskPhone.Text);
                        cmd2.Parameters.AddWithValue("@p8", dateTimePicker1.Value);
                        cmd2.Parameters.AddWithValue("@p9", lblPictureWay.Text);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show(TxtName.Text + " Has Been Registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                        TxtUserName.ForeColor = Color.Black;
                        con.bgl().Close();

                        DataTable dt1 = new DataTable();
                        SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_Personal", con.bgl());
                        da1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                        con.bgl().Close();
                        BtnSave.Visible = false;

                        lblMail.Visible = true;
                        TxtMailCode.Visible = true;
                        BtnSend.Visible = true;
                    }
                }
                con.bgl().Close();
            }

            else if (TxtPosition.Text == "Student")
            {
                
                SqlCommand cmd3 = new SqlCommand("select SUserName from tbl_Stdnt", con.bgl());
                SqlDataReader dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    if (dr3[0].ToString() == TxtUserName.Text)
                    {
                        MessageBox.Show("This username is taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TxtUserName.ForeColor = Color.Red;
                        con.bgl().Close();
                    }
                    else
                    {
                        SqlCommand cmd5 = new SqlCommand("Update tbl_Rooms set REmptyFull=@p2 where RNo=@p1", con.bgl());
                        cmd5.Parameters.AddWithValue("@p1", TxtRoom.Text);
                        cmd5.Parameters.AddWithValue("@p2", 1);
                        cmd5.ExecuteNonQuery();
                        con.bgl().Close();

                        SqlCommand cmd4 = new SqlCommand("insert into tbl_Stdnt (SName, SSurname, SGender, SUserName, SPass, SMail, SPhone, SRoomNo, SEntry, SImage)"
                           + "values (@s1, @s2, @s3, @s4, @s5, @s6 , @s7, @s8, @s9, @s10)", con.bgl());
                        cmd4.Parameters.AddWithValue("@s1", TxtName.Text);
                        cmd4.Parameters.AddWithValue("@s2", TxtSurname.Text);
                        cmd4.Parameters.AddWithValue("@s3", CmbGender.Text);
                        cmd4.Parameters.AddWithValue("@s4", TxtUserName.Text);
                        cmd4.Parameters.AddWithValue("@s5", Sha256.pass256(TxtPass.Text));
                        cmd4.Parameters.AddWithValue("@s6", TxtMail.Text);
                        cmd4.Parameters.AddWithValue("@s7", MskPhone.Text);
                        cmd4.Parameters.AddWithValue("@s8", TxtRoom.Text);
                        cmd4.Parameters.AddWithValue("@s9", dateTimePicker1.Value);
                        cmd4.Parameters.AddWithValue("@s10", lblPictureWay.Text);
                        cmd4.ExecuteNonQuery();
                        MessageBox.Show(TxtName.Text + " Has Been Registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clean();
                        TxtUserName.ForeColor = Color.Black;
                        con.bgl().Close();

                        DataTable dt2 = new DataTable();
                        SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_Stdnt", con.bgl());
                        da2.Fill(dt2);
                        dataGridView1.DataSource = dt2;
                        con.bgl().Close();
                        BtnSave.Visible = false;

                        lblMail.Visible = true;
                        TxtMailCode.Visible = true;
                        BtnSend.Visible = true;
                        con.bgl().Close();
                    }
                }
                
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (TxtUserName.Text == "")
            {
                MessageBox.Show("invalid username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TxtPosition.Text == "Student")
            {
                SqlCommand cmd5 = new SqlCommand("Update tbl_Rooms set REmptyFull=@p2 where RNo=@p1", con.bgl());
                cmd5.Parameters.AddWithValue("@p1", TxtRoom.Text);
                cmd5.Parameters.AddWithValue("@p2", 0);
                cmd5.ExecuteNonQuery();
                con.bgl().Close();

                SqlCommand cmd = new SqlCommand("Delete From tbl_Stdnt where SUserName=@s1", con.bgl());
                cmd.Parameters.AddWithValue("@s1", TxtUserName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show(TxtName.Text + " Has Been Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Stdnt", con.bgl());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.bgl().Close();
            }
            else if (TxtPosition.Text == "Personal")
            {
                SqlCommand cmd1 = new SqlCommand("Delete From tbl_Personal where PUserName=@p1", con.bgl());
                cmd1.Parameters.AddWithValue("@p1", TxtUserName.Text);
                cmd1.ExecuteNonQuery();
                MessageBox.Show(TxtName.Text + " Has Been Deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clean();

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter("Select * from tbl_Personal", con.bgl());
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;
                con.bgl().Close();
            }

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (TxtPosition.Text == "Student")
            {
                if (TxtPass.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Update tbl_Stdnt Set SName = @s1, SSurname=@s2, SMail=@s3, SPhone=@s4, SRoomNo=@s5, SImage=@s6 where SUsername=@s7", con.bgl());
                    cmd.Parameters.AddWithValue("@s1", TxtName.Text);
                    cmd.Parameters.AddWithValue("@s2", TxtSurname.Text);
                    cmd.Parameters.AddWithValue("@s3", TxtMail.Text);
                    cmd.Parameters.AddWithValue("@s4", MskPhone.Text);
                    cmd.Parameters.AddWithValue("@s5", TxtRoom.Text);
                    cmd.Parameters.AddWithValue("@s6", pictureBox1.ImageLocation);
                    cmd.Parameters.AddWithValue("@s7", TxtUserName.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(TxtUserName.Text + " has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("select * from tbl_Stdnt", con.bgl());
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.bgl().Close();
                }
                else
                {
                    MessageBox.Show("Password hasn't to be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else if (TxtPosition.Text == "Personal")
            {
                if (TxtPass.Text != "")
                {
                    SqlCommand cmd = new SqlCommand("Update tbl_Personal Set PName = @p1, PSurname=@p2, PMail=@p3, PPhone=@p4, PImage=@p5 where PUsername=@p6", con.bgl());
                    cmd.Parameters.AddWithValue("@p1", TxtName.Text);
                    cmd.Parameters.AddWithValue("@p2", TxtSurname.Text);
                    cmd.Parameters.AddWithValue("@p3", TxtMail.Text);
                    cmd.Parameters.AddWithValue("@p4", MskPhone.Text);
                    cmd.Parameters.AddWithValue("@p5", pictureBox1.ImageLocation);
                    cmd.Parameters.AddWithValue("@p6", TxtUserName.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show(TxtUserName.Text + " has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();
                    DataTable dt1 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter("select * from tbl_Personal", con.bgl());
                    da1.Fill(dt1);
                    dataGridView1.DataSource = dt1;
                    con.bgl().Close();
                }
                else
                {
                    MessageBox.Show("Password hasn't to be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = dataGridView1.SelectedCells[0].RowIndex;

            TxtName.Text = dataGridView1.Rows[selection].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selection].Cells[2].Value.ToString();
            CmbGender.Text = dataGridView1.Rows[selection].Cells[3].Value.ToString();
            TxtUserName.Text = dataGridView1.Rows[selection].Cells[4].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[selection].Cells[6].Value.ToString();
            MskPhone.Text = dataGridView1.Rows[selection].Cells[7].Value.ToString();
            TxtRoom.Text = dataGridView1.Rows[selection].Cells[8].Value.ToString();
            if (TxtPosition.Text == "Student")
            {
                pictureBox1.ImageLocation = dataGridView1.Rows[selection].Cells[10].Value.ToString();
            }
            else if (TxtPosition.Text == "Personal")
            {
                pictureBox1.ImageLocation = dataGridView1.Rows[selection].Cells[9].Value.ToString();
            }



        }


        private void BtnRooms_Click(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void BtnRooms_Click_1(object sender, EventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();
            this.Hide();
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
