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

namespace CodeCard
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


        private void PortarDades()
        {
            configurarCion();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query = "select * from Users where codeUser = '" + textBox1.Text+"';";
            adapter = new SqlDataAdapter(query, conn);
            conn.Open();
            adapter.Fill(dts);         
            conn.Close();

            if (dts.Tables[0].Rows.Count > 0)
            {
                textBox4.Text = dts.Tables[0].Rows[0]["descUser"].ToString();
            }

        }
        private void PortarDades2()
        {
            configurarCion();
            SqlDataAdapter adapter;
            dts = new DataSet();

            query2 = "select * from CodeChain where CodeChain = '" + textBox2.Text + "';";
            adapter = new SqlDataAdapter(query2, conn);
            conn.Open();
            adapter.Fill(dts);
            conn.Close();

            if (dts.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Datos correctos");
                pictureBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                panel1.Visible = true;

                //SALE LA PANTALLA DE CONTRASEÑAS
            }
            else
            {
                MessageBox.Show("Datos incorrectos");

            }

        }



        private void configurarCion()
        {
            string cnx;
            cnx = "Data Source=MOHAMED;Initial Catalog=DarkCore;Integrated Security=True";
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
                comboBox1.Items.Add(filterInfo.Name);
                comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoCaptureDevice = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            VideoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            VideoCaptureDevice.Start();
            timer1.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image=(Bitmap)eventArgs.Frame.Clone();  
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
            if (pictureBox1.Image!=null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)pictureBox1.Image);
                if (result!=null)
                {
                    textBox2.Text = result.ToString();
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
