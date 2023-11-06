namespace Formularios
{
    partial class FrmRegistEstud
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
            buttonCancelar = new Button();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxDni = new TextBox();
            textBoxDireccion = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            labelDni = new Label();
            labelDireccion = new Label();
            labelTelefono = new Label();
            labelCorreo = new Label();
            labelContraseña = new Label();
            textBoxContraseña = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxTelefono = new TextBox();
            checkBoxCambiarContra = new CheckBox();
            buttonLimpiar = new Button();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            SuspendLayout();
            // 
            // buttonAgregar
            // 
            buttonAgregar.BackColor = Color.FromArgb(128, 128, 255);
            buttonAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAgregar.Location = new Point(23, 495);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(111, 46);
            buttonAgregar.TabIndex = 17;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = false;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(128, 128, 255);
            buttonCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancelar.Location = new Point(304, 495);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(111, 46);
            buttonCancelar.TabIndex = 19;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
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
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.Location = new Point(150, 87);
            textBoxApellido.MaxLength = 30;
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(218, 33);
            textBoxApellido.TabIndex = 3;
            // 
            // textBoxDni
            // 
            textBoxDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDni.Location = new Point(150, 136);
            textBoxDni.MaxLength = 8;
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(218, 33);
            textBoxDni.TabIndex = 5;
            textBoxDni.KeyPress += textBoxDni_KeyPress;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDireccion.Location = new Point(150, 185);
            textBoxDireccion.MaxLength = 40;
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(218, 33);
            textBoxDireccion.TabIndex = 7;
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
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelApellido.Location = new Point(26, 90);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(86, 25);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDni.Location = new Point(26, 139);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(53, 25);
            labelDni.TabIndex = 4;
            labelDni.Text = "DNI: ";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDireccion.Location = new Point(23, 188);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(101, 25);
            labelDireccion.TabIndex = 6;
            labelDireccion.Text = "Direccion: ";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTelefono.Location = new Point(23, 235);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(93, 25);
            labelTelefono.TabIndex = 8;
            labelTelefono.Text = "Telefono: ";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorreo.Location = new Point(26, 284);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(79, 25);
            labelCorreo.TabIndex = 10;
            labelCorreo.Text = "Correo: ";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelContraseña.Location = new Point(26, 383);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(122, 25);
            labelContraseña.TabIndex = 14;
            labelContraseña.Text = "Contraseña:  ";
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContraseña.Location = new Point(150, 380);
            textBoxContraseña.MaxLength = 10;
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(218, 33);
            textBoxContraseña.TabIndex = 15;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCorreo.Location = new Point(150, 281);
            textBoxCorreo.MaxLength = 50;
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(218, 33);
            textBoxCorreo.TabIndex = 11;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTelefono.Location = new Point(150, 232);
            textBoxTelefono.MaxLength = 10;
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(218, 33);
            textBoxTelefono.TabIndex = 9;
            textBoxTelefono.KeyPress += textBoxTelefono_KeyPress;
            // 
            // checkBoxCambiarContra
            // 
            checkBoxCambiarContra.AutoSize = true;
            checkBoxCambiarContra.CheckAlign = ContentAlignment.MiddleRight;
            checkBoxCambiarContra.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxCambiarContra.Location = new Point(26, 434);
            checkBoxCambiarContra.Name = "checkBoxCambiarContra";
            checkBoxCambiarContra.Size = new Size(270, 29);
            checkBoxCambiarContra.TabIndex = 16;
            checkBoxCambiarContra.Text = "Debe cambiar su contraseña";
            checkBoxCambiarContra.TextAlign = ContentAlignment.MiddleCenter;
            checkBoxCambiarContra.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(166, 495);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(111, 46);
            buttonLimpiar.TabIndex = 18;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(150, 329);
            textBoxUsuario.MaxLength = 50;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(218, 33);
            textBoxUsuario.TabIndex = 13;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(26, 332);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(86, 25);
            labelUsuario.TabIndex = 12;
            labelUsuario.Text = "Usuario: ";
            // 
            // FrmRegistEstud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(466, 591);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelUsuario);
            Controls.Add(buttonLimpiar);
            Controls.Add(checkBoxCambiarContra);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxTelefono);
            Controls.Add(labelContraseña);
            Controls.Add(labelCorreo);
            Controls.Add(labelTelefono);
            Controls.Add(labelDireccion);
            Controls.Add(labelDni);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxDni);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonAgregar);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmRegistEstud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Estudiante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAgregar;
        private Button buttonCancelar;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxDni;
        private TextBox textBoxDireccion;
        private Label labelNombre;
        private Label labelApellido;
        private Label labelDni;
        private Label labelDireccion;
        private Label labelTelefono;
        private Label labelCorreo;
        private Label labelContraseña;
        private TextBox textBoxContraseña;
        private TextBox textBoxCorreo;
        private TextBox textBoxTelefono;
        private CheckBox checkBoxCambiarContra;
        private Button buttonLimpiar;
        private TextBox textBoxUsuario;
        private Label labelUsuario;
    }
}