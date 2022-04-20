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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInventario frmInventario = new frmInventario();
            frmInventario.Show();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMovimientos frmMovimientos = new frmMovimientos();
            frmMovimientos.Show();
        }
    }
}
