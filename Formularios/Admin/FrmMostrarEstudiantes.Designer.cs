namespace Formularios
{
    partial class FrmMostrarEstudiantes
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
            buttonCancelar = new Button();
            listBoxEstudiantes = new ListBox();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(344, 336);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 49);
            buttonCancelar.TabIndex = 9;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // listBoxEstudiantes
            // 
            listBoxEstudiantes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxEstudiantes.FormattingEnabled = true;
            listBoxEstudiantes.ItemHeight = 25;
            listBoxEstudiantes.Location = new Point(47, 43);
            listBoxEstudiantes.Name = "listBoxEstudiantes";
            listBoxEstudiantes.Size = new Size(706, 254);
            listBoxEstudiantes.TabIndex = 5;
            // 
            // FrmMostrarEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(806, 432);
            Controls.Add(buttonCancelar);
            Controls.Add(listBoxEstudiantes);
            Name = "FrmMostrarEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mostrar Estudiantes";
            Load += FrmMostrarEstudiantes_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonAgregar;
        private ListBox listBoxEstudiantes;
        private DataGridView dataGridViewEstudiantes;
    }
}