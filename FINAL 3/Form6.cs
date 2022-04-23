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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDeAbarrotesDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiendaDeAbarrotesDataSet.Ventas' table. You can move, or remove it, as needed.
            this.ventasTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Ventas);

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtValorT.Text = ventasTableAdapter.GetValorTotal().ToString();
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

        }





    }
}
