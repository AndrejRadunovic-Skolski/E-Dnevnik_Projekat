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
    public partial class Sifarnik : Form
    {
        DataTable tabela;
        SqlDataAdapter Adapter; 
        string imeTabele;
        public Sifarnik(string tab)
        {
            imeTabele = tab;
            InitializeComponent();
        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            Adapter = new SqlDataAdapter("select * from " + imeTabele, Konekcija.NapraviVezu());
            tabela = new DataTable();
            Adapter.Fill(tabela);
            dataGridView_Sifarnik.DataSource = tabela;

            DataGridViewColumn column = dataGridView_Sifarnik.Columns["id"];

            if (column != null)
            {
                dataGridView_Sifarnik.Columns["id"].ReadOnly = true;
            }
            else
            {
                Console.WriteLine("Nece da hoce.");
            }

        }

        private void btn_Sifarnik_Click(object sender, EventArgs e)
        {
            DataTable menjano = tabela.GetChanges();
            Adapter.UpdateCommand = new SqlCommandBuilder(Adapter).GetUpdateCommand();
            if (menjano != null)
            {
                Adapter.Update(menjano);
                this.Close();
            }
        }
    }
}
