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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void cajaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cajaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tiendaDeAbarrotesDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tiendaDeAbarrotesDataSet.Caja' table. You can move, or remove it, as needed.
            this.cajaTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Caja);

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtValorT.Text = cajaTableAdapter.GetValorTotal().ToString();
        }

        private void cajaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Botones
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            Form formulario = new Form6();
            formulario.Show();
            this.Dispose();
        }
    }
}
