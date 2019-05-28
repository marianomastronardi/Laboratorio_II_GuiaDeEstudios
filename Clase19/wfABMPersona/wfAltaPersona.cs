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

namespace wfABMPersona
{
  public partial class wfAltaPersona : Form
  {
    public Persona persona;    
    public wfAltaPersona()
    {
      InitializeComponent();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void btnAceptar_Click(object sender, EventArgs e)
    {
      if (!(string.IsNullOrEmpty(txtNombre.Text.Trim()) || string.IsNullOrEmpty(txtApellido.Text.Trim()) || string.IsNullOrEmpty(txtDNI.Text.Trim())))
      {
        persona = new Persona(txtNombre.Text, txtApellido.Text, txtDNI.Text);
        this.DialogResult = DialogResult.OK;
      }
      else
      {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        throw new Exception("Datos Incompletos!");
      }
    }
  }
}
