using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmAgregarCurso : Form
    {
        public FrmAgregarCurso()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Validaciones validador = new Validaciones();
            if (!ValidadorCamposVacios())
            {
                MostrarMensajeError("Los campos no tiene que estar vacios!");
            }
            else if (validador.ValidarNombreCursoExistente(textBoxNombre.Text))
            {
                MostrarMensajeError("El nombre ingresado ya esta registrado");
            }
            else if (validador.ValidarCodigoCursoExistente(textBoxCodigo.Text))
            {
                MostrarMensajeError("El codigo ingresado ya esta registrado");
            }
            else
            {
                if (ConfirmarAgregadoCurso())
                {
                    AgregarNuevoCurso();
                }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            textBoxCodigo.Clear();
            textBoxCupo.Clear();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.abrirGestionCursos();
        }


        private void abrirGestionCursos()
        {
            FrmGestionarCursos frmGestionarCursos = new FrmGestionarCursos();
            this.Close();
            frmGestionarCursos.Show();
        }

        private bool ValidadorCamposVacios()
        {
            string nombre = textBoxNombre.Text.Trim();
            string descripcion = textBoxDescripcion.Text.Trim();
            string codigo = textBoxCodigo.Text.Trim();
            string cupo = textBoxCupo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) ||
               string.IsNullOrWhiteSpace(descripcion) ||
               string.IsNullOrWhiteSpace(codigo) ||
               string.IsNullOrWhiteSpace(cupo))
            {
                return false;
            }
            return true;
        }

        private void textBoxCupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un dígito (0-9) o una tecla de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Cancela la tecla presionada si no es un dígito o una tecla de control
                e.Handled = true;
            }
        }

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ConfirmarAgregadoCurso()
        {
            string message = "¿Confirmar el agregado del curso?";
            string title = "Agregar Curso";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void AgregarNuevoCurso()
        {
            Curso.AgregarCurso(textBoxNombre.Text, textBoxCodigo.Text, textBoxDescripcion.Text, int.Parse(textBoxCupo.Text));
            this.abrirGestionCursos();
        }
    }
}
