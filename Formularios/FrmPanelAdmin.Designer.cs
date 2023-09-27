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
            buttonCerrarSesion.Location = new Point(208, 300);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(191, 54);
            buttonCerrarSesion.TabIndex = 5;
            buttonCerrarSesion.Text = "Cerrar Sesión";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // FrmPanelAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(599, 415);
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
    }
}