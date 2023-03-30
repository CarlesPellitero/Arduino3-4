using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace Sprint6_Pellitero_Carles
{
    public partial class AdminCoord : Form
    {
        public AdminCoord()
        {
            InitializeComponent();
        }

        private SqlConnection conn;
        private string query;
        DataSet dts;
        public Dictionary<string, string> openWith;
        public ArrayList code;


        public string GenerarCnx()
        {
            //Carles: 
            string cnx = "Data Source=DESKTOP-K19N91Q;Initial Catalog=PrimeraBaseDeDades;Integrated Security=True";

            //Isaac:
            //string cnx = "";

            //Moha:
            //string cnx = "";

            ConnectionStringSettings connec =
            ConfigurationManager.ConnectionStrings["Conecció"];

            if (connec != null)
            {
                cnx = connec.ConnectionString;
            }
            conn = new SqlConnection(cnx);

            return cnx;
        }

        private void showData()
        {
            dts = PortarDTS();

            for (int i = 0; i < dts.Tables[0].Rows.Count; i++)
            {
                Label lblcontenido = new Label();
                lblcontenido.Text = dts.Tables[0].Rows[i].Field<string>("ValueCoord");
                lblcontenido.Dock = DockStyle.Fill;
                lblcontenido.TextAlign = ContentAlignment.MiddleCenter;
                tblCoords.Controls.Add(lblcontenido);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            tblCoords.Visible = false;

            Control l = this.tblCoords.GetControlFromPosition(1, 1);
            if (l != null)
            {

                for (int i = 1; i <= 20; i++)
                {

                    Control c = this.tblCoords.GetControlFromPosition(1, 1);


                    c.Dispose();

                }
            }
            showData();
            tblCoords.Visible = true;
        }

        public DataSet PortarDTS()
        {
            string cnx;
            cnx = GenerarCnx();
            conn = new SqlConnection(cnx);
            SqlDataAdapter sqadapter;
            dts = new DataSet();

            query = "SELECT * FROM ADMINCOORDINATES";
            sqadapter = new SqlDataAdapter(query, conn);
            conn.Open();

            sqadapter.Fill(dts, "ADMINCOORDINATES");

            conn.Close();

            return dts;
        }

        private void AdminCoord_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
