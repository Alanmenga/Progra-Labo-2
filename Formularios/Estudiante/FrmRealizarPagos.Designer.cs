namespace Formularios
{
    partial class FrmRealizarPagos
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
            checkedListBoxCursos = new CheckedListBox();
            buttonCancelar = new Button();
            buttonPagar = new Button();
            SuspendLayout();
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(274, 350);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(98, 49);
            buttonLimpiar.TabIndex = 6;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // checkedListBoxCursos
            // 
            checkedListBoxCursos.FormattingEnabled = true;
            checkedListBoxCursos.Location = new Point(26, 31);
            checkedListBoxCursos.Name = "checkedListBoxCursos";
            checkedListBoxCursos.Size = new Size(642, 292);
            checkedListBoxCursos.TabIndex = 4;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(430, 350);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 49);
            buttonCancelar.TabIndex = 7;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.FromArgb(128, 128, 255);
            buttonPagar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPagar.Location = new Point(117, 350);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(110, 49);
            buttonPagar.TabIndex = 5;
            buttonPagar.Text = "Pagar";
            buttonPagar.UseVisualStyleBackColor = false;
            // 
            // FrmRealizarPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(734, 450);
            Controls.Add(buttonLimpiar);
            Controls.Add(checkedListBoxCursos);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonPagar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmRealizarPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmRealizarPagos";
            Load += FrmRealizarPagos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLimpiar;
        private CheckedListBox checkedListBoxCursos;
        private Button buttonCancelar;
        private Button buttonPagar;
    }
}