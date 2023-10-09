using Biblioteca;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            Administrador.RecuperarAdministrador();
            Estudiante.RecuperarEstudiantes();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioValido = Usuario.UsuarioExiste(textBoxUsuario.Text, textBoxContrase�a.Text);
            if (usuarioValido)
            {
                if (Usuario.ObtenerRolUsuario(textBoxUsuario.Text) == Rol.administrador)
                {
                    //new Sesion(textBoxUsuario.Text, DateTime.Now);
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

        private void buttonCompletarEstudiante_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "juanr";
            textBoxContrase�a.Text = "prueba01";
        }

        private void buttonCompletarAdmin_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "admin1";
            textBoxContrase�a.Text = "prueba01";
        }


        private void RecuperarAdministradores(string data)
        {
            List<Administrador> administradores = new List<Administrador>();
        }
        



    }
}