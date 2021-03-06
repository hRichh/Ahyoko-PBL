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

namespace AhyokoPBLReTech
{
    public partial class Form5 : Form
    {
        public string attachmentPath = "";
        public Form5()
        {
            InitializeComponent();

        }
        public void EmailforReportFunction(string emailIDForReport)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel8.BringToFront();
            panel7.SendToBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select File";
            ofd.Filter = "Image File (*.png;*.jpg;*.bmp;*.gif) | *.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
            ofd.ShowDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                attachmentPath = ofd.FileName.ToString();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            { 
                try
                {
                    MailMessage msg = new MailMessage();
                    if (attachmentPath != string.Empty) 
                    {
                        msg.Attachments.Add(new Attachment(attachmentPath));
                    }
                    msg.From = new MailAddress("ahyoko.29@gmail.com");
                    msg.To.Add("ahyoko.29@gmail.com");
                    if (Form2.emailIDForReport != string.Empty) 
                    {
                        msg.Subject = "Student Harrassment Report " + "Person Reported: " + textBox2.Text + " Reported by: " + Form2.emailIDForReport;
                    }
                    if (Form3.userNameForReport != string.Empty)
                    {
                        msg.Subject = "Student Harrassment Report " + "Person Reported: " + textBox2.Text + " Reported by: "/* + SQLuserNameString*/;
                    }
                    msg.Body = textBox1.Text;

                    SmtpClient smt = new SmtpClient();
                    smt.Host = "smtp.gmail.com";
                    System.Net.NetworkCredential ntcd = new NetworkCredential();
                    ntcd.UserName = "ahyoko.29@gmail.com";
                    ntcd.Password = "Pbl2021.";
                    smt.Credentials = ntcd;
                    smt.EnableSsl = true;
                    smt.Port = 587;
                    smt.Send(msg);

                    MessageBox.Show("Your Report has been sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                panel8.SendToBack();
                panel7.BringToFront();
                textBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel8.SendToBack();
            panel7.BringToFront();
        }
    }
}
