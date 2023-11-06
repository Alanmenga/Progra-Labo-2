namespace Formularios
{
    partial class FrmPanelProfe
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
            label2 = new Label();
            buttonCerrarSesion = new Button();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonAgregar = new Button();
            listBoxCursos = new ListBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 34);
            label2.Name = "label2";
            label2.Size = new Size(398, 25);
            label2.TabIndex = 11;
            label2.Text = "Nombre --> Codigo --> Descripcion -->Cupo";
            // 
            // buttonCerrarSesion
            // 
            buttonCerrarSesion.BackColor = Color.FromArgb(128, 128, 255);
            buttonCerrarSesion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCerrarSesion.Location = new Point(528, 366);
            buttonCerrarSesion.Name = "buttonCerrarSesion";
            buttonCerrarSesion.Size = new Size(136, 49);
            buttonCerrarSesion.TabIndex = 10;
            buttonCerrarSesion.Text = "Cerrar Sesion";
            buttonCerrarSesion.UseVisualStyleBackColor = false;
            buttonCerrarSesion.Click += buttonCerrarSesion_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.FromArgb(128, 128, 255);
            buttonEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEliminar.Location = new Point(377, 366);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(98, 49);
            buttonEliminar.TabIndex = 9;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(128, 128, 255);
            buttonEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditar.Location = new Point(237, 366);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(98, 49);
            buttonEditar.TabIndex = 8;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(128, 128, 255);
            buttonAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(94, 366);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(98, 49);
            buttonAgregar.TabIndex = 7;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            // 
            // listBoxCursos
            // 
            listBoxCursos.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxCursos.FormattingEnabled = true;
            listBoxCursos.ItemHeight = 25;
            listBoxCursos.Location = new Point(12, 78);
            listBoxCursos.Name = "listBoxCursos";
            listBoxCursos.Size = new Size(706, 254);
            listBoxCursos.TabIndex = 6;
            // 
            // FrmPanelProfe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(743, 450);
            Controls.Add(label2);
            Controls.Add(buttonCerrarSesion);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonAgregar);
            Controls.Add(listBoxCursos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmPanelProfe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Administracion (profesor)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button buttonCerrarSesion;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonAgregar;
        private ListBox listBoxCursos;
    }
}