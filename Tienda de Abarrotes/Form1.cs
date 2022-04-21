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
//En App.config se agrego esta linea
//<add name ="dbx" connectionString="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\GAT_L\Desktop\Abarrotes\Tienda-de-Abarrotes\tiendaDeAbarrotes.accdb" providerName="System.Data.OleDb" />
namespace Tienda_de_Abarrotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BancoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //cargar Base de Datos
        private void Form1_Load(object sender, EventArgs e)
        {
            BancoDGV.DataSource = ObtenerBancoTabla();
        }
        //Funcion para cargar base de Datos
        private DataTable ObtenerBancoTabla()
        {
            DataTable dtBanco = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Bancos", con))
                {
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    dtBanco.Load(reader);
                }
            }
                return dtBanco;
        }

        //Botones
        //El Boton 1 no tiene nda debido a que ya esta en esa ventana
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formulario = new Form3();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form formulario = new Form4();
            formulario.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form formulario = new Form5();
            formulario.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form formulario = new Form6();
            formulario.Show();
        }
    }
}
