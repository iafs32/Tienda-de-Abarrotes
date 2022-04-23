using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Ver valores De Tabla de Datos (Generado automaticamente por VS desde Data Sources)
        private void bancosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDeAbarrotesDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.bancosTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Bancos);
        }

        //Ver Valor Total con un Boton
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtValorT.Text = bancosTableAdapter.GetValorTotal().ToString();
                                                //GetValorTotal es el nombre del metodo para sacar datos
        }

        //Botones para acceder a las demas cuentas
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
