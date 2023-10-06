namespace Formularios
{
    partial class FrmGestionarCursos
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
            buttonAgregar = new Button();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            buttonCancelar = new Button();
            listBoxCursos = new ListBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(128, 128, 255);
            buttonAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(59, 353);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(98, 49);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(128, 128, 255);
            buttonEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditar.Location = new Point(202, 353);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(98, 49);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(128, 128, 255);
            buttonEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(342, 353);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(98, 49);
            buttonEliminar.TabIndex = 3;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(493, 353);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(98, 49);
            buttonCancelar.TabIndex = 4;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // listBoxCursos
            // 
            listBoxCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxCursos.FormattingEnabled = true;
            listBoxCursos.ItemHeight = 25;
            listBoxCursos.Location = new Point(12, 65);
            listBoxCursos.Name = "listBoxCursos";
            listBoxCursos.Size = new Size(706, 254);
            listBoxCursos.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(142, 22);
            label2.Name = "label2";
            label2.Size = new Size(398, 25);
            label2.TabIndex = 5;
            label2.Text = "Nombre --> Codigo --> Descripcion -->Cupo";
            // 
            // FrmGestionarCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(734, 450);
            Controls.Add(label2);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonAgregar);
            Controls.Add(listBoxCursos);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmGestionarCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Curso";
            Load += FrmGestionarCursos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Button buttonAgregar;
        private Button buttonEditar;
        private Button buttonEliminar;
        private Button buttonCancelar;
        private ListBox listBoxCursos;
        private Label label2;
    }
}