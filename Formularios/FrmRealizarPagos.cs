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
    public partial class FrmRealizarPagos : Form
    {
        public FrmRealizarPagos()
        {
            InitializeComponent();
        }

        private void FrmRealizarPagos_Load(object sender, EventArgs e)
        {
            MostrarDeudas();
        }

        private void MostrarDeudas()
        {
            foreach (Curso curso in Curso.listaCursos)
            {

                string nombre = curso.nombre;
                string codigo = curso.codigo;
                string descripcion = curso.descripcion;
                string cupo = curso.cupo.ToString();

                checkedListBoxCursos.Items.Add($"'{nombre}'{codigo}'{descripcion}'{cupo}'");
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxCursos.Items.Count; i++)
            {
                checkedListBoxCursos.SetItemChecked(i, false);
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
