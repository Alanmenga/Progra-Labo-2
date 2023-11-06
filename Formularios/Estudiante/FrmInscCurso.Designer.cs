namespace Formularios
{
    partial class FrmInscCurso
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
            buttonInscribir = new Button();
            checkedListBoxCursos = new CheckedListBox();
            buttonLimpiar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(440, 384);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 49);
            buttonCancelar.TabIndex = 3;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonInscribir
            // 
            buttonInscribir.BackColor = Color.FromArgb(128, 128, 255);
            buttonInscribir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInscribir.Location = new Point(127, 384);
            buttonInscribir.Name = "buttonInscribir";
            buttonInscribir.Size = new Size(110, 49);
            buttonInscribir.TabIndex = 1;
            buttonInscribir.Text = "Inscribirse";
            buttonInscribir.UseVisualStyleBackColor = false;
            buttonInscribir.Click += buttonInscribir_Click;
            // 
            // checkedListBoxCursos
            // 
            checkedListBoxCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxCursos.FormattingEnabled = true;
            checkedListBoxCursos.Location = new Point(12, 65);
            checkedListBoxCursos.Name = "checkedListBoxCursos";
            checkedListBoxCursos.Size = new Size(710, 284);
            checkedListBoxCursos.TabIndex = 0;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(284, 384);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(98, 49);
            buttonLimpiar.TabIndex = 2;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(127, 21);
            label2.Name = "label2";
            label2.Size = new Size(398, 25);
            label2.TabIndex = 6;
            label2.Text = "Nombre --> Codigo --> Descripcion -->Cupo";
            // 
            // FrmInscCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(734, 457);
            Controls.Add(label2);
            Controls.Add(buttonLimpiar);
            Controls.Add(checkedListBoxCursos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonInscribir);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmInscCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripcion a Curso";
            Load += FrmInscCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonInscribir;
        private CheckedListBox checkedListBoxCursos;
        private Button buttonLimpiar;
        private Label label2;
    }
}