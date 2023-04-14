using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
