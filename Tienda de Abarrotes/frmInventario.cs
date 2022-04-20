using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tienda_de_Abarrotes
{
    public partial class frmInventario : Form
    {
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Inventario);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.inventarioTableAdapter.Buscar(tiendaDeAbarrotesDataSet.Inventario, txbNombre.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = int.Parse(txbPrecio.Text) * int.Parse(txbPiezas.Text);
            this.inventarioTableAdapter.Insertar(txbNombre.Text, int.Parse(txbPiezas.Text), decimal.Parse(txbPrecio.Text), a);
            this.inventarioTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Inventario);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = int.Parse(txbPiezas.Text) * int.Parse(txbPrecio.Text);
            this.inventarioTableAdapter.Modificar(txbNombre.Text, int.Parse(txbPiezas.Text), decimal.Parse(txbPrecio.Text), a, txbNombre.Text);
            this.inventarioTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Inventario);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.inventarioTableAdapter.Borrar(txbNombre.Text);
            this.inventarioTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Inventario);
        }
    }
}
