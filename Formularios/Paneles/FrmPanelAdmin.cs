﻿using Biblioteca;
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
    public partial class FrmPanelAdmin : Form
    {
        public FrmPanelAdmin()
        {
            InitializeComponent();
        }

        private void buttonRegistrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmRegistEstud frmRegistEstud = new FrmRegistEstud();
            this.Hide();
            frmRegistEstud.Show();
        }

        private void buttonCerrarSesion_Click(object sender, EventArgs e)
        {
            Estudiante.EliminarListasEstudiantes();
            FrmLogin frmLogin = new FrmLogin();
            this.Close();
            frmLogin.Show();
        }

        private void buttonGestionarCursos_Click(object sender, EventArgs e)
        {
            FrmGestionarCursos frmGestionarCursos = new FrmGestionarCursos();
            this.Close();
            frmGestionarCursos.Show();
        }

        private void buttonMostrarEstudiante_Click(object sender, EventArgs e)
        {
            FrmMostrarEstudiantes frmMostrarEstudiantes = new FrmMostrarEstudiantes();
            this.Close();
            frmMostrarEstudiantes.Show();
        }

        private void buttonGenerarReportes_Click(object sender, EventArgs e)
        {

        }

        private void buttonGestionarRequisitos_Click(object sender, EventArgs e)
        {

        }

        private void buttonManejarEspera_Click(object sender, EventArgs e)
        {

        }
    }
}
