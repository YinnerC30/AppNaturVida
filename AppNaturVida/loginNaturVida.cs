namespace AppNaturVida
{
    public partial class IniciarSesion : Form
    {
        String _usser = "yinner";
        String _password = "300411";
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text==_usser && textBoxPassword.Text==_password) {
                MensajeAlerta.Visible = false;
                MDImenu menu = new MDImenu();
                menu.ShowDialog();
            }
            
            else {
                MensajeAlerta.Visible = true;
            }

        }
    }
}