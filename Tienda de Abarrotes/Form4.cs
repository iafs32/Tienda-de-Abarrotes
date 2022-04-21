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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void CajaDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ComprasDGV.DataSource = ObtenerComprasTabla();
        }

        private DataTable ObtenerComprasTabla()
        {
            DataTable dtCompras = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Compras", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtCompras.Load(reader);
                }
            }
            return dtCompras;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
            this.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
            this.Dispose();

        }

        private void button4_Click(object sender, EventArgs e)
        {
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
