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
    public partial class FrmEditarCurso : Form
    {
        public FrmEditarCurso()
        {
            InitializeComponent();
        }

        private void FrmEditarCurso_Load(object sender, EventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.abrirGestionCursos();
        }

        private void abrirGestionCursos()
        {
            FrmGestionarCursos frmGestionarCursos = new FrmGestionarCursos();
            this.Close();
            frmGestionarCursos.Show();
        }


    }
}
