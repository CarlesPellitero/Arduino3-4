using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprint6_Pellitero_Carles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SerialPort portArduino;
        bool obert = false, selecionat = false;
        Thread thread;
        int backcount = 30;
        RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        string xifres;

        public class password
        {
            public string lletra { get; set; }
            public string valors { get; set; }
        }

        List<password> Password = new List<password>();


        private int RandomGenerator()
        {
            var byteArray = new byte[4];
            rngCsp.GetBytes(byteArray);
            int randomInteger = BitConverter.ToInt32(byteArray, 0);
            return randomInteger;

        }

        private void GeneradorA1D5()
        {
            Queue<int> digits = new Queue<int>();
            ArrayList lletras = new ArrayList() { "A", "E", "I", "O", "U" };
            ArrayList array; 
            int digit, digitArray;
            
            for (int i = 0; i < 5; i++)
            {
                array = new ArrayList() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int randomInteger = RandomGenerator();

                for (int j = 0; j < 6; j++)
                {
                    Random random = new Random(randomInteger);
                    digit = random.Next(array.Count);
                    digitArray = (int)array[digit];
                    digits.Enqueue(digitArray);
                    array.Remove(digitArray);
                }

                while (digits.Count > 0)
                {
                    xifres += digits.Dequeue().ToString();
                }

                password codi = new password();

                codi.lletra = lletras[i].ToString();
                codi.valors = xifres;
                Password.Add(codi); 

                xifres = "";
            }
            rngCsp.Dispose();
        }

        private void SeleccionarPort()
        {
            //Obrirà el port seleccionat i per verificar que la comunicació ha estat reeixida, 
            string port;
            try
            {
                port = cbPorts.Text;
                portArduino = new SerialPort();
                portArduino.BaudRate = 9600;
                portArduino.PortName = port;
                portArduino.Open();
            }
            catch (ArgumentException)
            { }

        }

        private void turnback_Tick(object sender, EventArgs e)
        {
            backcount--;
            lbtemps.Text = "Temps en milisegons: " + (backcount * 1000).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                cbPorts.Items.Add(port);
            }
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionat = true;
        }

        private void btnContaEnrera_Click(object sender, EventArgs e)
        {
            //Generar numeors aleatoris A1 - D5
            GeneradorA1D5();
            System.Timers.Timer timer = new System.Timers.Timer();            
            timer.Interval = 1000;
            //timer.Elapsed();
            timer.Start();
            lbtemps.Text = timer.ToString();

            int digit, randomInteger;
            randomInteger = RandomGenerator();
            Random random = new Random(randomInteger);
            digit = random.Next(Password.Count);
            string passw = Password[digit].valors;
            lbCodiValid.Text = passw;


        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!obert && selecionat)
            {
                SeleccionarPort();
                if (portArduino != null)
                {
                    btnComprovar.Text = "Desconnectar";
                    obert = true;
                    portArduino.Write("ACK\n");
                    string valor = portArduino.ReadLine();
                    if (valor == "ACK\r")
                    {
                        lbtemps.Visible = true;
                        btnContaEnrera.Visible = true;
                    }
                }
            }
            else
            {
                if (portArduino != null)
                {
                    portArduino.Close();
                    btnComprovar.Text = "Connectar"; 
                    obert = false;
                    lbtemps.Visible = false;
                    btnContaEnrera.Visible = false;
                    //thread.Abort();
                }

            }
        }
    }
}
