using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string DBCodeChain;
        FilterInfoCollection filter;
        VideoCaptureDevice VideoCaptureDevice;
        DarkCoreEntitiesMoha db;


        private void PortarDades()
        {
            
            List<string> codeUser = new List<string>();
            List<string> DescUser = new List<string>();

            string userLogin = txtUser.Text;
            var UserDB = db.Users.FirstOrDefault(p => p.codeUser == userLogin);
            if (UserDB != null)
            {
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

            } 
            else
            {
                MessageBox.Show("Codigo QR no valido!");
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            PortarDades();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new DarkCoreEntitiesMoha();
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
            if (VideoCaptureDevice.IsRunning)
            {
                VideoCaptureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cam.Image!=null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)cam.Image);
                if (result!=null)
                {
                    txtQRInfo.Text = result.ToString();
                    timer1.Stop();
                    if (VideoCaptureDevice.IsRunning)
                    {
                        VideoCaptureDevice.Stop();
                    }
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            PortarDades2();

        }

        //DataSet dts = sql.PortarPerConsulta("select * from Users where Login = '" + txtUsername.Text + "' and Password = '" + txtBoxPasswrd.Text + "'");
    }
}
