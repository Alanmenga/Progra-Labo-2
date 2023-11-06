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
    public partial class FrmPanelEstud : Form
    {
        public FrmPanelEstud()
        {
            InitializeComponent();
        }

        private void buttonRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmInscCurso frmInscCurso = new FrmInscCurso();
            this.Close();
            frmInscCurso.Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            if(Estudiante.listaCursosInscriptos.Count == 0)
            {
                MessageBox.Show($"El alumno no esta anotado en ningun curso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmConsultarHorarios frmConsultarHorarios = new FrmConsultarHorarios();
                this.Close();
                frmConsultarHorarios.Show();
            }
        }

        private void buttonMostrarEstudiantes_Click(object sender, EventArgs e)
        {
            FrmRealizarPagos frmRealizarPagos = new FrmRealizarPagos();
            this.Close();
            frmRealizarPagos.Show();
        }
    }
}
