using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Ejercicio28
{
    public partial class frmContadorPalabras : Form
    {
        public frmContadorPalabras()
        {
            InitializeComponent();
        }

        private void frmContadorPalabras_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string textFromRichTextBox = rtbContadorPalabras.Text;
            string[] strPalabras = textFromRichTextBox.Split(' ');

            Dictionary<string, int> dtyList = new Dictionary<string, int>();

            foreach (string word in strPalabras)
            {
                if (!dtyList.ContainsKey(word))
                    dtyList.Add(word, 1);
                else
                    dtyList[word] = dtyList[word] + 1;
            }

            dtyList = dtyList.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < 3;i++)
            {
                sb.Append(dtyList.ElementAt(i).Key.ToString().PadRight(15,' ') + dtyList.ElementAt(i).Value.ToString() + "\n");
            }

            MessageBox.Show(sb.ToString(), "Palabras mas usadas");
        }
    }
}
