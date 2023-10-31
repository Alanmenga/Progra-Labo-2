using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmRegistEstud : Form
    {
        public FrmRegistEstud()
        {
            InitializeComponent();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.abrirPanel();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Validaciones validador = new Validaciones();
            if (!ValidadorCamposVacios())
            {
                MostrarMensajeError("Los campos no tiene que estar vacios!");
            }
            else if (validador.ValidarDniEstudianteExistente(int.Parse(textBoxDni.Text)))
            {
                MostrarMensajeError("El dni ingresado ya esta registrado");
            }
            else if (validador.ValidarCorreoEstudianteExistente(textBoxCorreo.Text))
            {
                MostrarMensajeError("El correo ingresado ya esta registrado");
            }
            else if (validador.ValidarUsuarioExistente(textBoxUsuario.Text))
            {
                MostrarMensajeError("El usuario ingresado ya esta registrado.");
            }
            else
            {
                if (ConfirmarAgregadoEstudiante())
                {
                    AgregarNuevoEstudiante();
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDni.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            textBoxUsuario.Clear();
            textBoxContraseña.Clear();
            checkBoxCambiarContra.Checked = false;
        }

        private bool ValidadorCamposVacios()
        {
            string nombre = textBoxNombre.Text.Trim();
            string apellido = textBoxApellido.Text.Trim();
            string dni = textBoxDni.Text.Trim();
            string direccion = textBoxDireccion.Text.Trim();
            string telefono = textBoxTelefono.Text.Trim();
            string correo = textBoxCorreo.Text.Trim();
            string usuario = textBoxUsuario.Text.Trim();
            string contraseña = textBoxContraseña.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
               string.IsNullOrWhiteSpace(apellido) ||
               string.IsNullOrWhiteSpace(dni) ||
               string.IsNullOrWhiteSpace(direccion) ||
               string.IsNullOrWhiteSpace(telefono) ||
               string.IsNullOrWhiteSpace(correo) ||
               string.IsNullOrWhiteSpace(usuario) ||
               string.IsNullOrWhiteSpace(contraseña))
            {
                return false;
            }
            return true;
        }

        private void abrirPanel()
        {
            FrmPanelAdmin frmPanel = new FrmPanelAdmin();
            this.Close();
            frmPanel.Show();
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito (0-9) o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la tecla presionada si no es un dígito o una tecla de control
                e.Handled = true;
            }
        }

        private void textBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito (0-9) o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la tecla presionada si no es un dígito o una tecla de control
                e.Handled = true;
            }
        }

        private void AgregarNuevoEstudiante()
        {
            Email mail = new Email();
            Hash hash = new Hash();
            string contraseñaHasheada = hash.GetHash(textBoxContraseña.Text);

            Estudiante nuevoEstudiante = new Estudiante(textBoxUsuario.Text,textBoxApellido.Text,Rol.estudiante,textBoxNombre.Text,textBoxApellido.Text,int.Parse(textBoxDni.Text),textBoxDireccion.Text,int.Parse(textBoxTelefono.Text),textBoxCorreo.Text,checkBoxCambiarContra.Checked);
            Estudiante.AgregarEstudiante(nuevoEstudiante);

            //mail.SendEmail(textBoxCorreo.Text, "HOLA HOLA HOLA", "ESTO FUNCIONARÁ??????");
            this.abrirPanel();
        }

        private bool ConfirmarAgregadoEstudiante()
        {
            string message = "¿Confirmar el agregado del estudiante?";
            string title = "Agregar Estudiante";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
