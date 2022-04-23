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

            dgvCuentas.DataSource = this.cajaBindingSource;
            lblCuenta.Text = "Caja: $" + this.cajaTableAdapter.SumaValor().ToString();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            dgvCuentas.DataSource = this.cajaBindingSource;
            lblCuenta.Text = "Caja: $" + this.cajaTableAdapter.SumaValor().ToString();
        }

        private void btnBancos_Click(object sender, EventArgs e)
        {
            dgvCuentas.DataSource = this.bancosBindingSource;
            lblCuenta.Text = "Bancos: $" + this.bancosTableAdapter.SumaValor().ToString();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            dgvCuentas.DataSource = this.ventasBindingSource;
            lblCuenta.Text = "Ventas: $" + this.ventasTableAdapter.SumaValor().ToString();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            dgvCuentas.DataSource = this.comprasBindingSource;
            lblCuenta.Text = "Compras: $" + this.comprasTableAdapter.SumaValor().ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();
        }
    }
}
