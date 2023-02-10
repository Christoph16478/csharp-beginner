using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bsp06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sobald der benutzer die Schaltfläche klickt,
            // wird der Code ausgeführt.
            Addieren();

        }

        private void Addieren()
        {
            //throw new NotImplemented Exception();

            // Werte aus der Oberfläche in den Codeblock holen.
            double zahl1 = double.Parse(txtZahl1.Text);
            double zahl2= double.Parse(txtZahl2.Text);

            double ergebnis = zahl1 + zahl2;
            txtErgebnis.Text = ergebnis.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtErgebnis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
