using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ednevnik410b
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_Osoba = new Osoba();
            frm_Osoba.Show();
        }

        private void Glavna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void smeroviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik sifarnik = new Sifarnik("Smer");
            sifarnik.Show();
        }

        private void skolskeGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik sifarnik = new Sifarnik("skolska_godina");
            sifarnik.Show();
        }

        private void osobeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sifarnik sifarnik = new Sifarnik("osoba");
            sifarnik.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik sifarnik = new Sifarnik("predmet");
            sifarnik.Show();
        }
    }
}
