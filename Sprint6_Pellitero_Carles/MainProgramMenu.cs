using System;
using System.Windows.Forms;
using ScreensProgram;

namespace Sprint6_Pellitero_Carles
{
    public partial class MainProgramMenu : Form
    {
        public MainProgramMenu()
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
            else
            {
                Reject reject = new Reject();
                this.Hide();
                reject.ShowDialog();
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

            if (when < DateTime.UtcNow.AddMinutes(-1)) //5
            {
                Delay.Stop();
                valido = false;
            }
            else
            {
                valido = true;                
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
    }
}
