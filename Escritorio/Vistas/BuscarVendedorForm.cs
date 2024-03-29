﻿
using Escritorio.Ayuda;
using Compartido.Dao;
using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio.Vistas {

    public partial class BuscarVendedorForm : Form {
        private Empleado vendedor;
        private Factura factura;
        readonly Entidades db;

        /*
        * El método constructor del form recibe como parámetro la factura 
        */
        public BuscarVendedorForm(Factura factura) {
            InitializeComponent();
            db = new Entidades();
            this.factura = factura;
        }

        /*
        * Johan Sebastian Piza Acosta
        * Evento que cierra la ventana
        */
        private void BtnAtras_Click(object sender, EventArgs e) {
            Close();
        }

        /*
        * Luis Carlos Pedroza Pineda
        * Evento que busca el vendedor por el número de documento
        */
        private void BtnBuscarVendedor_Click(object sender, EventArgs e) {
            if (validar()) {
                string numeroDocumento = txtBuscarVendedor.Text;
                var empleadoDao = new EmpleadoDao(db);
                vendedor = empleadoDao.buscarVendedor(numeroDocumento);

                if (vendedor != null) {
                    lblPrimerNombre.Text = "Primer Nombre: " + vendedor.Persona.PrimerNombre;
                    lblSegundoNombre.Text = "Segundo Nombre: " + vendedor.Persona.SegundoNombre;
                    lblPrimerApellido.Text = "Primer Apellido: " + vendedor.Persona.PrimerApellido;
                    lblSegundoApellido.Text = "Segundo Apellido: " + vendedor.Persona.SegundoApellido;
                    lblTipoDoc.Text = "Tipo de Documento: " + vendedor.Persona.TiposDeDocumento.NombreCorto;
                    lblNumIde.Text = "Número de Documento: " + vendedor.Persona.NumeroDocumento;
                    lblGenero.Text = "Género: " + vendedor.Persona.Generos.Nombre;
                    lblFecNac.Text = "Fecha de Nacimiento: " + vendedor.FechaNac;
                    lblCelular.Text = "Celular: " + vendedor.Celular;
                    lblEmail.Text = "Correo: " + vendedor.Email;
                    lblDireccion.Text = "Dirección: " + vendedor.Dirreccion;
                    lblProfesion.Text = "Profesión: " + vendedor.Profesion;
                    lblNombreUsuario.Text = "Nombre de Usuario: " + vendedor.NombreUsuario;
                    lblRol.Text = "Cargo: " + vendedor.Rol.Nombre;
                    lblEdad.Text = "Edad: " + vendedor.Edad;

                } else {
                    MessageBox.Show("El vendedor no existe");
                }
            }
        }

        /*
         * Luis Carlos Pedroza Pineda
         * Evento selecciona el vendedor
         */
        private void BtSeleccionar_Click(object sender, EventArgs e) {
            factura.Vendedor = vendedor;
            Close();
        }

        /*
         * Luis Carlos Pedroza Pineda
         * Método privado que valida que los campos no estén vacíos
         */
        private bool validar() {
            if (!Validacion.validarCampoVacio(txtBuscarVendedor)) {
                MessageBox.Show("El campo Buscar no puede estar vacío");
                return false;
            }
            return true;
        }

        /*
         * Luis Carlos Pedroza Pineda
         * Evento que valida que no se escriaban letras en el campo
         */
        private void txtBuscarVendedor_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }
    }
}
