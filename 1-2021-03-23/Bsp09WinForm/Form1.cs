using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bsp09WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStarten_Click(object sender, EventArgs e)
        {
            // Event
            // Klick-Event
            // 2x Klicken auf Button ---> ein neues Code-Block wird erstellt.
            // das nennt sich Klick-Event.

            //MessageBox.Show("Hallo");

            // label3.Text = "Hallo";

            // int c = a + b;

            label3.Text = "Hallo " + txtVorname.Text + " " + txtNachname.Text;

        }
    }
}
