using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Sprint6_Pellitero_Carles
{
    public partial class Keypad : Form
    {
        public Keypad()
        {
            InitializeComponent();
        }

        #region Local Variables
        SerialPort portArduino;
        bool obert = false, selecionat = false,correcta;
        Thread thread;
        private int backcount = 30;
        RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        List<password> Password = new List<password>();
        string xifres;
        Timer timer;
        CodeCard qr;
        int delay = 0;

        public class password
        {
            public string lletra { get; set; }
            public string valors { get; set; }
        }
        #endregion

        #region Functions
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

        private void PingtoPlanet(object sender, EventArgs e)
        {
            if (delay == 3)
            {
                this.Hide();
                QRGenerator qRGenerator = new QRGenerator();
                delay++;
                qRGenerator.ShowDialog();

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

        private void Delay()
        {
            DelayTime = new Timer();
            DelayTime.Interval = 1000;
            DelayTime.Tick += new EventHandler(PingtoPlanet);
            DelayTime.Start();
        }

        private void turnback_Tick(object sender, EventArgs e)
        {
            
            if (backcount == 0)
            {
                timer.Stop();
                lbtemps.Text = "00:00";

            }else if (backcount < 10)
            {                
                lbtemps.Text = "00:0" + backcount;
                backcount--;
            }
            else
            {
                
                lbtemps.Text = "00:" + backcount ; //+ (backcount * 1000).ToString()
                backcount--;
            }

        }

        private void Validar()
        {
            thread.Abort();
            //El sistema indicarà si els 2 codis són iguals o no.
            if (txtIntroduit.Text.Trim().Equals(lbCodiValid.Text))
            {
                //Delay();
                panel1.BackColor = Color.Green;
                timer.Stop();
                btnScan.Visible = true;
                Delay();
                
            }
            else
            {
                panel1.BackColor = Color.Red;
                timer.Stop();               
            }
        }

        private void HILO()
        {
            while (portArduino.IsOpen)
            {
                try
                {
                    string valor = portArduino.ReadLine().ToString();

                    if (txtIntroduit.InvokeRequired)
                    {
                        txtIntroduit.Invoke((MethodInvoker)delegate
                        {
                            txtIntroduit.Text = valor.ToString();
                        });
                    }                                       
                }
                catch (Exception)
                {}

            }
        }


        private void Usuari_Panel() //MIRAR SI MEJORAR
        {
            int valor = RandomGenerator();
            Random random = new Random(valor);

            string[] lletres = { "A", "B", "C", "D" };
            string[] numeros = { "1", "2", "3", "4", "5" };

            int LIndex = random.Next(lletres.Length);
            int NIndex = random.Next(numeros.Length);

            lbUser.Text = lletres[LIndex] + numeros[NIndex];
        }

        private void ValidarUser()
        {
            try
            {
                PrimeraBaseDeDadesEntities db = new PrimeraBaseDeDadesEntities();
                string userLogin = lbUser.Text;
                string pasww = txtPass.Text;

                var correcta = db.AdminCoordinates.FirstOrDefault(p => p.Coordinate == userLogin && p.ValueCoord == pasww);
                
                if (correcta != null)
                {
                    MessageBox.Show("Correcta");

                }
                else
                {
                    MessageBox.Show("Usuario invalido!");
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        #endregion

        #region Events
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                cbPorts.Items.Add(port);
            }

            Usuari_Panel();
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionat = true;
        }

        private void btnContaEnrera_Click(object sender, EventArgs e)
        {
            lbtemps.Visible = true;
            //Generar numeors aleatoris A1 - D5
            GeneradorA1D5();
            timer = new Timer();
            timer.Interval = 750;
            timer.Tick += new EventHandler(turnback_Tick);
            btnContaEnrera.Enabled = false;


            //Generarà el codi de 6 xifres aleatòries al PC
            int digit, randomInteger;
            randomInteger = RandomGenerator();
            Random random = new Random(randomInteger);
            digit = random.Next(Password.Count);
            string passw = Password[digit].valors;
            lbCodiValid.Text = passw;

            //Enviar al Arduino (missatge SA) comensa compta enrerra
            timer.Start();
            portArduino.Write("SA\n");
            //ILO PARA PODER RECORRER EL TXTBOX
            thread = new Thread(HILO);
            thread.Start();

        }

        private void txtIntroduit_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            qr = new CodeCard();
            qr.TopLevel = false;
            QRScanner.Controls.Add(qr);
            qr.Dock = DockStyle.Fill;
            qr.Show();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidarUser();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (portArduino == null)
                {
                    Exception error = new Exception();
                    throw error;
                }

                if (portArduino.IsOpen) { portArduino.Close(); }

                qr.Close();

            }
            catch (Exception) { }
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
                        groupBox1.Visible = true;
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
                    btnComprovar.Enabled = false;
                }

            }
        }
        #endregion
    }
}