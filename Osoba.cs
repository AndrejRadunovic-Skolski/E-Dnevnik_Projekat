using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ednevnik410b
{
    public partial class Osoba : Form
    {
        public Osoba()
        {
            InitializeComponent();
        }

        int broj = 0;
        DataTable Tabela;


        private void UcitajPodatke()
        {
            SqlConnection veza = Konekcija.NapraviVezu();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from osoba", veza);
            Tabela = new DataTable();
            adapter.Fill(Tabela);
        }

        private void UcitajTekst()
        {
            if (Tabela.Rows.Count > 0)
            {
                textBox1.Text = Tabela.Rows[broj]["id"].ToString();
                textBox2.Text = Tabela.Rows[broj]["ime"].ToString();
                textBox3.Text = Tabela.Rows[broj]["prezime"].ToString();
                textBox4.Text = Tabela.Rows[broj]["adresa"].ToString();
                textBox5.Text = Tabela.Rows[broj]["jmbg"].ToString();
                textBox6.Text = Tabela.Rows[broj]["email"].ToString();
                textBox7.Text = Tabela.Rows[broj]["pass"].ToString();
                textBox8.Text = Tabela.Rows[broj]["uloga"].ToString();
            }
            else
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                textBox8.Text = " ";
            }


            if (broj == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

            if (broj == Tabela.Rows.Count - 1)
            {
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                button7.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            broj--;
            UcitajTekst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder komanda = new StringBuilder("insert into osoba(ime, prezime, adresa, jmbg, email, pass, uloga) values('");

            komanda.Append(textBox2.Text + "', '");
            komanda.Append(textBox3.Text + "', '");
            komanda.Append(textBox4.Text + "', '");
            komanda.Append(textBox5.Text + "', '");
            komanda.Append(textBox6.Text + "', '");
            komanda.Append(textBox7.Text + "', '");
            komanda.Append(textBox8.Text + "')");

            SqlConnection veza = Konekcija.NapraviVezu();
            SqlCommand adapter = new SqlCommand(komanda.ToString(), veza);
            try
            {
                veza.Open();
                adapter.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UcitajPodatke();
            broj = Tabela.Rows.Count - 1;
            UcitajTekst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder komanda = new StringBuilder("update osoba set ");

            komanda.Append("ime = '" + textBox2.Text + "', ");
            komanda.Append("prezime = '" + textBox3.Text + "', ");
            komanda.Append("adresa = '" + textBox4.Text + "', ");
            komanda.Append("jmbg = '" + textBox5.Text + "', ");
            komanda.Append("email = '" + textBox6.Text + "',");
            komanda.Append("pass = '" + textBox7.Text + "', ");
            komanda.Append("uloga = '" + textBox8.Text + "'");

            komanda.Append("Where id = " + textBox1.Text    );

            SqlConnection veza = Konekcija.NapraviVezu();
            SqlCommand adapter = new SqlCommand(komanda.ToString(), veza);
            try
            {
                veza.Open();
                adapter.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            UcitajPodatke();
            UcitajTekst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string komanda = "delete from osoba where id = " + textBox1.Text;
            SqlConnection veza = Konekcija.NapraviVezu();

            SqlCommand adapter = new SqlCommand(komanda, veza);
            bool brisano = false;
            try
            {
                veza.Open();
                adapter.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (brisano)
            {
                if(broj > 0)
                {
                    broj--;

                }
                UcitajPodatke();
                UcitajTekst();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            broj++;
            UcitajTekst();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            broj = Tabela.Rows.Count - 1;
            UcitajTekst();
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajTekst();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            broj = 0;
            UcitajTekst();
        }
    }
}
