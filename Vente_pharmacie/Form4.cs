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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection cnx;
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'vente_pharmacieDataSet4.Cheque'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chequeTableAdapter3.Fill(this.vente_pharmacieDataSet4.Cheque);
            // TODO: cette ligne de code charge les données dans la table 'vente_pharmacieDataSet3.Cheque'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chequeTableAdapter2.Fill(this.vente_pharmacieDataSet3.Cheque);
            // TODO: cette ligne de code charge les données dans la table 'vente_pharmacieDataSet2.Cheque'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chequeTableAdapter1.Fill(this.vente_pharmacieDataSet2.Cheque);
            // TODO: cette ligne de code charge les données dans la table 'vente_pharmacieDataSet1.Cheque'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.chequeTableAdapter.Fill(this.vente_pharmacieDataSet1.Cheque);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                cnx.Open();
                string af = "select*from Cheque where Date_emission ='"+dateTimePicker1.Value+"'";
                SqlCommand cmd = new SqlCommand(af, cnx);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
                }

                cnx.Close();
            }
            else if (checkBox2.Checked)
            {
                cnx.Open();
                string af = "select*from Cheque where Montant =" + textBox1.Text + "";
                SqlCommand cmd = new SqlCommand(af, cnx);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
                }

                cnx.Close();
            }
            else if (checkBox3.Checked)
            {
                cnx.Open();
                string af = "select*from Cheque where code_motif =" + comboBox1.SelectedValue + "";
                SqlCommand cmd = new SqlCommand(af, cnx);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
                }

                cnx.Close();
            }
            else if (checkBox4.Checked)
            {
                cnx.Open();
                string af = "select*from Cheque where CIN =" + comboBox2.SelectedValue + "";
                SqlCommand cmd = new SqlCommand(af, cnx);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
                }

                cnx.Close();
            }
            else if (checkBox5.Checked)
            {
                cnx.Open();
                string af = "select*from Cheque where code_Banque =" + comboBox3.SelectedValue + "";
                SqlCommand cmd = new SqlCommand(af, cnx);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
                }

                cnx.Close();
            }
            else if (checkBox6.Checked)
            {
                cnx.Open();
                string af = "select*from Cheque where numero_magasin =" + comboBox4.SelectedValue + "";
                SqlCommand cmd = new SqlCommand(af, cnx);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
                }

                cnx.Close();
            }
            else
            {
                MessageBox.Show("choisir une !!");
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cnx.Open();
            var dgv = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string af = "select Client(*),count(numero_cheque) from Client join Cheque on Client.CIN= Cheque.CIN where CIN =" + dgv + " ";
            SqlCommand cmd = new SqlCommand(af, cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox2.Text = dr[0].ToString();
            textBox3.Text = dr[1].ToString();
            textBox4.Text = dr[2].ToString();
            textBox5.Text = dr[3].ToString();
            textBox6.Text = dr[4].ToString();
            textBox7.Text = dr[5].ToString();
            textBox8.Text = dr[6].ToString();            
            label9.Text = dr[7].ToString();

            cnx.Close();
            
        } 

    }
}
