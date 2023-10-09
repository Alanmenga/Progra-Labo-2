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
    public partial class FrmInscCurso : Form
    {
        public FrmInscCurso()
        {
            InitializeComponent();
        }

        private void FrmInscCurso_Load(object sender, EventArgs e)
        {
            MostrarCursos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPanelEstud frmPanelEstud = new FrmPanelEstud();
            this.Close();
            frmPanelEstud.Show();
        }

        private void buttonInscribir_Click(object sender, EventArgs e)
        {
            if(checkedListBoxCursos.CheckedItems.Count == 0 )
            {
                MessageBox.Show($"No se seleciono ningun curso!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult result = MessageBox.Show($"¿Desea inscribirse en el/los cursos?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    List<string> listaCodigoCursosAgregar = new List<string>();
                    listaCodigoCursosAgregar = this.RecuperarCodigoSelecionado();
                    foreach (string codigo in listaCodigoCursosAgregar)
                    {
                        Curso curso;
                        curso = Curso.RecuperarCursoConCodigo(codigo);
                        Estudiante.AgregarCursoEstudiante(curso);
                    }
                    MessageBox.Show($"Inscripcion exitosa!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCheckedList();
                }
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCheckedList();
        }

        private void LimpiarCheckedList()
        {
            for (int i = 0; i < checkedListBoxCursos.Items.Count; i++)
            {
                checkedListBoxCursos.SetItemChecked(i, false);
            }
        }

        private void MostrarCursos()
        {
            foreach (Curso curso in Curso.listaCursos)
            {
                string nombre = curso.nombre;
                string codigo = curso.codigo;
                string descripcion = curso.descripcion;
                string cupo = curso.cupo.ToString();

                checkedListBoxCursos.Items.Add($"{codigo} --> {nombre} --> {descripcion} --> {cupo} ");
            }
        }

        private List<string> RecuperarCursoSelecionado()
        {
            List<string> listaCursoSelecionado = new List<string>();
            foreach (var item in checkedListBoxCursos.CheckedItems)
            {
                listaCursoSelecionado.Add(item.ToString());
            }
            return listaCursoSelecionado;
        }

        public List<string> RecuperarCodigoSelecionado()
        {
            List<string> listaCodigosAgregar = new List<string>();
            List<string> listaCursoSelecionado = new List<string>();
            listaCursoSelecionado =  RecuperarCursoSelecionado();
            string dataCurso;
            for (int i = 0; i < listaCursoSelecionado.Count; i++)
            {
                dataCurso = listaCursoSelecionado[i].ToString();
                string[] partes = dataCurso.Split(new string[] { "-->" }, StringSplitOptions.RemoveEmptyEntries);
                if (partes.Length >= 4)
                {
                    string codigo = partes[0].Trim();
                    listaCodigosAgregar.Add(codigo);
                }
            }
            return listaCodigosAgregar;
        }
    }
}
