﻿namespace Escritorio.Vistas {
    partial class BuscarVendedorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarVendedor = new System.Windows.Forms.Button();
            this.txtBuscarVendedor = new System.Windows.Forms.TextBox();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblFecNac = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblProfesion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblNumIde = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblImagen3 = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblImagen2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Football XXI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscarVendedor
            // 
            this.btnBuscarVendedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnBuscarVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarVendedor.Location = new System.Drawing.Point(356, 165);
            this.btnBuscarVendedor.Name = "btnBuscarVendedor";
            this.btnBuscarVendedor.Size = new System.Drawing.Size(75, 29);
            this.btnBuscarVendedor.TabIndex = 1;
            this.btnBuscarVendedor.Text = "Buscar ";
            this.btnBuscarVendedor.UseVisualStyleBackColor = false;
            this.btnBuscarVendedor.Click += new System.EventHandler(this.BtnBuscarVendedor_Click);
            // 
            // txtBuscarVendedor
            // 
            this.txtBuscarVendedor.Location = new System.Drawing.Point(311, 139);
            this.txtBuscarVendedor.Name = "txtBuscarVendedor";
            this.txtBuscarVendedor.Size = new System.Drawing.Size(179, 20);
            this.txtBuscarVendedor.TabIndex = 2;
            this.txtBuscarVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarVendedor_KeyPress);
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(40, 271);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(132, 20);
            this.lblPrimerNombre.TabIndex = 3;
            this.lblPrimerNombre.Text = "Primer Nombre:";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(40, 307);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(134, 20);
            this.lblPrimerApellido.TabIndex = 4;
            this.lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(40, 343);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(170, 20);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo de Documento:";
            // 
            // lblFecNac
            // 
            this.lblFecNac.AutoSize = true;
            this.lblFecNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecNac.Location = new System.Drawing.Point(40, 373);
            this.lblFecNac.Name = "lblFecNac";
            this.lblFecNac.Size = new System.Drawing.Size(183, 20);
            this.lblFecNac.TabIndex = 6;
            this.lblFecNac.Text = "Fecha de Nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(40, 404);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Correo:";
            // 
            // lblProfesion
            // 
            this.lblProfesion.AutoSize = true;
            this.lblProfesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesion.Location = new System.Drawing.Point(40, 439);
            this.lblProfesion.Name = "lblProfesion";
            this.lblProfesion.Size = new System.Drawing.Size(90, 20);
            this.lblProfesion.TabIndex = 8;
            this.lblProfesion.Text = "Profesión:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(40, 474);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(74, 20);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Género:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(38, 505);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(162, 20);
            this.lblNombreUsuario.TabIndex = 10;
            this.lblNombreUsuario.Text = "Nombre de Usuaio:";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(396, 271);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(153, 20);
            this.lblSegundoNombre.TabIndex = 11;
            this.lblSegundoNombre.Text = "Segundo Nombre:";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(396, 307);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(155, 20);
            this.lblSegundoApellido.TabIndex = 12;
            this.lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // lblNumIde
            // 
            this.lblNumIde.AutoSize = true;
            this.lblNumIde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIde.Location = new System.Drawing.Point(396, 343);
            this.lblNumIde.Name = "lblNumIde";
            this.lblNumIde.Size = new System.Drawing.Size(214, 20);
            this.lblNumIde.TabIndex = 13;
            this.lblNumIde.Text = "Número de Identificación:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(396, 373);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(56, 20);
            this.lblEdad.TabIndex = 14;
            this.lblEdad.Text = "Edad:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(396, 406);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(395, 439);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(162, 20);
            this.lblCelular.TabIndex = 16;
            this.lblCelular.Text = "Número de Celular:";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(396, 474);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(62, 20);
            this.lblRol.TabIndex = 17;
            this.lblRol.Text = "Cargo:";
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeleccionar.Location = new System.Drawing.Point(604, 568);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(161, 37);
            this.btSeleccionar.TabIndex = 18;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = false;
            this.btSeleccionar.Click += new System.EventHandler(this.BtSeleccionar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(493, 568);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(98, 37);
            this.btnAtras.TabIndex = 19;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // lblImagen3
            // 
            this.lblImagen3.Image = global::Escritorio.Properties.Resources.barcelona;
            this.lblImagen3.Location = new System.Drawing.Point(39, 33);
            this.lblImagen3.Name = "lblImagen3";
            this.lblImagen3.Size = new System.Drawing.Size(206, 226);
            this.lblImagen3.TabIndex = 22;
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Image = global::Escritorio.Properties.Resources.flamengo;
            this.lblImagen.Location = new System.Drawing.Point(53, 122);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(0, 13);
            this.lblImagen.TabIndex = 21;
            // 
            // lblImagen2
            // 
            this.lblImagen2.Image = global::Escritorio.Properties.Resources.atlanta;
            this.lblImagen2.Location = new System.Drawing.Point(556, 33);
            this.lblImagen2.Name = "lblImagen2";
            this.lblImagen2.Size = new System.Drawing.Size(221, 226);
            this.lblImagen2.TabIndex = 20;
            // 
            // BuscarVendedorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.lblImagen3);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblImagen2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNumIde);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblProfesion);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFecNac);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.txtBuscarVendedor);
            this.Controls.Add(this.btnBuscarVendedor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BuscarVendedorForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarVendedor;
        private System.Windows.Forms.TextBox txtBuscarVendedor;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblFecNac;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblProfesion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblNumIde;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblImagen2;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblImagen3;
    }
}