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
    public partial class FrmGestionarCursos : Form
    {
        public FrmGestionarCursos()
        {
            InitializeComponent();
        }

        private void FrmGestionarCursos_Load(object sender, EventArgs e)
        {
            this.MostrarCursos();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPanelAdmin frmPanelAdmin = new FrmPanelAdmin();
            this.Close();
            frmPanelAdmin.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCurso frmAgregarCurso = new FrmAgregarCurso();
            this.Close();
            frmAgregarCurso.Show();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string codigoSelecionado = RecuperarCodigoSelecionado();
            if (codigoSelecionado != null)
            {
                DialogResult result = MessageBox.Show($"¿Desea eliminar el curso?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
                if (result == DialogResult.OK)
                {
                    Curso.EliminarCurso(codigoSelecionado);
                    EliminarItemListBox();
                }
            }
            else
            {
                MessageBox.Show($"No se seleciono ningun curso!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string codigoSelecionado = RecuperarCodigoSelecionado();
            if (codigoSelecionado != null)
            {
                Curso cursoElegido = Curso.RecuperarCursoConCodigo(codigoSelecionado);
                FrmEditarCurso frmEditarCurso = new FrmEditarCurso(cursoElegido);
                this.Close();
                frmEditarCurso.Show();
            }
            else
            {
                MessageBox.Show($"No se seleciono ningun curso!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void EliminarItemListBox()
        {
            if (listBoxCursos.SelectedIndex >= 0)
            {
                // Elimina el elemento seleccionado del ListBox
                listBoxCursos.Items.RemoveAt(listBoxCursos.SelectedIndex);
            }
        }

        private void MostrarCursos()
        {
            foreach (Curso curso in Curso.listaCursos)
            {
                string nombre = curso.nombre; ;
                string codigo = curso.codigo;
                string descripcion = curso.descripcion;
                string cupo = curso.cupo.ToString();

                listBoxCursos.Items.Add($"{codigo} --> {nombre} --> {descripcion} --> {cupo} ");
            }
        }

        public string? RecuperarCodigoSelecionado()
        {
            string dataCurso;
            for (int i = 0; i < listBoxCursos.Items.Count; i++)
            {
                if (listBoxCursos.GetSelected(i))
                {
                    dataCurso = listBoxCursos.Items[i].ToString();
                    string[] partes = dataCurso.Split(new string[] { "-->" }, StringSplitOptions.RemoveEmptyEntries);

                    if (partes.Length >= 4)
                    {
                        string codigo = partes[0].Trim();
                        return codigo;
                    }
                }
            }
            return null;
        }


    }
}
