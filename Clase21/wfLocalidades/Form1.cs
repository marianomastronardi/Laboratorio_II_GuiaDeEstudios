using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;

namespace wfLocalidades
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      SqlConnection cn = new SqlConnection(Properties.Settings.Default.DBMariano);
      SqlCommand cmProv = new SqlCommand("Select Id, Nombre From dbo.Provincias", cn);
      List<Provincia> list = new List<Provincia>();
      cn.Open();

      SqlDataReader oDr = cmProv.ExecuteReader();

      while(oDr.Read())
      {
        list.Add(new Provincia((int)(decimal)oDr["Id"], oDr["Nombre"].ToString()));
      }

      comboBox1.DataSource = list;
      cn.Close();
    }
  }
}
