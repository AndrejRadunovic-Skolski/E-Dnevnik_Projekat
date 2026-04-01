using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ednevnik410b
{
    public partial class Upisnica : Form
    {
        public Upisnica()
        {
            InitializeComponent();
        }
        private void PopulateComboGodina()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            DataTable godina = new DataTable();
            adapter.Fill(godina);
            Combo_Godine.DataSource = godina;
            Combo_Godine.ValueMember = "id";
            Combo_Godine.DisplayMember = "naziv";
            Combo_Godine.SelectedValue = 2;
        }

        private void PopulateComboOdeljenje()
        {
            string godina = Combo_Godine.SelectedValue.ToString();
            SqlConnection veza = Konekcija.NapraviVezu();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, razred, indeks, godina_id, str(razred)+'-'+indeks as naziv FROM Odeljenje", veza);
            DataTable Odeljenje = new DataTable();
            adapter.Fill(Odeljenje);
            Combo_Odeljenje.DataSource = Odeljenje;
            Combo_Odeljenje.ValueMember = "id";
            Combo_Odeljenje.DisplayMember = "naziv";
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {
            PopulateComboGodina();
            PopulateComboOdeljenje();
            Combo_Odeljenje.SelectedIndex = 1;
        }

        private void PopulateComboUcenik()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, prezime+' '+ime as naziv FROM Osoba", veza);
            DataTable ucenik = new DataTable();
            adapter.Fill(ucenik);
            Combo_Ucenik.DataSource = ucenik;
            Combo_Ucenik.ValueMember = "id";
            Combo_Ucenik.DisplayMember = "naziv";
        }
        private void PopulateDataGridView()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            string naredba = "SELECT Upisnica.id, ime+' '+prezime as ucenik, str(razred)+'-'+indeks as odel, Odeljenje.Godina_id as god_id, Odeljenje.id as odel_id, Osoba.id as os_id from Upisnica JOIN Osoba ON Osoba_id=Osoba.id JOIN Odeljenje ON Odeljenje_id=Odeljenje.id";
            SqlDataAdapter adapter = new SqlDataAdapter(naredba, veza);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            dataGridView1.DataSource = tabela;
            dataGridView1.AllowUserToAddRows = false;
            tabela.Columns["id"].ColumnName = "ID";
            tabela.Columns["ucenik"].ColumnName = "Učenik";
            tabela.Columns["odel"].ColumnName = "Odjeljenje";
            dataGridView1.Columns["god_id"].Visible = false;
            dataGridView1.Columns["odel_id"].Visible = false;
            dataGridView1.Columns["os_id"].Visible = false;
        }

        private void PopulateCombos()
        {
            PopulateComboGodina();
            PopulateComboOdeljenje();
            PopulateComboUcenik();
        }

        private void Combo_Godine_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Combo_Godine.IsHandleCreated && Combo_Godine.Focused)
            {
                PopulateComboOdeljenje();
                Combo_Odeljenje.SelectedIndex = -1;
                Combo_Odeljenje.Enabled = true;
                Combo_Ucenik.Enabled = false;
                Combo_Ucenik.SelectedIndex = -1;
            }
        }

        private void Combo_Odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Combo_Odeljenje.IsHandleCreated && Combo_Odeljenje.Focused)
            {
                PopulateComboUcenik();
                Combo_Ucenik.Enabled = true;
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int brSloga = dataGridView1.CurrentRow.Index;
                Combo_Godine.SelectedValue = dataGridView1.Rows[brSloga].Cells["god_id"].Value.ToString();
                Combo_Odeljenje.SelectedValue = dataGridView1.Rows[brSloga].Cells["odel_id"].Value.ToString();
                Combo_Ucenik.SelectedValue = dataGridView1.Rows[brSloga].Cells["os_id"].Value.ToString();
                textBox1.Text = dataGridView1.Rows[brSloga].Cells["id"].Value.ToString();
            }
        }
    }
}
