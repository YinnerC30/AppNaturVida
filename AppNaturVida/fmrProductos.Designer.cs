namespace AppNaturVida
{
    partial class fmrProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelBorrarProd = new System.Windows.Forms.Panel();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelInsertarProd = new System.Windows.Forms.Panel();
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
            this.panelModificarProd = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.txtValorMod = new System.Windows.Forms.TextBox();
            this.txtDescripcionMod = new System.Windows.Forms.TextBox();
            this.txtCodigoMod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonConsultarMod = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panelConsultarProd = new System.Windows.Forms.Panel();
            this.dataGridViewConsultarProd = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProdBorrar = new System.Windows.Forms.ComboBox();
            this.txtProductoMod = new System.Windows.Forms.ComboBox();
            this.txtProductoConsultar = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panelBorrarProd.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelInsertarProd.SuspendLayout();
            this.panelModificarProd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelConsultarProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestión Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.panelConsultarProd);
            this.groupBox1.Controls.Add(this.panelBorrarProd);
            this.groupBox1.Controls.Add(this.panelInsertarProd);
            this.groupBox1.Controls.Add(this.panelModificarProd);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 354);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // panelBorrarProd
            // 
            this.panelBorrarProd.Controls.Add(this.txtProdBorrar);
            this.panelBorrarProd.Controls.Add(this.buttonEliminar);
            this.panelBorrarProd.Controls.Add(this.label15);
            this.panelBorrarProd.Location = new System.Drawing.Point(21, 57);
            this.panelBorrarProd.Name = "panelBorrarProd";
            this.panelBorrarProd.Size = new System.Drawing.Size(455, 261);
            this.panelBorrarProd.TabIndex = 11;
            this.panelBorrarProd.Visible = false;
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(57, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Producto:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.modificarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar Producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // modificarProductoToolStripMenuItem
            // 
            this.modificarProductoToolStripMenuItem.Name = "modificarProductoToolStripMenuItem";
            this.modificarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.modificarProductoToolStripMenuItem.Text = "Modificar Producto";
            this.modificarProductoToolStripMenuItem.Click += new System.EventHandler(this.modificarProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar Producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // panelInsertarProd
            // 
            this.panelInsertarProd.Controls.Add(this.txtCantidad);
            this.panelInsertarProd.Controls.Add(this.txtValor);
            this.panelInsertarProd.Controls.Add(this.txtDescripcion);
            this.panelInsertarProd.Controls.Add(this.txtCodigo);
            this.panelInsertarProd.Controls.Add(this.label5);
            this.panelInsertarProd.Controls.Add(this.label4);
            this.panelInsertarProd.Controls.Add(this.label3);
            this.panelInsertarProd.Controls.Add(this.label2);
            this.panelInsertarProd.Controls.Add(this.buttonLimpiar);
            this.panelInsertarProd.Controls.Add(this.buttonGuardar);
            this.panelInsertarProd.Location = new System.Drawing.Point(21, 57);
            this.panelInsertarProd.Name = "panelInsertarProd";
            this.panelInsertarProd.Size = new System.Drawing.Size(455, 261);
            this.panelInsertarProd.TabIndex = 1;
            this.panelInsertarProd.Visible = false;
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
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.Red;
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Location = new System.Drawing.Point(219, 178);
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
            this.buttonGuardar.Location = new System.Drawing.Point(102, 178);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // panelModificarProd
            // 
            this.panelModificarProd.Controls.Add(this.txtProductoMod);
            this.panelModificarProd.Controls.Add(this.panel1);
            this.panelModificarProd.Controls.Add(this.buttonGuardarCambios);
            this.panelModificarProd.Controls.Add(this.txtValorMod);
            this.panelModificarProd.Controls.Add(this.txtDescripcionMod);
            this.panelModificarProd.Controls.Add(this.txtCodigoMod);
            this.panelModificarProd.Controls.Add(this.label10);
            this.panelModificarProd.Controls.Add(this.label8);
            this.panelModificarProd.Controls.Add(this.label7);
            this.panelModificarProd.Controls.Add(this.buttonConsultarMod);
            this.panelModificarProd.Controls.Add(this.label6);
            this.panelModificarProd.Location = new System.Drawing.Point(21, 57);
            this.panelModificarProd.Name = "panelModificarProd";
            this.panelModificarProd.Size = new System.Drawing.Size(455, 261);
            this.panelModificarProd.TabIndex = 11;
            this.panelModificarProd.Visible = false;
            this.panelModificarProd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelModificarProd_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Location = new System.Drawing.Point(132, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 261);
            this.panel1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(132, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(258, 23);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(258, 23);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 113);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(258, 23);
            this.textBox4.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Descripción:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 186);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 15);
            this.label12.TabIndex = 10;
            this.label12.Text = "Valor:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Código:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(179, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(140, 20);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(255, 23);
            this.textBox5.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Producto:";
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.BackColor = System.Drawing.Color.Red;
            this.buttonGuardarCambios.ForeColor = System.Drawing.Color.White;
            this.buttonGuardarCambios.Location = new System.Drawing.Point(132, 215);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(173, 23);
            this.buttonGuardarCambios.TabIndex = 15;
            this.buttonGuardarCambios.Text = "Guardar Cambios";
            this.buttonGuardarCambios.UseVisualStyleBackColor = false;
            // 
            // txtValorMod
            // 
            this.txtValorMod.Location = new System.Drawing.Point(99, 186);
            this.txtValorMod.Name = "txtValorMod";
            this.txtValorMod.Size = new System.Drawing.Size(258, 23);
            this.txtValorMod.TabIndex = 14;
            // 
            // txtDescripcionMod
            // 
            this.txtDescripcionMod.Location = new System.Drawing.Point(99, 149);
            this.txtDescripcionMod.Name = "txtDescripcionMod";
            this.txtDescripcionMod.Size = new System.Drawing.Size(258, 23);
            this.txtDescripcionMod.TabIndex = 13;
            // 
            // txtCodigoMod
            // 
            this.txtCodigoMod.Location = new System.Drawing.Point(99, 113);
            this.txtCodigoMod.Name = "txtCodigoMod";
            this.txtCodigoMod.Size = new System.Drawing.Size(258, 23);
            this.txtCodigoMod.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Descripción:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Código:";
            // 
            // buttonConsultarMod
            // 
            this.buttonConsultarMod.BackColor = System.Drawing.Color.Red;
            this.buttonConsultarMod.ForeColor = System.Drawing.Color.White;
            this.buttonConsultarMod.Location = new System.Drawing.Point(179, 58);
            this.buttonConsultarMod.Name = "buttonConsultarMod";
            this.buttonConsultarMod.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultarMod.TabIndex = 8;
            this.buttonConsultarMod.Text = "Consultar";
            this.buttonConsultarMod.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto:";
            // 
            // panelConsultarProd
            // 
            this.panelConsultarProd.Controls.Add(this.txtProductoConsultar);
            this.panelConsultarProd.Controls.Add(this.dataGridViewConsultarProd);
            this.panelConsultarProd.Controls.Add(this.buttonConsultar);
            this.panelConsultarProd.Controls.Add(this.label9);
            this.panelConsultarProd.Location = new System.Drawing.Point(21, 57);
            this.panelConsultarProd.Name = "panelConsultarProd";
            this.panelConsultarProd.Size = new System.Drawing.Size(455, 261);
            this.panelConsultarProd.TabIndex = 10;
            this.panelConsultarProd.Visible = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Producto:";
            // 
            // txtProdBorrar
            // 
            this.txtProdBorrar.FormattingEnabled = true;
            this.txtProdBorrar.Location = new System.Drawing.Point(133, 20);
            this.txtProdBorrar.Name = "txtProdBorrar";
            this.txtProdBorrar.Size = new System.Drawing.Size(285, 23);
            this.txtProdBorrar.TabIndex = 9;
            // 
            // txtProductoMod
            // 
            this.txtProductoMod.FormattingEnabled = true;
            this.txtProductoMod.Location = new System.Drawing.Point(122, 20);
            this.txtProductoMod.Name = "txtProductoMod";
            this.txtProductoMod.Size = new System.Drawing.Size(300, 23);
            this.txtProductoMod.TabIndex = 17;
            // 
            // txtProductoConsultar
            // 
            this.txtProductoConsultar.FormattingEnabled = true;
            this.txtProductoConsultar.Location = new System.Drawing.Point(132, 20);
            this.txtProductoConsultar.Name = "txtProductoConsultar";
            this.txtProductoConsultar.Size = new System.Drawing.Size(290, 23);
            this.txtProductoConsultar.TabIndex = 10;
            // 
            // fmrProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrProductos";
            this.Text = "Productos NaturVida";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelBorrarProd.ResumeLayout(false);
            this.panelBorrarProd.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelInsertarProd.ResumeLayout(false);
            this.panelInsertarProd.PerformLayout();
            this.panelModificarProd.ResumeLayout(false);
            this.panelModificarProd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelConsultarProd.ResumeLayout(false);
            this.panelConsultarProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Panel panelInsertarProd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private ToolStripMenuItem consultarProductoToolStripMenuItem;
        private ToolStripMenuItem modificarProductoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private Button buttonLimpiar;
        private Button buttonGuardar;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private TextBox txtDescripcion;
        private TextBox txtCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panelConsultarProd;
        private Button buttonConsultar;
        private Label label9;
        private Panel panelModificarProd;
        private Button buttonGuardarCambios;
        private TextBox txtValorMod;
        private TextBox txtDescripcionMod;
        private TextBox txtCodigoMod;
        private Label label10;
        private Label label8;
        private Label label7;
        private Button buttonConsultarMod;
        private Label label6;
        private Panel panelBorrarProd;
        private Button buttonEliminar;
        private Label label15;
        private Panel panel1;
        private DataGridView dataGridViewConsultarProd;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button2;
        private TextBox textBox5;
        private Label label14;
        private ComboBox txtProductoConsultar;
        private ComboBox txtProdBorrar;
        private ComboBox txtProductoMod;
    }
}