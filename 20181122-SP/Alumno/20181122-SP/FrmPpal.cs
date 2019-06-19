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
using Archivos;
using System.Threading;
using Patentes;

namespace _20181122_SP
{
  public partial class FrmPpal : Form
  {
    Queue<Patente> cola;
    List<Thread> listT;
    public FrmPpal()
    {
      InitializeComponent();
      listT = new List<Thread>();
      this.cola = new Queue<Patente>();
    }

    private void FrmPpal_Load(object sender, EventArgs e)
    {
      vistaPatente1.finExposicion += this.ProximaPatente;
      vistaPatente2.finExposicion += this.ProximaPatente;
    }

    private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
    {
      this.FinalizarSimulacion();
    }

    private void btnXml_Click(object sender, EventArgs e)
    {

    }

    private void btnTxt_Click(object sender, EventArgs e)
    {

    }

    private void btnSql_Click(object sender, EventArgs e)
    {

    }

    private void FinalizarSimulacion()
    {
      foreach (Thread t in this.listT)
        t.Abort();
    }

    private void ProximaPatente(VistaPatente vp)
    {

    }
  }
}
