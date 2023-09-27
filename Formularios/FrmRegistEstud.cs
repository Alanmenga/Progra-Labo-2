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
    public partial class FrmRegistEstud : Form
    {
        public FrmRegistEstud()
        {
            InitializeComponent();
        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.abrirPanel();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string message = "Confirma agregado de estudiante?";
            string title = "Agregar Estudiante";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                /*Estudiante.AgregarEstudiante(textBoxNombre.Text,
                                             textBoxApellido.Text,
                                             int.Parse(textBoxDni.Text),
                                             textBoxDireccion.Text,
                                             int.Parse(textBoxTelefono.Text),
                                             textBoxCorreo.Text,
                                             textBoxContraseña.Text,
                                             true);*/
                this.abrirPanel();
                
            }
            else
            {
                FrmPanelAdmin frmPanelAdmin = new FrmPanelAdmin();
                this.Close();
                frmPanelAdmin.Show();
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDni.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxCorreo.Clear();
            textBoxContraseña.Clear();
            checkBoxCambiarContra.Checked = false;
        }

        private void abrirPanel()
        {
            FrmPanelAdmin frmPanel = new FrmPanelAdmin();
            this.Close();
            frmPanel.Show();
        }
    }
}
