namespace Formularios
{
    partial class FrmPanelAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            buttonRegistrarEstudiante = new Button();
            buttonGestionarCursos = new Button();
            buttonCerrarSesion = new Button();
            buttonMostrarEstudiantes = new Button();
            buttonGenerarReportes = new Button();
            buttonManejarEspera = new Button();
            buttonGestionarRequisitos = new Button();
            buttonGestionarProfesores = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 51);
            label1.Name = "label1";
            label1.Size = new Size(455, 32);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido al Panel de Administracion";
            // 
            // buttonRegistrarEstudiante
            // 
            buttonRegistrarEstudiante.BackColor = Color.FromArgb(128, 128, 255);
            buttonRegistrarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrarEstudiante.Location = new Point(82, 128);
            buttonRegistrarEstudiante.Name = "buttonRegistrarEstudiante";
            buttonRegistrarEstudiante.Size = new Size(191, 54);
            buttonRegistrarEstudiante.TabIndex = 1;
            buttonRegistrarEstudiante.Text = "Registrar Estudiante";
            buttonRegistrarEstudiante.UseVisualStyleBackColor = false;
            buttonRegistrarEstudiante.Click += buttonRegistrarEstudiante_Click;
            // 
            // buttonGestionarCursos
            // 
            buttonGestionarCursos.BackColor = Color.FromArgb(128, 128, 255);
            buttonGestionarCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestionarCursos.Location = new Point(322, 128);
            buttonGestionarCursos.Name = "buttonGestionarCursos";
            buttonGestionarCursos.Size = new Size(191, 54);
            buttonGestionarCursos.TabIndex = 2;
            buttonGestionarCursos.Text = "Gestionar Cursos";
            buttonGestionarCursos.UseVisualStyleBackColor = false;
            buttonGestionarCursos.Click += buttonGestionarCursos_Click;
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.BackColor = Color.FromArgb(128, 128, 255);
            buttonCerrarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCerrarSesion.Location = new Point(197, 473);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(191, 54);
            buttonCerrarSesion.TabIndex = 4;
            buttonCerrarSesion.Text = "Cerrar Sesión";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // buttonMostrarEstudiantes
            // 
            buttonMostrarEstudiantes.BackColor = Color.FromArgb(128, 128, 255);
            buttonMostrarEstudiantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMostrarEstudiantes.Location = new Point(82, 210);
            buttonMostrarEstudiantes.Name = "buttonMostrarEstudiantes";
            buttonMostrarEstudiantes.Size = new Size(191, 54);
            buttonMostrarEstudiantes.TabIndex = 3;
            buttonMostrarEstudiantes.Text = "Mostrar Estudiantes";
            buttonMostrarEstudiantes.UseVisualStyleBackColor = false;
            buttonMostrarEstudiantes.Click += buttonMostrarEstudiante_Click;
            // 
            // buttonGenerarReportes
            // 
            buttonGenerarReportes.BackColor = Color.FromArgb(128, 128, 255);
            buttonGenerarReportes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerarReportes.Location = new Point(322, 210);
            buttonGenerarReportes.Name = "buttonGenerarReportes";
            buttonGenerarReportes.Size = new Size(191, 54);
            buttonGenerarReportes.TabIndex = 5;
            buttonGenerarReportes.Text = "Generar Reportes";
            buttonGenerarReportes.UseVisualStyleBackColor = false;
            buttonGenerarReportes.Click += buttonGenerarReportes_Click;
            // 
            // buttonManejarEspera
            // 
            buttonManejarEspera.BackColor = Color.FromArgb(128, 128, 255);
            buttonManejarEspera.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonManejarEspera.Location = new Point(322, 294);
            buttonManejarEspera.Name = "buttonManejarEspera";
            buttonManejarEspera.Size = new Size(191, 65);
            buttonManejarEspera.TabIndex = 7;
            buttonManejarEspera.Text = "Manejar Lista de Espera";
            buttonManejarEspera.UseVisualStyleBackColor = false;
            buttonManejarEspera.Click += buttonManejarEspera_Click;
            // 
            // buttonGestionarRequisitos
            // 
            buttonGestionarRequisitos.BackColor = Color.FromArgb(128, 128, 255);
            buttonGestionarRequisitos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestionarRequisitos.Location = new Point(82, 294);
            buttonGestionarRequisitos.Name = "buttonGestionarRequisitos";
            buttonGestionarRequisitos.Size = new Size(191, 65);
            buttonGestionarRequisitos.TabIndex = 6;
            buttonGestionarRequisitos.Text = "Gestionar Requisitos Académicos";
            buttonGestionarRequisitos.UseVisualStyleBackColor = false;
            buttonGestionarRequisitos.Click += buttonGestionarRequisitos_Click;
            // 
            // buttonGestionarProfesores
            // 
            buttonGestionarProfesores.BackColor = Color.FromArgb(128, 128, 255);
            buttonGestionarProfesores.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestionarProfesores.Location = new Point(82, 381);
            buttonGestionarProfesores.Name = "buttonGestionarProfesores";
            buttonGestionarProfesores.Size = new Size(191, 65);
            buttonGestionarProfesores.TabIndex = 8;
            buttonGestionarProfesores.Text = "Gestionar Perfiles de Profesores";
            buttonGestionarProfesores.UseVisualStyleBackColor = false;
            // 
            // FrmPanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(599, 539);
            Controls.Add(buttonGestionarProfesores);
            Controls.Add(buttonManejarEspera);
            Controls.Add(buttonGestionarRequisitos);
            Controls.Add(buttonGenerarReportes);
            Controls.Add(buttonMostrarEstudiantes);
            Controls.Add(buttonCerrarSesion);
            Controls.Add(buttonGestionarCursos);
            Controls.Add(buttonRegistrarEstudiante);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPanelAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Administracion (admin)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button buttonRegistrarEstudiante;
        private Button buttonGestionarCursos;
        private Button buttonCerrarSesion;
        private Button buttonMostrarEstudiantes;
        private Button buttonGenerarReportes;
        private Button buttonManejarEspera;
        private Button buttonGestionarRequisitos;
        private Button buttonGestionarProfesores;
    }
}