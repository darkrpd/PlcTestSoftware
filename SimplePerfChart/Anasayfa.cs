using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimplePerfChart
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
           
            
        }

        private void btn_Aging_Click(object sender, EventArgs e)
        {
            Aging aging = new Aging();
            this.Hide();
            aging.Show();
        }

        private void btn_Vibration_Click(object sender, EventArgs e)
        {
            Vibration vibration = new Vibration();
            this.Hide();
            vibration.Show();
            //this.BringToFront();
        }

        private void btn_Temperature_Click(object sender, EventArgs e)
        {
            Temperature temperature = new Temperature();
            this.Hide();
            temperature.Show();
        }

        private void btn_Leak_Click(object sender, EventArgs e)
        {
            Leak leak = new Leak();
            this.Hide();
            leak.Show();
        }

        private void btn_Impulse_Click(object sender, EventArgs e)
        {
            Impulse impulse = new Impulse();
            this.Hide();
            impulse.Show();
        }

        private void Anasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      
    }
}
