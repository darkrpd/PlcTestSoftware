using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePerfChart
{
    public partial class Vibration : Form
    {
        public Vibration()
        {
            InitializeComponent();
        }

        private void Vibration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
        }
    }
}
