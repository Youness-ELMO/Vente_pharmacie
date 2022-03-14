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


namespace Vente_pharmacie
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection cnx;
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'vente_pharmacieDataSet.Cheque'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chequeTableAdapter.Fill(this.vente_pharmacieDataSet.Cheque);
            cnx = new SqlConnection(@"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=Vente_pharmacie;Integrated Security=True");


            dataGridView1.Columns.Add("numero_cheque", "numero_cheque");
            dataGridView1.Columns.Add("Date_emission", "Date_emission");
            dataGridView1.Columns.Add("Montant", "Montant");
            dataGridView1.Columns.Add("url_cheque", "url_cheque");
            dataGridView1.Columns.Add("code_motif", "code_motif");
            dataGridView1.Columns.Add("CIN", "CIN");
            dataGridView1.Columns.Add("code_Banque", "code_Banque");
            dataGridView1.Columns.Add("numéro_magasin", "numéro_magasin");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnx.Open();
            string af = "select numero_magasin from Cheque where code_motif="+comboBox1.SelectedValue+"";
            SqlCommand cmd = new SqlCommand(af, cnx);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                comboBox2.Items.Add(r[0]);
            }

            cnx.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            string af = "select*from Cheque where numéro_magasin= "+comboBox2.SelectedValue+ " order by Date_emission ";
            SqlCommand cmd = new SqlCommand(af, cnx);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
            }

            cnx.Close();
        }
    }
}
