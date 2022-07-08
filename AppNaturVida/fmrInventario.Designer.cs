namespace AppNaturVida
{
    partial class fmrInventario
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
            this.txtProductoConsultar = new System.Windows.Forms.ComboBox();
            this.dataGridViewConsultarProd = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarProd)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProductoConsultar
            // 
            this.txtProductoConsultar.FormattingEnabled = true;
            this.txtProductoConsultar.Location = new System.Drawing.Point(153, 70);
            this.txtProductoConsultar.Name = "txtProductoConsultar";
            this.txtProductoConsultar.Size = new System.Drawing.Size(290, 23);
            this.txtProductoConsultar.TabIndex = 14;
            // 
            // dataGridViewConsultarProd
            // 
            this.dataGridViewConsultarProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultarProd.Location = new System.Drawing.Point(52, 168);
            this.dataGridViewConsultarProd.Name = "dataGridViewConsultarProd";
            this.dataGridViewConsultarProd.RowTemplate.Height = 25;
            this.dataGridViewConsultarProd.Size = new System.Drawing.Size(412, 132);
            this.dataGridViewConsultarProd.TabIndex = 13;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.BackColor = System.Drawing.Color.Red;
            this.buttonConsultar.ForeColor = System.Drawing.Color.White;
            this.buttonConsultar.Location = new System.Drawing.Point(220, 112);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 12;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Facturación";
            // 
            // fmrInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 359);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProductoConsultar);
            this.Controls.Add(this.dataGridViewConsultarProd);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.label9);
            this.Name = "fmrInventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultarProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox txtProductoConsultar;
        private DataGridView dataGridViewConsultarProd;
        private Button buttonConsultar;
        private Label label9;
        private Label label2;
    }
}