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
    public partial class Form7 : Form
    {
        List<Panel> listpanel = new List<Panel>();
        int index;

        public Form7()
        {
            InitializeComponent();
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            //Previous Page Button
            if (index > 0) 
            {
                listpanel[--index].BringToFront();
            }
        }
        private void roundButton2_Click(object sender, EventArgs e)
        {
            //Next Page Button
            if (index < listpanel.Count - 1) 
            {
                listpanel[++index].BringToFront();    
            }
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            listpanel.Add(page1);
            listpanel.Add(page2);
            listpanel.Add(page3);
            listpanel.Add(page4);
            listpanel.Add(page5);
            listpanel[index].BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
