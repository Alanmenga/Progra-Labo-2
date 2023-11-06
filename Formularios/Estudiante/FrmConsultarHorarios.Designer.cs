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
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            listBoxCursosInsc = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(406, 368);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 49);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(128, 128, 255);
            buttonGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGuardar.Location = new Point(217, 368);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(110, 49);
            buttonGuardar.TabIndex = 1;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // listBoxCursosInsc
            // 
            listBoxCursosInsc.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxCursosInsc.FormattingEnabled = true;
            listBoxCursosInsc.ItemHeight = 25;
            listBoxCursosInsc.Location = new Point(12, 74);
            listBoxCursosInsc.Name = "listBoxCursosInsc";
            listBoxCursosInsc.Size = new Size(698, 254);
            listBoxCursosInsc.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(159, 20);
            label2.Name = "label2";
            label2.Size = new Size(398, 25);
            label2.TabIndex = 6;
            label2.Text = "Nombre --> Codigo --> Descripcion -->Cupo";
            // 
            // FrmConsultarHorarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(734, 450);
            Controls.Add(label2);
            Controls.Add(listBoxCursosInsc);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmConsultarHorarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horarios";
            Load += FrmConsultarHorarios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCancelar;
        private Button buttonGuardar;
        private ListBox listBoxCursosInsc;
        private Label label2;
    }
}