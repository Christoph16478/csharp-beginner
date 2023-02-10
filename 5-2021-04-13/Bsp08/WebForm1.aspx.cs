using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bsp08
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddieren_Click(object sender, EventArgs e)
        {
            Addieren();
        }

        private void Addieren()
        {
            double zahl1 = double.Parse(txtZahl1.Text);
            double zahl2 = double.Parse(txtZahl2.Text);

            double ergebnis = zahl1 + zahl2;
            txtErgebnis.Text = ergebnis.ToString();
        }
    }
}