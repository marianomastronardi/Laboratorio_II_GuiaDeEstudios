using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Controles;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace _20190711_Final
{
    public partial class FrmAerolinea : Form
    {
        private Aeropuerto<Vuelo> aeropuerto;

        public FrmAerolinea()
        {
            InitializeComponent();

            this.aeropuerto = new Aeropuerto<Vuelo>();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int horas = (int)nudHorasDeVuelo.Value;
            Vuelo vuelo = new Vuelo(horas);
            int ejeY = this.aeropuerto + vuelo;

            this.Controls.Add(vuelo);
            vuelo.Location = new Point(0, ejeY);
            
            vuelo.Despegar();
        }

        private void FrmAerolinea_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.aeropuerto.FinalizarVuelos();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
            XmlTextWriter writer = new XmlTextWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Aeropuerto.xml", Encoding.UTF8);
            XmlSerializer ser = new XmlSerializer(typeof(Aeropuerto<Vuelo>));

            ser.Serialize(writer, this.aeropuerto);
                writer.Close();
            }
            catch(ErrorArchivoException eFile)
            {
                MessageBox.Show(eFile.InnerException.Message);    
            }
            finally
            {
              
            }
        }

        private void binarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este método");
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ToString());
            SqlCommand comando = new SqlCommand("Insert into [dbo].[Bitacora] Values ('11/07/2019','Mariano.Garcia.Mastronardi')");

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        private void baseDeDatosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ToString());
            SqlCommand comando = new SqlCommand("Select * From [dbo].[Bitacora]");

            conexion.Open();
            SqlDataReader oDr = comando.ExecuteReader();
            while(oDr.Read())
            {

            }
            conexion.Close();
        }

        private void FrmAerolinea_Load(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter("Aeropuerto.xml", Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(Aeropuerto<Vuelo>));

                ser.Serialize(writer, this.aeropuerto);
                writer.Close();
            }
            catch (ErrorArchivoException eFile)
            {
                MessageBox.Show(eFile.InnerException.Message);
            }
            finally
            {

            }
        }

        private void binarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No elegí este método");
        }
    }
}
