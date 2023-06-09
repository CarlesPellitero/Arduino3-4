﻿using System;
using System.Windows.Forms;

namespace Sprint6_Pellitero_Carles
{
    public partial class Reject : Form
    {
        public Reject()
        {
            InitializeComponent();
        }

        int temps = 0;
        private void Delay_Tick(object sender, EventArgs e)
        {
            if(temps == 3)
            {
                Delay.Stop();
                Application.Exit();
            }
            else
            {
                temps++;
            }
        }

        private void Reject_Load(object sender, EventArgs e)
        {
            Delay.Start();
        }

        private void Reject_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
