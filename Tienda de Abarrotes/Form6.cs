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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void CajaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            VentasDGV.DataSource = ObtenerVentasTabla();
        }
        private DataTable ObtenerVentasTabla()
        {
            DataTable dtVentas = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Ventas", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtVentas.Load(reader);
                }
            }
            return dtVentas;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Form formulario = new Form1();
            formulario.Show();
            this.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            this.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
            this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
            this.Dispose();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
            this.Dispose();

        }

        private void button6_Click(object sender, EventArgs e)
        {
        }
    }
}
