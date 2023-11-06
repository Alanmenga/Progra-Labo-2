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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FrmPanelEstud frmPanelEstud = new FrmPanelEstud();
            this.Close();
            frmPanelEstud.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"¿Desea guardar la informacion en un archivo?", "Guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                string contenido = "Este es el contenido que quiero guardar en un archivo.";
                string rutaArchivo = @"C:\Users\ICBC\Desktop\Facu\Seg-Cuatri2023\Progra-Labo-2\SistemaSYSACAD\Cursos.txt";

                try
                {
                    // Verifica si el archivo ya existe
                    if (File.Exists(rutaArchivo))
                    {
                        // Si el archivo existe, guarda el contenido en él
                        File.WriteAllText(rutaArchivo, contenido);
                        MessageBox.Show($"Contenido guardado en el archivo existente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        // Si el archivo no existe, crea uno nuevo y guarda el contenido en él
                        File.WriteAllText(rutaArchivo, contenido);
                        MessageBox.Show($"Archivo creado y contenido guardado", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar o crear el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MostrarCursos()
        {
            foreach (Curso curso in Estudiante.listaCursosInscriptos)
            {

                string nombre = curso.nombre;
                string codigo = curso.codigo;
                string descripcion = curso.descripcion;
                string cupo = curso.cupo.ToString();

                listBoxCursosInsc.Items.Add($"{codigo} --> {nombre} --> {descripcion} --> {cupo} ");
            }
        }
    }
}
