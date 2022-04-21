using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace Tienda_de_Abarrotes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CajaDGV.DataSource = ObtenerCajaTabla();
        }
        private DataTable ObtenerCajaTabla()
        {
            DataTable dtCaja = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Caja", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtCaja.Load(reader);
                }
            }
            return dtCaja;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //esta solo cierra el forms que tiene enfrente pq el forms de Bancos esta atras
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        //No hace nada pq ya esta en ese forms
        private void button2_Click(object sender, EventArgs e)
        {
        }
        //Va a otro forms cerrando el actual
        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
            this.Dispose();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
            this.Dispose();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
            this.Dispose();

        }
    }
}
