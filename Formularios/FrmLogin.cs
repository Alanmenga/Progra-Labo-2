using Biblioteca;

namespace Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioValido = Usuario.UsuarioExiste(textBoxUsuario.Text, textBoxContrase�a.Text);
            if (usuarioValido)
            {
                if(Usuario.ObtenerRolUsuario(textBoxUsuario.Text) == Rol.administrador)
                {
                    FrmPanelAdmin frmPanelAdmin = new FrmPanelAdmin();
                    this.Hide();
                    frmPanelAdmin.Show();
                    //MessageBox.Show("EL usuario es administrador");
                }
                else
                {
                    FrmPanelEstud frmPanelEstud = new FrmPanelEstud();
                    this.Hide();
                    frmPanelEstud.Show();
                    //MessageBox.Show("EL usuario es alumno");
                }

            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                textBoxUsuario.Clear();
                textBoxContrase�a.Clear();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Clear();
            textBoxContrase�a.Clear();
        }
    }
}