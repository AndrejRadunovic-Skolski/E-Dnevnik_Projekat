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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("");
            }
            else
            {
                try
                {
                    SqlConnection veza = Konekcija.NapraviVezu();
                    SqlCommand cmd = new SqlCommand("Select * from osoba where email=@username", veza);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    int brojac = tabela.Rows.Count;
                    if(brojac == 1)
                    {
                        if (String.Compare(tabela.Rows[0]["pass"].ToString(), textBox2.Text) == 0)
                        {
                            Console.WriteLine("Da");
                            MessageBox.Show("Login uspesan!");
                            this.Hide();
                            Glavna glavna = new Glavna();
                            glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Pogresna lozinka.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostojeći emajl");
                    }
                }
                catch(Exception greska) { 
                    MessageBox.Show(greska.Message);
                }
            }
        }
    }
}
