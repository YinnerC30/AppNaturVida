namespace AppNaturVida
{
    partial class fmrClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelModificarClien = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtProductoMod = new System.Windows.Forms.ComboBox();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.buttonConsultarMod = new System.Windows.Forms.Button();
            this.panelBorrarClien = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProdBorrar = new System.Windows.Forms.ComboBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.panelInsertarClien = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.panelConsultarClien = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProductoConsultar = new System.Windows.Forms.ComboBox();
            this.dataGridViewConsultarProd = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelModificarClien.SuspendLayout();
            this.panelBorrarClien.SuspendLayout();
            this.panelInsertarClien.SuspendLayout();
            this.panelConsultarClien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.panelModificarClien);
            this.groupBox1.Controls.Add(this.panelBorrarClien);
            this.groupBox1.Controls.Add(this.panelInsertarClien);
            this.groupBox1.Controls.Add(this.panelConsultarClien);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 364);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(485, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.ingresarClienteToolStripMenuItem.Text = "Ingresar Cliente";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // panelModificarClien
            // 
            this.panelModificarClien.Controls.Add(this.label6);
            this.panelModificarClien.Controls.Add(this.textBox6);
            this.panelModificarClien.Controls.Add(this.label7);
            this.panelModificarClien.Controls.Add(this.textBox7);
            this.panelModificarClien.Controls.Add(this.textBox8);
            this.panelModificarClien.Controls.Add(this.textBox9);
            this.panelModificarClien.Controls.Add(this.label8);
            this.panelModificarClien.Controls.Add(this.label10);
            this.panelModificarClien.Controls.Add(this.label17);
            this.panelModificarClien.Controls.Add(this.txtProductoMod);
            this.panelModificarClien.Controls.Add(this.buttonGuardarCambios);
            this.panelModificarClien.Controls.Add(this.buttonConsultarMod);
            this.panelModificarClien.Location = new System.Drawing.Point(15, 50);
            this.panelModificarClien.Name = "panelModificarClien";
            this.panelModificarClien.Size = new System.Drawing.Size(455, 286);
            this.panelModificarClien.TabIndex = 11;
            this.panelModificarClien.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Documento:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(107, 199);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(255, 23);
            this.textBox6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Correo:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(107, 157);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(255, 23);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(107, 123);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(255, 23);
            this.textBox8.TabIndex = 22;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(107, 89);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(255, 23);
            this.textBox9.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Telefono:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dirección:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 15);
            this.label17.TabIndex = 18;
            this.label17.Text = "Nombre:";
            // 
            // txtProductoMod
            // 
            this.txtProductoMod.FormattingEnabled = true;
            this.txtProductoMod.Location = new System.Drawing.Point(122, 20);
            this.txtProductoMod.Name = "txtProductoMod";
            this.txtProductoMod.Size = new System.Drawing.Size(300, 23);
            this.txtProductoMod.TabIndex = 17;
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.BackColor = System.Drawing.Color.Red;
            this.buttonGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarCambios.Location = new System.Drawing.Point(141, 241);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(173, 23);
            this.buttonGuardarCambios.TabIndex = 15;
            this.buttonGuardarCambios.Text = "Guardar Cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // buttonConsultarMod
            // 
            this.buttonConsultarMod.BackColor = System.Drawing.Color.Red;
            this.buttonConsultarMod.ForeColor = System.Drawing.Color.White;
            this.buttonConsultarMod.Location = new System.Drawing.Point(178, 49);
            this.buttonConsultarMod.Name = "buttonConsultarMod";
            this.buttonConsultarMod.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultarMod.TabIndex = 8;
            this.buttonConsultarMod.Text = "Consultar";
            this.buttonConsultarMod.UseVisualStyleBackColor = false;
            // 
            // panelBorrarClien
            // 
            this.panelBorrarClien.Controls.Add(this.label9);
            this.panelBorrarClien.Controls.Add(this.txtProdBorrar);
            this.panelBorrarClien.Controls.Add(this.buttonEliminar);
            this.panelBorrarClien.Location = new System.Drawing.Point(15, 50);
            this.panelBorrarClien.Name = "panelBorrarClien";
            this.panelBorrarClien.Size = new System.Drawing.Size(455, 261);
            this.panelBorrarClien.TabIndex = 11;
            this.panelBorrarClien.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Documento:";
            // 
            // txtProdBorrar
            // 
            this.txtProdBorrar.FormattingEnabled = true;
            this.txtProdBorrar.Location = new System.Drawing.Point(133, 20);
            this.txtProdBorrar.Name = "txtProdBorrar";
            this.txtProdBorrar.Size = new System.Drawing.Size(285, 23);
            this.txtProdBorrar.TabIndex = 9;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEliminar.Location = new System.Drawing.Point(179, 58);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // panelInsertarClien
            // 
            this.panelInsertarClien.Controls.Add(this.textBox1);
            this.panelInsertarClien.Controls.Add(this.label1);
            this.panelInsertarClien.Controls.Add(this.txtCantidad);
            this.panelInsertarClien.Controls.Add(this.txtValor);
            this.panelInsertarClien.Controls.Add(this.txtDescripcion);
            this.panelInsertarClien.Controls.Add(this.txtCodigo);
            this.panelInsertarClien.Controls.Add(this.label5);
            this.panelInsertarClien.Controls.Add(this.label4);
            this.panelInsertarClien.Controls.Add(this.label3);
            this.panelInsertarClien.Controls.Add(this.label2);
            this.panelInsertarClien.Controls.Add(this.buttonLimpiar);
            this.panelInsertarClien.Controls.Add(this.buttonGuardar);
            this.panelInsertarClien.Location = new System.Drawing.Point(15, 50);
            this.panelInsertarClien.Name = "panelInsertarClien";
            this.panelInsertarClien.Size = new System.Drawing.Size(455, 261);
            this.panelInsertarClien.TabIndex = 1;
            this.panelInsertarClien.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 169);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 23);
            this.textBox1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Correo:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(102, 127);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(255, 23);
            this.txtCantidad.TabIndex = 7;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(102, 93);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(255, 23);
            this.txtValor.TabIndex = 6;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(102, 59);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(255, 23);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(102, 20);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(255, 23);
            this.txtCodigo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Documento:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Red;
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Location = new System.Drawing.Point(239, 221);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.Red;
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(122, 221);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // panelConsultarClien
            // 
            this.panelConsultarClien.Controls.Add(this.label11);
            this.panelConsultarClien.Controls.Add(this.txtProductoConsultar);
            this.panelConsultarClien.Controls.Add(this.dataGridViewConsultarProd);
            this.panelConsultarClien.Controls.Add(this.buttonConsultar);
            this.panelConsultarClien.Location = new System.Drawing.Point(15, 50);
            this.panelConsultarClien.Name = "panelConsultarClien";
            this.panelConsultarClien.Size = new System.Drawing.Size(455, 261);
            this.panelConsultarClien.TabIndex = 10;
            this.panelConsultarClien.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Documento:";
            // 
            // txtProductoConsultar
            // 
            this.txtProductoConsultar.FormattingEnabled = true;
            this.txtProductoConsultar.Location = new System.Drawing.Point(132, 20);
            this.txtProductoConsultar.Name = "txtProductoConsultar";
            this.txtProductoConsultar.Size = new System.Drawing.Size(290, 23);
            this.txtProductoConsultar.TabIndex = 10;
            // 
            // dataGridViewConsultarProd
            // 
            this.dataGridViewConsultarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultarProd.Location = new System.Drawing.Point(21, 99);
            this.dataGridViewConsultarProd.Name = "dataGridViewConsultarProd";
            this.dataGridViewConsultarProd.RowTemplate.Height = 25;
            this.dataGridViewConsultarProd.Size = new System.Drawing.Size(412, 132);
            this.dataGridViewConsultarProd.TabIndex = 9;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.Red;
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Location = new System.Drawing.Point(179, 58);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 8;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(132, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(263, 37);
            this.label16.TabIndex = 2;
            this.label16.Text = "Gestión de Clientes";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // fmrClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Name = "fmrClientes";
            this.Text = "Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelModificarClien.ResumeLayout(false);
            this.panelModificarClien.PerformLayout();
            this.panelBorrarClien.ResumeLayout(false);
            this.panelBorrarClien.PerformLayout();
            this.panelInsertarClien.ResumeLayout(false);
            this.panelInsertarClien.PerformLayout();
            this.panelConsultarClien.ResumeLayout(false);
            this.panelConsultarClien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private ToolStripMenuItem consultarClienteToolStripMenuItem;
        private ToolStripMenuItem modificarClienteToolStripMenuItem;
        private ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private Panel panelConsultarClien;
        private ComboBox txtProductoConsultar;
        private DataGridView dataGridViewConsultarProd;
        private Button buttonConsultar;
        private Panel panelBorrarClien;
        private ComboBox txtProdBorrar;
        private Button buttonEliminar;
        private Panel panelInsertarClien;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button buttonLimpiar;
        private Button buttonGuardar;
        private Panel panelModificarClien;
        private ComboBox txtProductoMod;
        private Button buttonGuardarCambios;
        private Button buttonConsultarMod;
        private Label label16;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label8;
        private Label label10;
        private Label label17;
        private TextBox textBox1;
        private Label label1;
        private Label label6;
        private Label label11;
        private Label label9;
    }
}