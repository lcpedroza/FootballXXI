﻿namespace Escritorio.Vistas {
    partial class Form1 {
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
            this.lblFootball = new System.Windows.Forms.Label();
            this.lblPrimerNombre = new System.Windows.Forms.Label();
            this.lblSegundoNombre = new System.Windows.Forms.Label();
            this.lblPrimerApellido = new System.Windows.Forms.Label();
            this.lblSegundoApellido = new System.Windows.Forms.Label();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblNumIde = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtNumIde = new System.Windows.Forms.TextBox();
            this.cbTiposDoc = new System.Windows.Forms.ComboBox();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.bntAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.AutoSize = true;
            this.lblFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(265, 21);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(185, 33);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            // 
            // lblPrimerNombre
            // 
            this.lblPrimerNombre.AutoSize = true;
            this.lblPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombre.Location = new System.Drawing.Point(47, 82);
            this.lblPrimerNombre.Name = "lblPrimerNombre";
            this.lblPrimerNombre.Size = new System.Drawing.Size(152, 24);
            this.lblPrimerNombre.TabIndex = 1;
            this.lblPrimerNombre.Text = "Primer Nombre";
            // 
            // lblSegundoNombre
            // 
            this.lblSegundoNombre.AutoSize = true;
            this.lblSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoNombre.Location = new System.Drawing.Point(47, 124);
            this.lblSegundoNombre.Name = "lblSegundoNombre";
            this.lblSegundoNombre.Size = new System.Drawing.Size(176, 24);
            this.lblSegundoNombre.TabIndex = 2;
            this.lblSegundoNombre.Text = "Segundo Nombre";
            // 
            // lblPrimerApellido
            // 
            this.lblPrimerApellido.AutoSize = true;
            this.lblPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerApellido.Location = new System.Drawing.Point(47, 177);
            this.lblPrimerApellido.Name = "lblPrimerApellido";
            this.lblPrimerApellido.Size = new System.Drawing.Size(154, 24);
            this.lblPrimerApellido.TabIndex = 3;
            this.lblPrimerApellido.Text = "Primer Apellido";
            // 
            // lblSegundoApellido
            // 
            this.lblSegundoApellido.AutoSize = true;
            this.lblSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoApellido.Location = new System.Drawing.Point(47, 222);
            this.lblSegundoApellido.Name = "lblSegundoApellido";
            this.lblSegundoApellido.Size = new System.Drawing.Size(176, 24);
            this.lblSegundoApellido.TabIndex = 4;
            this.lblSegundoApellido.Text = "Segundo Nombre";
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDoc.Location = new System.Drawing.Point(47, 268);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(195, 24);
            this.lblTipoDoc.TabIndex = 5;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // lblNumIde
            // 
            this.lblNumIde.AutoSize = true;
            this.lblNumIde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumIde.Location = new System.Drawing.Point(47, 310);
            this.lblNumIde.Name = "lblNumIde";
            this.lblNumIde.Size = new System.Drawing.Size(244, 24);
            this.lblNumIde.TabIndex = 6;
            this.lblNumIde.Text = "Número de Identificación";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(47, 355);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(80, 24);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "Género";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.Location = new System.Drawing.Point(416, 82);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(284, 20);
            this.txtPrimerNombre.TabIndex = 8;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.Location = new System.Drawing.Point(416, 128);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(284, 20);
            this.txtSegundoNombre.TabIndex = 9;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.Location = new System.Drawing.Point(416, 177);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(284, 20);
            this.txtPrimerApellido.TabIndex = 10;
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.Location = new System.Drawing.Point(416, 225);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(284, 20);
            this.txtSegundoApellido.TabIndex = 11;
            // 
            // txtNumIde
            // 
            this.txtNumIde.Location = new System.Drawing.Point(416, 310);
            this.txtNumIde.Name = "txtNumIde";
            this.txtNumIde.Size = new System.Drawing.Size(284, 20);
            this.txtNumIde.TabIndex = 12;
            // 
            // cbTiposDoc
            // 
            this.cbTiposDoc.FormattingEnabled = true;
            this.cbTiposDoc.Items.AddRange(new object[] {
            "Seleccione un tipo de documento"});
            this.cbTiposDoc.Location = new System.Drawing.Point(416, 268);
            this.cbTiposDoc.Name = "cbTiposDoc";
            this.cbTiposDoc.Size = new System.Drawing.Size(284, 21);
            this.cbTiposDoc.TabIndex = 13;
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Items.AddRange(new object[] {
            "Seleccione un género"});
            this.cbGeneros.Location = new System.Drawing.Point(416, 357);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(284, 21);
            this.cbGeneros.TabIndex = 14;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(599, 412);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 37);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // bntAtras
            // 
            this.bntAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAtras.Location = new System.Drawing.Point(469, 412);
            this.bntAtras.Name = "bntAtras";
            this.bntAtras.Size = new System.Drawing.Size(102, 37);
            this.bntAtras.TabIndex = 16;
            this.bntAtras.Text = "Atrás";
            this.bntAtras.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 452);
            this.Controls.Add(this.bntAtras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.cbTiposDoc);
            this.Controls.Add(this.txtNumIde);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblNumIde);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblSegundoApellido);
            this.Controls.Add(this.lblPrimerApellido);
            this.Controls.Add(this.lblSegundoNombre);
            this.Controls.Add(this.lblPrimerNombre);
            this.Controls.Add(this.lblFootball);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.Label lblPrimerNombre;
        private System.Windows.Forms.Label lblSegundoNombre;
        private System.Windows.Forms.Label lblPrimerApellido;
        private System.Windows.Forms.Label lblSegundoApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblNumIde;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtNumIde;
        private System.Windows.Forms.ComboBox cbTiposDoc;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button bntAtras;
    }
}