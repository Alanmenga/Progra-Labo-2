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
            Estudiante.RecuperarEstudiantesDeArchivo();
            Estudiante.AgregarEstudiantesRecuperados();

            Administrador.RecuperarAdministradorDeArchivosJson();
            Administrador.AgregarAdministradoresRecuperados();

            Profesor.RecuperarProfesorDeArchivos();
            Profesor.AgregarProfesoresRecuperados();
            //Curso.RecuperarCursos();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            bool usuarioValido = Usuario.UsuarioExiste(textBoxUsuario.Text, textBoxContraseña.Text);
            if (usuarioValido)
            {
                if (Usuario.ObtenerRolUsuario(textBoxUsuario.Text) == Rol.administrador)
                {
                    FrmPanelAdmin frmPanelAdmin = new FrmPanelAdmin();
                    this.Hide();
                    frmPanelAdmin.Show();
                }
                else if (Usuario.ObtenerRolUsuario(textBoxUsuario.Text) == Rol.profesor)
                {
                    FrmPanelProfe formPanelProfe = new FrmPanelProfe();
                    this.Hide();
                    formPanelProfe.Show();
                }
                else
                {
                    FrmPanelEstud frmPanelEstud = new FrmPanelEstud();
                    this.Hide();
                    frmPanelEstud.Show();
                }

            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                textBoxUsuario.Clear();
                textBoxContraseña.Clear();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
        }

        private void buttonCompletarEstudiante_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "juanr";
            textBoxContraseña.Text = "prueba01";
        }

        private void buttonCompletarAdmin_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "admin1";
            textBoxContraseña.Text = "prueba01";
        }

        private void buttonProfesor_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = "profe1";
            textBoxContraseña.Text = "prueba01";
        }


        private void RecuperarAdministradores(string data)
        {
            List<Administrador> administradores = new List<Administrador>();
        }


    }
}