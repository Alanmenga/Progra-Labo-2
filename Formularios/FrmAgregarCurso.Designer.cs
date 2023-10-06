namespace Formularios
{
    partial class FrmAgregarCurso
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
            textBoxCupo = new TextBox();
            labelCupo = new Label();
            labelDescripcion = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            textBoxDescripcion = new TextBox();
            textBoxCodigo = new TextBox();
            textBoxNombre = new TextBox();
            buttonCancelar = new Button();
            buttonAgregar = new Button();
            SuspendLayout();
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(169, 255);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(111, 46);
            buttonLimpiar.TabIndex = 9;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxCupo
            // 
            textBoxCupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCupo.Location = new Point(150, 188);
            textBoxCupo.MaxLength = 4;
            textBoxCupo.Name = "textBoxCupo";
            textBoxCupo.Size = new Size(218, 33);
            textBoxCupo.TabIndex = 7;
            textBoxCupo.KeyPress += textBoxCupo_KeyPress;
            // 
            // labelCupo
            // 
            labelCupo.AutoSize = true;
            labelCupo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCupo.Location = new Point(26, 191);
            labelCupo.Name = "labelCupo";
            labelCupo.Size = new Size(61, 25);
            labelCupo.TabIndex = 6;
            labelCupo.Text = "Cupo:";
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(26, 144);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(115, 25);
            labelDescripcion.TabIndex = 4;
            labelDescripcion.Text = "Descripcion:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelApellido.Location = new Point(26, 90);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(77, 25);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Codigo:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(26, 42);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(90, 25);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "Nombre: ";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(150, 141);
            textBoxDescripcion.MaxLength = 30;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(218, 33);
            textBoxDescripcion.TabIndex = 5;
            // 
            // textBoxCodigo
            // 
            textBoxCodigo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCodigo.Location = new Point(150, 87);
            textBoxCodigo.MaxLength = 10;
            textBoxCodigo.Name = "textBoxCodigo";
            textBoxCodigo.Size = new Size(218, 33);
            textBoxCodigo.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(150, 39);
            textBoxNombre.MaxLength = 30;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(218, 33);
            textBoxNombre.TabIndex = 1;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(307, 255);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(111, 46);
            buttonCancelar.TabIndex = 10;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(128, 128, 255);
            buttonAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(26, 255);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(111, 46);
            buttonAgregar.TabIndex = 8;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // FrmAgregarCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(466, 366);
            Controls.Add(buttonLimpiar);
            Controls.Add(textBoxCupo);
            Controls.Add(labelCupo);
            Controls.Add(labelDescripcion);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxCodigo);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAgregar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmAgregarCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Curso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLimpiar;
        private TextBox textBoxCupo;
        private Label labelCupo;
        private Label labelDescripcion;
        private Label labelApellido;
        private Label labelNombre;
        private TextBox textBoxDescripcion;
        private TextBox textBoxCodigo;
        private TextBox textBoxNombre;
        private Button buttonCancelar;
        private Button buttonAgregar;
    }
}