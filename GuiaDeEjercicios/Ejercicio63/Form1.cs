using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //Thread t = new Thread(new ParameterizedThreadStart(AsignarHora));
      //t.Start(DateTime.Now);
      AsignarHora(DateTime.Now);
    }

    private void AsignarHora(object o)
    {
      if (this.label1.InvokeRequired)
      {
        this.label1.BeginInvoke((MethodInvoker)delegate ()
          {
            this.label1.Text = o.ToString();
          }
        );
      }
      else
      {
        this.label1.Text = o.ToString();
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      AsignarHora(DateTime.Now);
    }
  }
}
