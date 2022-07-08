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
    public partial class fmrClientes : Form
    {
        public fmrClientes()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarClien.Visible = true;
            panelConsultarClien.Visible = false;
            panelModificarClien.Visible = false;
            panelBorrarClien.Visible = false;
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarClien.Visible = false;
            panelConsultarClien.Visible = true;
            panelModificarClien.Visible = false;
            panelBorrarClien.Visible = false;
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarClien.Visible = false;
            panelConsultarClien.Visible = false;
            panelModificarClien.Visible = true;
            panelBorrarClien.Visible = false;
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInsertarClien.Visible = false;
            panelConsultarClien.Visible = false;
            panelModificarClien.Visible = false;
            panelBorrarClien.Visible = true;
        }
    }
}
