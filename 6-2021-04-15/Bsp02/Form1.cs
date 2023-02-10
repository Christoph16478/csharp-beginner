using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bsp02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListeLaden_Click(object sender, EventArgs e)
        {
            List<Person> liste1 = GetPersonen();
            dataGridView1.DataSource = liste1;

        }

        private void btFrauen_Click(object sender, EventArgs e)
        {
            List<Person> liste1 = GetPersonen();
            List<Person> listeFrauen = liste1.Where(x => x.Anrede == "Frau").ToList();
            dataGridView1.DataSource = listeFrauen;
        }

        private void btnHerren_Click(object sender, EventArgs e)
        {
            List<Person> liste1 = GetPersonen();
            List<Person> listeFrauen = liste1.Where(x => x.Anrede == "Herr").ToList();
            dataGridView1.DataSource = listeFrauen;

        }

        private static List<Person> GetPersonen()
        {
            List<Person> personenListe = new List<Person>();

            personenListe.Add(new Person
            {
                Personalnummer = 1,
                Anrede = "Herr",
                Vorname = "Max",
                Nachname = "Mustermann",
                GebJahr = 1898
            });

            personenListe.Add(new Person
            {
                Personalnummer = 2,
                Anrede = "Frau",
                Vorname = "Erika",
                Nachname = "Musterfrau",
                GebJahr = 1999
            });

            personenListe.Add(new Person
            {
                Personalnummer = 3,
                Anrede = "Herr",
                Vorname = "Felix",
                Nachname = "Mustersohn",
                GebJahr = 2001
            });

            personenListe.Add(new Person
            {
                Personalnummer = 4,
                Anrede = "Herr",
                Vorname = "Friedrich",
                Nachname = "Musteronkel",
                GebJahr = 1956
            });

            return personenListe;
        }
    }
}
