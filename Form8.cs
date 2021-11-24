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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            MapsBrowser.Navigate("https://www.google.com/maps/d/u/0/edit?mid=1ttKk0UOl0iLCzmorOo_ELVkAyEKMGw-v&usp=sharing");
        }

        private void MapsBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Empty Event Handler
        }
    }
}
