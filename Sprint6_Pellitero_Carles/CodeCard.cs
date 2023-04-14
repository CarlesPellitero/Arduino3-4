using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Sprint6_Pellitero_Carles
{
    public partial class CodeCard : Form
    {

        public CodeCard()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice VideoCaptureDevice;
        PrimeraBaseDeDadesEntities db;
        Timer DelayTime;
        bool qrVal;
        int delay;

        private void PortarDades()
        {
            List<string> codeUser = new List<string>();
            List<string> DescUser = new List<string>();

            string userLogin = txtUser.Text;
            var UserDB = db.Users.FirstOrDefault(p => p.codeUser == userLogin);

            if (UserDB != null)
            {
                btnStart.Visible = true;
                panel.Visible = true;
                txtDesc.Text = UserDB.descUser;

            }
            else
            {
                MessageBox.Show("Usuario invalido!");
                txtUser.Clear();
                txtUser.Focus();
            }

        }
        private void PortarDades2()
        {
            List<string> CodeChain = new List<string>();

            var CodeChainDB = db.CodeChains.FirstOrDefault(p => p.CodeChain1 == txtQRInfo.Text);
            if (CodeChainDB != null)
            {
                txtBBDD.Text = CodeChainDB.CodeChain1;
                qrVal = true;
            }
            else
            {
                MessageBox.Show("Codigo QR no valido!");
                qrVal = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new PrimeraBaseDeDadesEntities();
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filter)
            {
                cbCamara.Items.Add(filterInfo.Name);
                cbCamara.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filter[cbCamara.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
            timer1.Start();
            cam.Visible = true;
            panel.Visible = true;
            txtDesc.Visible = true;
            txtQRInfo.Visible = true;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cam.Image=(Bitmap)eventArgs.Frame.Clone();  
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (VideoCaptureDevice != null)
            {
                if (VideoCaptureDevice.IsRunning)
                {
                    VideoCaptureDevice.Stop();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cam.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)cam.Image); //MEJORAR
                if (result != null && qrVal == true)
                {                    
                    txtQRInfo.Text = result.ToString();
                    timer1.Stop();

                    if (VideoCaptureDevice.IsRunning)
                    {
                        VideoCaptureDevice.Stop();
                    }

                    Delay();
                }
            }
        }

        private void Delay()
        {
            DelayTime = new Timer();
            DelayTime.Interval = 1000;
            DelayTime.Tick += new EventHandler(PingtoPlanet);
            DelayTime.Start();
        }

        private void PingtoPlanet(object sender, EventArgs e)
        {

            if (delay == 3)
            {
                AdminCoord adminCoord = new AdminCoord();
                adminCoord.TopLevel = false;
                InsertForm.Controls.Add(adminCoord);
                adminCoord.Dock = DockStyle.Fill;
                adminCoord.Show();
                panel.Visible = false;
                InsertForm.Visible = true;
                delay++;

            }
            else
            {
                delay++;
                if (delay > 3)
                {
                    DelayTime.Stop();
                }
            }
        }

        private void txtQRInfo_TextChanged(object sender, EventArgs e)
        {
            PortarDades2();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PortarDades();
            }
        }
    }
}