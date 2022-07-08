using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppNaturVida
{
    public partial class MDImenu : Form
    {
        public MDImenu()
        {
            InitializeComponent();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrFactura facturar = new fmrFactura();
            facturar.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrProductos productos = new fmrProductos();
            productos.ShowDialog();
        }

        private void menúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrClientes clientes = new fmrClientes();
            clientes.ShowDialog();

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrInventario inventario = new fmrInventario();
            inventario.ShowDialog();
        }
    }
}
