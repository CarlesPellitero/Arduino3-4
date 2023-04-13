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
        QRGenerator op;

        private void ObrirQrGenerator()
        {
            if (op != null)
            {
                op.Close();
            }

            if (valido)
            {
                op = new QRGenerator();
                op.TopLevel = false;
                screen.Controls.Add(op);
                op.Dock = DockStyle.Fill;
                op.Show();
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            //CLASE TOKEN
            Delay.Start();
            GenerateToken.GeneratedToken();



        }


        private void Delay_Tick(object sender, EventArgs e)
        {
            //Con un timer ir validando
            int cont = 0;  // CONT EL mAXIMO ES 180 porque cada segundo es 1 cont
            if (cont == 180)
            {
                Delay.Stop();
                valido = false;
            }
            else
            {
                cont++;
            }

        }

        private void btnOpcion1_Click(object sender, EventArgs e)
        {
            ObrirQrGenerator();
        }

        private void txtinfo_Click(object sender, EventArgs e)
        {
            ObrirQrGenerator();
        }

        private void txtTraduct_Click(object sender, EventArgs e)
        {
            ObrirQrGenerator();
        }

        private void title_Click(object sender, EventArgs e)
        {
            ObrirQrGenerator();
        }

        private void btnOpcion1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
