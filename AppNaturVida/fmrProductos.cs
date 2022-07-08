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
    public partial class fmrProductos : Form
    {
        public fmrProductos()
        {
            InitializeComponent();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarProd.Visible = true;
            panelConsultarProd.Visible = false;
            panelModificarProd.Visible = false;
            panelBorrarProd.Visible = false;

        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarProd.Visible = false;
            panelConsultarProd.Visible = true;
            panelModificarProd.Visible = false;
            panelBorrarProd.Visible = false;
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelModificarProd.Visible = true;
            panelInsertarProd.Visible = false;
            panelConsultarProd.Visible = false;
            panelBorrarProd.Visible = false;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarProd.Visible = false;
            panelConsultarProd.Visible = false;
            panelModificarProd.Visible = false;
            panelBorrarProd.Visible = true;
        }

        private void panelModificarProd_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
