using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmEditarCurso : Form
    {
        Curso cursoEditar;
        public FrmEditarCurso(Curso curso)
        {
            InitializeComponent();
            this.cursoEditar = curso;
        }

        private void FrmEditarCurso_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = cursoEditar.nombre;
            textBoxDescripcion.Text = cursoEditar.descripcion;
            textBoxCodigo.Text = cursoEditar.codigo;
            textBoxCupo.Text = cursoEditar.cupo.ToString();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
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
            else if (textBoxCodigo.Text != cursoEditar.codigo)
            {
                if (validador.ValidarCodigoCursoExistente(textBoxCodigo.Text))
                {
                    MostrarMensajeError("El codigo ingresado ya esta registrado");
                }
            }
            else if (textBoxCodigo.Text == cursoEditar.codigo)
            {
                if (ConfirmarEditadoCurso())
                {
                    AgregarNuevoCursoCodigoIgual(cursoEditar.codigo);
                }
            }
            else
            {
                if (ConfirmarEditadoCurso())
                {
                    AgregarNuevoCurso(cursoEditar.codigo);
                }
            }
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

        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ConfirmarEditadoCurso()
        {
            string message = "¿Confirmar la edicion del curso?";
            string title = "Editar Curso";
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        private void AgregarNuevoCurso(string codigo)
        {
            Curso.EditarCurso(codigo, textBoxNombre.Text, textBoxCodigo.Text, textBoxDescripcion.Text, int.Parse(textBoxCupo.Text));
            this.abrirGestionCursos();
        }

        private void AgregarNuevoCursoCodigoIgual(string codigo)
        {
            Curso.EditarCurso(codigo, textBoxNombre.Text, textBoxDescripcion.Text, int.Parse(textBoxCupo.Text));
            this.abrirGestionCursos();
        }


    }
}
