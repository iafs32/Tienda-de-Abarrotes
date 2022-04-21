using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTienda
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Compras);
            LblFecha.Text = DateTime.Now.ToLongDateString();
            Lbl1.Text = " ";
            Lbl2.Text = " ";
            Lbl4.Text = " ";
            
        }
        
           

        private void CBProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnTtl_Click(object sender, EventArgs e)
        {
            if (TxtValor.Text == ""||TxtPiezas.Text=="") { MessageBox.Show("Porfavor llene los datos"); }
            double Val = Convert.ToDouble(TxtValor.Text);
            double Pza = Convert.ToDouble(TxtPiezas.Text);
            double Total = Val * Pza;
            Lbl4.Text = Total.ToString();
            Lbl2.Text = "la compra de hoy  " + TxtProducto.Text +" $ "+ Total;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LblFecha_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnAc_Click(object sender, EventArgs e)
        {
           // if (TxtUnidades.Text == "") { MessageBox.Show("Porfavor actualice las unidades"); }
            //int Uni = Convert.ToInt32(TxtUnidades.Text);
            //this.inventarioTableAdapter.Modificar(Uni, Uni);
            this.inventarioTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Inventario);
            this.comprasTableAdapter.Insertar(Convert.ToDateTime(LblFecha.Text), Convert.ToDecimal(Lbl4.Text));
            this.comprasTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Compras);
            
            
        }

        private void TxtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        

       
    }
}
