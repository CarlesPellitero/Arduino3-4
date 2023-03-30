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

        private SqlConnection conn;
        private string query;
        private string query2;
        DataSet dts;
        FilterInfoCollection filter;
        VideoCaptureDevice VideoCaptureDevice;
        Timer DelayTime;
        int delay;


        private void PortarDades()
        {
            configurarCion();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from Users where codeUser = '" + txtUser.Text+"';";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts);         
            conn.Close();

            if (dts.Tables[0].Rows.Count > 0)
            {
                txtDesc.Text = dts.Tables[0].Rows[0]["descUser"].ToString();
            }

        }
        private void PortarDades2()
        {
            configurarCion();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query2 = "select * from CodeChain where CodeChain = '" + txtQRInfo.Text + "';";
            adapter = new SqlDataAdapter(query2, conn);
            conn.Open();
            adapter.Fill(dts);
            conn.Close();

            if (dts.Tables[0].Rows.Count > 0)
            {
                panel.Visible = false;
                InsertForm.Visible = true;

                //SALE LA PANTALLA DE CONTRASEÑAS
            }
            else
            {
                MessageBox.Show("Datos incorrectos");

            }

        }



        private void configurarCion()
        {
            //Carles:
            string cnx = "Data Source=DESKTOP-K19N91Q;Initial Catalog=PrimeraBaseDeDades;Integrated Security=True";

            //Isaac:
            //

            conn = new SqlConnection(cnx);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            PortarDades();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filter= new FilterInfoCollection(FilterCategory.VideoInputDevice);
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
                //adminCoord.BringToFront();
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

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            PortarDades2();

        }

        //DataSet dts = sql.PortarPerConsulta("select * from Users where Login = '" + txtUsername.Text + "' and Password = '" + txtBoxPasswrd.Text + "'");
    }
}
