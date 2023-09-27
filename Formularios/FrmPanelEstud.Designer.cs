namespace Formularios
{
    partial class FrmPanelEstud
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
            buttonCerrarSesion = new Button();
            buttonMostrarEstudiantes = new Button();
            buttonGestionarCursos = new Button();
            buttonRegistrarEstudiante = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.BackColor = Color.FromArgb(128, 128, 255);
            buttonCerrarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCerrarSesion.Location = new Point(208, 301);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(191, 54);
            buttonCerrarSesion.TabIndex = 11;
            buttonCerrarSesion.Text = "Cerrar Sesión";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // buttonMostrarEstudiantes
            // 
            buttonMostrarEstudiantes.BackColor = Color.FromArgb(128, 128, 255);
            buttonMostrarEstudiantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMostrarEstudiantes.Location = new Point(82, 218);
            buttonMostrarEstudiantes.Name = "buttonMostrarEstudiantes";
            buttonMostrarEstudiantes.Size = new Size(191, 54);
            buttonMostrarEstudiantes.TabIndex = 9;
            buttonMostrarEstudiantes.Text = "Realizar Pagos";
            buttonMostrarEstudiantes.UseVisualStyleBackColor = false;
            // 
            // buttonGestionarCursos
            // 
            buttonGestionarCursos.BackColor = Color.FromArgb(128, 128, 255);
            buttonGestionarCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGestionarCursos.Location = new Point(322, 129);
            buttonGestionarCursos.Name = "buttonGestionarCursos";
            buttonGestionarCursos.Size = new Size(191, 54);
            buttonGestionarCursos.TabIndex = 8;
            buttonGestionarCursos.Text = "Consultar Horarios";
            buttonGestionarCursos.UseVisualStyleBackColor = false;
            buttonGestionarCursos.Click += buttonGestionarCursos_Click;
            // 
            // buttonRegistrarEstudiante
            // 
            buttonRegistrarEstudiante.BackColor = Color.FromArgb(128, 128, 255);
            buttonRegistrarEstudiante.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegistrarEstudiante.Location = new Point(71, 129);
            buttonRegistrarEstudiante.Name = "buttonRegistrarEstudiante";
            buttonRegistrarEstudiante.Size = new Size(209, 54);
            buttonRegistrarEstudiante.TabIndex = 7;
            buttonRegistrarEstudiante.Text = "Inscripción de Cursos";
            buttonRegistrarEstudiante.UseVisualStyleBackColor = false;
            buttonRegistrarEstudiante.Click += buttonRegistrarEstudiante_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 52);
            label1.Name = "label1";
            label1.Size = new Size(455, 32);
            label1.TabIndex = 6;
            label1.Text = "Bienvenido al Panel de Administracion";
            // 
            // FrmPanelEstud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(599, 415);
            Controls.Add(buttonCerrarSesion);
            Controls.Add(buttonMostrarEstudiantes);
            Controls.Add(buttonGestionarCursos);
            Controls.Add(buttonRegistrarEstudiante);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPanelEstud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Administracion (estudiante)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCerrarSesion;
        private Button buttonMostrarEstudiantes;
        private Button buttonGestionarCursos;
        private Button buttonRegistrarEstudiante;
        private Label label1;
    }
}