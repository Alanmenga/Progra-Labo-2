namespace Formularios
{
    partial class FrmEditarCurso
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
            textBoxCupo = new TextBox();
            labelCupo = new Label();
            labelDescripcion = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            textBoxDescripcion = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxNombre = new TextBox();
            buttonCancelar = new Button();
            buttonEditar = new Button();
            SuspendLayout();
            // 
            // textBoxCupo
            // 
            textBoxCupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCupo.Location = new Point(158, 186);
            textBoxCupo.MaxLength = 4;
            textBoxCupo.Name = "textBoxCupo";
            textBoxCupo.Size = new Size(218, 33);
            textBoxCupo.TabIndex = 18;
            // 
            // labelCupo
            // 
            labelCupo.AutoSize = true;
            labelCupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCupo.Location = new Point(34, 189);
            labelCupo.Name = "labelCupo";
            labelCupo.Size = new Size(61, 25);
            labelCupo.TabIndex = 17;
            labelCupo.Text = "Cupo:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(34, 142);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(115, 25);
            labelDescripcion.TabIndex = 15;
            labelDescripcion.Text = "Descripcion:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelApellido.Location = new Point(34, 88);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(77, 25);
            labelApellido.TabIndex = 13;
            labelApellido.Text = "Codigo:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(34, 40);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(90, 25);
            labelNombre.TabIndex = 11;
            labelNombre.Text = "Nombre: ";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(158, 139);
            textBoxDescripcion.MaxLength = 30;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(218, 33);
            textBoxDescripcion.TabIndex = 16;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.Location = new Point(158, 85);
            textBoxCodigo.MaxLength = 10;
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(218, 33);
            textBoxCodigo.TabIndex = 14;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(158, 37);
            textBoxNombre.MaxLength = 30;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(218, 33);
            textBoxNombre.TabIndex = 12;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(241, 253);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(111, 46);
            buttonCancelar.TabIndex = 21;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.FromArgb(128, 128, 255);
            buttonEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEditar.Location = new Point(68, 253);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(111, 46);
            buttonEditar.TabIndex = 19;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // FrmEditarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(466, 366);
            Controls.Add(textBoxCupo);
            Controls.Add(labelCupo);
            Controls.Add(labelDescripcion);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonEditar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmEditarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Curso";
            Load += FrmEditarCurso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxCupo;
        private Label labelCupo;
        private Label labelDescripcion;
        private Label labelApellido;
        private Label labelNombre;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private Button buttonCancelar;
        private Button buttonEditar;
    }
}