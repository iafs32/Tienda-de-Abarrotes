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
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Compras);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Caja' Puede moverla o quitarla según sea necesario.
            this.cajaTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Caja);
            // TODO: esta línea de código carga datos en la tabla 'tiendaDeAbarrotesDataSet.Bancos' Puede moverla o quitarla según sea necesario.
            this.bancosTableAdapter.Fill(this.tiendaDeAbarrotesDataSet.Bancos);

            lblCuenta.Text = "Caja: $" + ;

        }
    }
}
