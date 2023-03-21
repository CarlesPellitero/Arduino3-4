using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sprint6_Pellitero_Carles
{
    public partial class QRGenerator : Form
    {
        public QRGenerator()
        {
            InitializeComponent();
        }
        bool validated = false;
        private void obtenerNombreUsuario()
        {
            try
            {
                PrimeraBaseDeDadesEntities db = new PrimeraBaseDeDadesEntities();
                List<string> codeUser = new List<string>();
                List<string> DescUser = new List<string>();

                string userLogin = tbxLogin.Text;
                var UserDB = db.Users.FirstOrDefault(p => p.codeUser == userLogin);
                if (UserDB != null)
                {
                    tbxUser.Text = UserDB.descUser;
                    validated = true;

                }
                else
                {
                    MessageBox.Show("Usuario invalido!");
                    tbxLogin.Clear();
                    tbxLogin.Focus();
                }
            }
            catch (Exception)
            {

            }

        }
        private void GenerarQR()
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(tbxInfo.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            ptbQR.Image = code.GetGraphic(5);

        }
        public void subirQR()
        {
            try
            {
                PrimeraBaseDeDadesEntities db = new PrimeraBaseDeDadesEntities();
                CodeChain CodeBD = new CodeChain();
                List<string> Codes = new List<string>();
                List<string> codeUser = new List<string>();
                List<string> DescUser = new List<string>();

                string userLogin = tbxLogin.Text;
                var UserDB = db.Users.FirstOrDefault(p => p.codeUser == userLogin);
                CodeBD.CodeChain1 = tbxInfo.Text;
                CodeBD.idUser = UserDB.idUser;
                db.CodeChains.Add(CodeBD);
                db.SaveChanges();
            }
            catch (Exception)
            {

            }
        }
        private void btnGnQR_Click(object sender, EventArgs e)
        {
            ptbQR.Image = null;
            if (!String.IsNullOrEmpty(tbxInfo.Text))
            {
                GenerarQR();
                subirQR();

            }

        }

        private void tbxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                obtenerNombreUsuario();
                if (validated)
                {
                    btnGnQR.Visible = true;
                    ptbQR.Visible = true;
                }
                else
                {
                    tbxLogin.Focus();
                }
            }
        }

        private void tbxLogin_Enter(object sender, EventArgs e)
        {
            tbxLogin.Focus();
        }
    }
}
