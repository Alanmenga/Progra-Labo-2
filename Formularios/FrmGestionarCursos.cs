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

        private void MostrarCursos()
        {
            // Definir el ancho de cada columna
            int anchoNombre = 35;
            int anchoCodigo = 15;
            int anchoDescripcion = 40;
            int anchoCupo = 10;

            foreach (Curso curso in Curso.listaCursos)
            {
                string nombre = curso.nombre;;
                string codigo = curso.codigo;
                string descripcion = curso.descripcion;
                string cupo = curso.cupo.ToString();

                listBoxCursos.Items.Add($"{nombre} --> {codigo} --> {descripcion} --> {cupo} ");
            }

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
    }
}
