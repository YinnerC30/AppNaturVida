namespace AppNaturVida
{
    partial class IniciarSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLogin = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.MensajeAlerta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLogin
            // 
            this.TitleLogin.AutoSize = true;
            this.TitleLogin.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLogin.ForeColor = System.Drawing.Color.Red;
            this.TitleLogin.Location = new System.Drawing.Point(56, 24);
            this.TitleLogin.Name = "TitleLogin";
            this.TitleLogin.Size = new System.Drawing.Size(370, 74);
            this.TitleLogin.TabIndex = 0;
            this.TitleLogin.Text = "Sistema de informaciòn\r\nTienda Naturista NaturVida";
            this.TitleLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUser
            // 
            this.txtUser.AutoSize = true;
            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUser.Location = new System.Drawing.Point(56, 122);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(83, 28);
            this.txtUser.TabIndex = 2;
            this.txtUser.Text = "Usuario:";
            this.txtUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoSize = true;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(25, 167);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(114, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "Contraseña:";
            this.txtPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(145, 127);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(273, 23);
            this.textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(145, 172);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(273, 23);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Red;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonLogin.Location = new System.Drawing.Point(188, 253);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 49);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Ingresar";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // MensajeAlerta
            // 
            this.MensajeAlerta.AutoSize = true;
            this.MensajeAlerta.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MensajeAlerta.ForeColor = System.Drawing.Color.Red;
            this.MensajeAlerta.Location = new System.Drawing.Point(87, 213);
            this.MensajeAlerta.Name = "MensajeAlerta";
            this.MensajeAlerta.Size = new System.Drawing.Size(298, 28);
            this.MensajeAlerta.TabIndex = 7;
            this.MensajeAlerta.Text = "Usuario o contraseña incorrectos";
            this.MensajeAlerta.Visible = false;
            this.MensajeAlerta.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 314);
            this.Controls.Add(this.MensajeAlerta);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.TitleLogin);
            this.Name = "IniciarSesion";
            this.Text = "Iniciar sesiòn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLogin;
        private Label txtUser;
        private Label txtPassword;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Label MensajeAlerta;
    }
}