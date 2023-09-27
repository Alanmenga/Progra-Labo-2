namespace Formularios
{
    partial class FrmConsultarHorarios
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
            buttonLimpiar = new Button();
            buttonCancelar = new Button();
            buttonInscribir = new Button();
            SuspendLayout();
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(215, 325);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(98, 49);
            buttonLimpiar.TabIndex = 5;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(371, 325);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 49);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // buttonInscribir
            // 
            buttonInscribir.BackColor = Color.FromArgb(128, 128, 255);
            buttonInscribir.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInscribir.Location = new Point(58, 325);
            buttonInscribir.Name = "buttonInscribir";
            buttonInscribir.Size = new Size(110, 49);
            buttonInscribir.TabIndex = 4;
            buttonInscribir.Text = "Inscribirse";
            buttonInscribir.UseVisualStyleBackColor = false;
            // 
            // FrmConsultarHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(558, 428);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonInscribir);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmConsultarHorarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horarios";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLimpiar;
        private Button buttonCancelar;
        private Button buttonInscribir;
    }
}