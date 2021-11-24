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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == true && pictureBox4.Visible)
            {
                this.Hide();
                Form4 Form4 = new Form4();
                Form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("Account does not exist or you may have incorrect username or password");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            int length = name.Length;

            if (length >= 5 && length <= 10)
            {
                pictureBox5.Visible = true;
                
            }
            else
            {
                
                pictureBox5.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            button4.Visible = false;
            button5.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string name = textBox2.Text;

            int length = name.Length;

            if (length >= 6)
            {
                pictureBox4.Visible = true;
 
            }
            else
            {

                pictureBox4.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
            button5.Visible = false;
            button4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.ShowDialog();
        }


        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == true && pictureBox4.Visible == true)
            {
                this.Hide();
                Form4 form4 = new Form4();
                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("There is something wrong with your user or password");
            }
        }
    }
}
