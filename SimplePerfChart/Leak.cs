using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePerfChart
{
    public partial class Leak : Form
    {
        public Leak()
        {
            InitializeComponent();
        }

        private void Leak_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }
    }
}
