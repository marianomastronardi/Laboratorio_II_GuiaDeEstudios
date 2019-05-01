using System;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        public FormDT()
        {
            InitializeComponent();
        }

        private void FormDT_Load(object sender, EventArgs e)
        {

        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            this.dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, (int)numericUpDownEdad.Value, (int)numericUpDownDni.Value, (int)numericUpDownExperiencia.Value);            
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            if (this.dt == null)
                MessageBox.Show("Aún no se ha creado el DT del formulario", "Atención", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
                MessageBox.Show(dt.ValidarAptitud() ? "El DT es apto." : "El DT no es apto.", "Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
