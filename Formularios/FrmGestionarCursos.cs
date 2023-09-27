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
                int tamanoEspacioNombre = anchoNombre - curso.nombre.Length;
                string nombre = curso.nombre.PadRight(tamanoEspacioNombre);
                int tamanoEspaciocodigo = anchoCodigo - curso.codigo.Length;
                string codigo = curso.codigo.PadRight(tamanoEspaciocodigo);
                int tamanoEspacioDescripcion = anchoDescripcion - curso.descripcion.Length;
                string descripcion = curso.descripcion.PadRight(anchoDescripcion);
                string cupo = curso.cupo.ToString().PadRight(anchoCupo);

                listBoxCursos.Items.Add($"'{nombre}'{codigo}'{descripcion}'{cupo}'");
            }

        }

        private void listBoxCursos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPanelAdmin frmPanelAdmin = new FrmPanelAdmin();
            this.Close();
            frmPanelAdmin.Show();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
