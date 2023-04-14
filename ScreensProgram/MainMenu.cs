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
        byte[] data;

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
            data = GenerateToken.GeneratedToken(data);
        }


        private void Delay_Tick(object sender, EventArgs e)
        {
            //Con un timer ir validando
            DateTime when = DateTime.FromBinary(BitConverter.ToInt64(data, 0));

            if (when < DateTime.UtcNow.AddMinutes(-5))
            {
                Delay.Stop();
                valido = false;
            }
            else
            {
                valido = true;
                Reject reject = new Reject();
                this.Hide();
                reject.ShowDialog();
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
