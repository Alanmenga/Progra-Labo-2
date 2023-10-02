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
    public partial class FrmConsultarHorarios : Form
    {
        public FrmConsultarHorarios()
        {
            InitializeComponent();
        }

        private void FrmConsultarHorarios_Load(object sender, EventArgs e)
        {
            MostrarCursos();
        }

        private void MostrarCursos()
        {
            foreach (Curso curso in Estudiante.cursosInscriptos)
            {

                string nombre = curso.nombre;
                string codigo = curso.codigo;
                string descripcion = curso.descripcion;
                string cupo = curso.cupo.ToString();

                listBoxCursosInsc.Items.Add($"'{nombre}'{codigo}'{descripcion}'{cupo}'");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPanelEstud frmPanelEstud = new FrmPanelEstud();
            this.Close();
            frmPanelEstud.Show();
        }
    }
}
