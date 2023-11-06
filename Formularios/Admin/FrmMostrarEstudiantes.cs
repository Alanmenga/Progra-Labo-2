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
    public partial class FrmMostrarEstudiantes : Form
    {
        public FrmMostrarEstudiantes()
        {
            InitializeComponent();
        }

        private void FrmMostrarEstudiantes_Load(object sender, EventArgs e)
        {
            this.MostrarEstudiantes();
        }

        private void MostrarEstudiantes()
        {
            foreach (Estudiante estudiante in Estudiante.listaEstudiantes)
            {
                string nombre = estudiante.nombre;
                string apellido = estudiante.apellido;
                string usuario = estudiante.usuario;
                int legajo = estudiante.legajo;

                listBoxEstudiantes.Items.Add($"--->{legajo}--->{nombre}--->{apellido}--->{usuario}--->");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPanelAdmin frmPanelAdmin = new FrmPanelAdmin();
            this.Close();
            frmPanelAdmin.Show();
        }
    }
}
