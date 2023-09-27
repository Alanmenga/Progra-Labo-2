﻿namespace Formularios
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelUsuario = new Label();
            labelContraseña = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttonIngresar = new Button();
            buttonLimpiar = new Button();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsuario.Location = new Point(66, 101);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(86, 25);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario: ";
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelContraseña.Location = new Point(66, 170);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(117, 25);
            labelContraseña.TabIndex = 3;
            labelContraseña.Text = "Contraseña: ";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsuario.Location = new Point(208, 101);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 33);
            textBoxUsuario.TabIndex = 2;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxContraseña.Location = new Point(208, 167);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.PasswordChar = '*';
            textBoxContraseña.Size = new Size(100, 33);
            textBoxContraseña.TabIndex = 4;
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.FromArgb(128, 128, 255);
            buttonIngresar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIngresar.Location = new Point(66, 253);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(102, 52);
            buttonIngresar.TabIndex = 5;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            buttonLimpiar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLimpiar.Location = new Point(208, 253);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(102, 52);
            buttonLimpiar.TabIndex = 6;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            buttonLimpiar.Click += buttonLimpiar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(56, 38);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(293, 32);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "SISTEMA NEW SYSACAD";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(425, 362);
            Controls.Add(labelTitulo);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonIngresar);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(labelContraseña);
            Controls.Add(labelUsuario);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsuario;
        private Label labelContraseña;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttonIngresar;
        private Button buttonLimpiar;
        private Label labelTitulo;
    }
}