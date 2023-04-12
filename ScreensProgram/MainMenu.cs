using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sprint6_Pellitero_Carles;

namespace ScreensProgram
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        bool valido = true;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            GenerateToken gt = new GenerateToken();
            
            

        }

        private void btnOption1_Click(object sender, EventArgs e)
        {
            if (valido)
            {
                QRGenerator op = new QRGenerator();
                op.TopLevel = false;
                panel1.Controls.Add(op);
                op.Dock = DockStyle.Fill;
                op.Show();
            }            
        }

        private void Delay_Tick(object sender, EventArgs e)
        {
            //Con un timer ir validando

        }
    }
}
