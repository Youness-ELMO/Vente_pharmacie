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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection cnx;
        


        private void button8_Click(object sender, EventArgs e)
        {
            pos ++;
            navigation();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection(@"Data Source=DESKTOP-A7ECOHN\SQLEXPRESS;Initial Catalog=Vente_pharmacie;Integrated Security=True");


            dataGridView1.Columns.Add("CIN", "CIN");
            dataGridView1.Columns.Add("Genre", "Genre");
            dataGridView1.Columns.Add("Nom", "Nom");
            dataGridView1.Columns.Add("Prenom", "Prenom");
            dataGridView1.Columns.Add("Tel", "Tel");
            dataGridView1.Columns.Add("Adresse", "Adresse");
            dataGridView1.Columns.Add("Ville", "Ville");
            dataGridView1.Columns.Add("numero_magasin", "numero_magasin");


            cnx.Open();
            string af = "select*from Client";
            SqlCommand cmd=new SqlCommand(af, cnx);
            SqlDataReader r= cmd.ExecuteReader();
            while (r.Read())
            {
                dataGridView1.Rows.Add(r[0], r[1], r[2], r[3], r[4], r[5], r[6], r[7]);
            }

            cnx.Close();

        }
        int pos;
        public void navigation()
        {
            textBox1.Text = dataGridView1.Rows[pos].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[pos].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[pos].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[pos].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[pos].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[pos].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[pos].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[pos].Cells[7].Value.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            cnx.Open();
            string aj = "insert into Client values ("+textBox1.Text+",'"+textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "'," + textBox5.Text + ",'" + textBox6.Text + "','" + textBox7.Text + "'," + textBox8.Text + ")";
            SqlCommand cmd = new SqlCommand(aj, cnx);
            MessageBox.Show("ajout bien fait !!");
            cnx.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnx.Open();
            string M = "update Client set Genre='" + textBox2.Text + "',Nom='" + textBox3.Text + "',Prenom='" + textBox4.Text + "',Tel=" + textBox5.Text + ",Adresse='" + textBox6.Text + "',Ville='" + textBox7.Text + "',numero_magasin=" + textBox8.Text + "  where CIN=" + textBox1.Text + "";
            SqlCommand cmd = new SqlCommand(M, cnx);
            MessageBox.Show("Modification bien fait !!");
            cnx.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cnx.Open();
            string S = "delete Client  where CIN=" + textBox1.Text + "";
            SqlCommand cmd = new SqlCommand(S, cnx);
            MessageBox.Show("Modification bien fait !!");
            cnx.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pos = 0;
            navigation();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pos --;
            navigation();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pos = dataGridView1.Rows.Count-2;
            navigation();
        }
    }
}
