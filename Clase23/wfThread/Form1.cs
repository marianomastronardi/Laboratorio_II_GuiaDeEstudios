using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfThread
{
  public partial class Form1 : Form
  {
    List<bool> controles = new List<bool>() {false, false, false, false};
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      textBox1.Text = "0";
      textBox2.Text = "0";
      textBox3.Text = "0";
      textBox4.Text = "0";
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (timer1.Enabled)
        timer1.Stop();
      else
        timer1.Start();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (timer2.Enabled)
        timer2.Stop();
      else
        timer2.Start();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      if (timer3.Enabled)
        timer3.Stop();
      else
        timer3.Start();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      if (timer4.Enabled)
        timer4.Stop();
      else
        timer4.Start();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      textBox1.Text = (Convert.ToInt64(textBox1.Text) + 1).ToString();
    }

    private void timer2_Tick(object sender, EventArgs e)
    {
      textBox2.Text = (Convert.ToInt64(textBox2.Text) + 1).ToString();
    }

    private void timer3_Tick(object sender, EventArgs e)
    {
      textBox3.Text = (Convert.ToInt64(textBox3.Text) + 1).ToString();
    }

    private void timer4_Tick(object sender, EventArgs e)
    {
      textBox4.Text = (Convert.ToInt64(textBox4.Text) + 1).ToString();
      ((Button)sender).Name
    }

    private void sumar(string name)
    {
      switch(name)
        case "":
        
    }
  }
}
