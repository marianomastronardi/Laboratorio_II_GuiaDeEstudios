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
using System.Xml;
using System.Xml.Serialization;

namespace wfABMPersona
{
  public partial class wfListPersona : Form
  {
    wfAltaPersona alta = new wfAltaPersona();
    List<Persona> personas;

    public wfListPersona()
    {
      InitializeComponent();
      personas = new List<Persona>();
    }

    private void btnNuevo_Click(object sender, EventArgs e)
    {
      try
      {
        if (alta.ShowDialog() == DialogResult.OK)
        {
          personas += alta.persona;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnRefrescar_Click(object sender, EventArgs e)
    {
      lbPersonas.Items.Clear();
      foreach(Persona p in personas)
      {
        this.lbPersonas.Items.Add(p);
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      List<Persona> l = new List<Persona>();
      XmlTextWriter writer;
      XmlSerializer ser;
      string path = "";

      writer = new XmlTextWriter(path, Encoding.UTF8);

      ser = new XmlSerializer(typeof(List<Persona>));

      ser.Serialize(writer, l);

      writer.Close();
    }

    private void wfListPersona_Load(object sender, EventArgs e)
    {
      List<Persona> l = new List<Persona>();
      XmlTextReader reader;
      XmlSerializer ser;

      reader = new XmlTextReader("");

      ser = new XmlSerializer(typeof(List<Persona>));

      l = (List<Persona>)ser.Deserialize(reader);

      reader.Close();
    }
  }
}
