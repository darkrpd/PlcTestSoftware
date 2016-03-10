using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePerfChart
{
    public partial class Aging : Form
    {
        public Aging()
        {
            InitializeComponent();
        }

        private void Aging_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }

        private void perfChart1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
