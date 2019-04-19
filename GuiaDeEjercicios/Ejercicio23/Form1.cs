using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace Ejercicio23
{
    public partial class frmConversorDinero : Form
    {
        public frmConversorDinero()
        {
            InitializeComponent();
        }

        private void frmConversorDinero_Load(object sender, EventArgs e)
        {
            txtDolarADolar.Enabled = false;
            txtDolarAEuro.Enabled = false;
            txtDolarAPesos.Enabled = false;

            txtEuroADolar.Enabled = false;
            txtEuroAEuro.Enabled = false;
            txtEuroAPesos.Enabled = false;

            txtPesosADolar.Enabled = false;
            txtPesosAEuro.Enabled = false;
            txtPesosAPesos.Enabled = false;
        }

        private void btnConvertirEuro_Click(object sender, EventArgs e)
        {
            double euros;
            if (!(string.IsNullOrEmpty(txtEuroAConvertir.Text)))
            {
                txtEuroAEuro.Text = txtEuroAConvertir.Text;
                txtEuroADolar.Text = double.TryParse(txtEuroAConvertir.Text.Replace(".",","), out euros) ? ((Dolar)(new Euro(euros))).GetCantidad().ToString() : "0";
                txtEuroAPesos.Text = double.TryParse(txtEuroAConvertir.Text.Replace(".", ","), out euros) ? ((Pesos)(new Euro(euros))).GetCantidad().ToString() : "0";
            }
        }

        private void btnConvertirDolar_Click(object sender, EventArgs e)
        {
            double dolar;
            if(!(string.IsNullOrEmpty(txtDolarAConvertir.Text)))
            {
                txtDolarAEuro.Text = double.TryParse(txtDolarAConvertir.Text.Replace(".", ","), out dolar) ? ((Euro)(new Dolar(dolar))).GetCantidad().ToString() : "0";
                txtDolarADolar.Text = txtDolarAConvertir.Text;
                txtDolarAPesos.Text = double.TryParse(txtDolarAConvertir.Text.Replace(".", ","), out dolar) ? ((Pesos)(new Dolar(dolar))).GetCantidad().ToString() : "0";
            }
        }

        private void btnConvertirPesos_Click(object sender, EventArgs e)
        {
            double pesos;
            if(!(string.IsNullOrEmpty(txtPesosAConvertir.Text)))
            {
                txtPesosAEuro.Text = double.TryParse(txtPesosAConvertir.Text.Replace(".", ","), out pesos) ? ((Euro)(new Pesos(pesos))).GetCantidad().ToString() : "0";
                txtPesosADolar.Text = double.TryParse(txtPesosAConvertir.Text.Replace(".", ","), out pesos) ? ((Dolar)(new Pesos(pesos))).GetCantidad().ToString() : "0";
                txtPesosAPesos.Text = txtPesosAConvertir.Text;
            }
        }
    }
}
