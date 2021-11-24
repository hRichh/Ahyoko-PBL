using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhyokoPBLReTech
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true && pictureBox4.Visible == true && pictureBox5.Visible == true && pictureBox6.Visible == true)
            {
                this.Hide();
                Form4 Form4 = new Form4();
                Form4.ShowDialog();
            }
            else 
            {
                MessageBox.Show ("There are some information that does not meet with the requiments");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Form3 = new Form3();
            Form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            button5.Visible = false;
            button3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            button6.Visible = false;
            button4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '\0';
            button5.Visible = true;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '\0';
            button6.Visible = true;
            button4.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            int length = name.Length;

            if (length >= 5 && length <= 10)
            {
                pictureBox3.Visible = true;
                pictureBox7.Visible = false;
            }
            else
            {
                pictureBox7.Visible = true;
                pictureBox3.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!this.textBox2.Text.Contains('@') || !this.textBox2.Text.Contains('.') || !this.textBox2.Text.Contains("iacademy.edu.ph"))
            {
                pictureBox8.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox4.Visible = true;
                pictureBox8.Visible = false;
                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string name = textBox3.Text;

            int length = name.Length;

            if (length >= 6)
            {
                pictureBox5.Visible = true;
                pictureBox9.Visible = false;
            }
            else
            {
                pictureBox9.Visible = true;
                pictureBox5.Visible = false;
            }
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string name = textBox4.Text;
                int length = name.Length;

                if (!this.textBox4.Text.Equals(textBox3.Text))
                {
                    pictureBox10.Visible = true;
                    pictureBox6.Visible = false;
                }
                else
                {
                    pictureBox6.Visible = true;
                    pictureBox10.Visible = false;
                }
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true && pictureBox4.Visible == true && pictureBox5.Visible == true && pictureBox6.Visible == true)
            {
                this.Hide();
                Form4 Form4 = new Form4();
                Form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are some information that does not meet with the requiments");
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (pictureBox3.Visible == true && pictureBox4.Visible == true && pictureBox5.Visible == true && pictureBox6.Visible == true)
            {
                this.Hide();
                Form4 Form4 = new Form4();
                Form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are some information that does not meet with the requiments");
            }
        }
    }
   
}
