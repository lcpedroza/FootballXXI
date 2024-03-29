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
    public partial class EditarEmpleado : Form {

        private Empleado empleado;
        private Entidades db;
        public EditarEmpleado(Empleado empleado) {
            InitializeComponent();
            db = new Entidades();
            this.empleado = empleado;

            var generoDao = new GeneroDao(db);//Instancia de la clase GeneroDao
            var generos = generoDao.GetGeneros();//Llamada al método que trae la lista de
            cbGeneros.Items.AddRange(generos.ToArray());//Agrega lista de géneros al combobox

            var tipoDeDocumentoDao = new TipoDeDocumentoDao(db);//Instancia de la clase TiposDeDocumentoDao
            var tiposDeDocumento = tipoDeDocumentoDao.GetTiposDeDocumento();//Llamada al método que trae la lista de
            cbTipoDoc.Items.AddRange(tiposDeDocumento.ToArray());//Agrega lista de tipos de documento al combobox

            var rolDao = new RolDao(db);//Instancia de la clase RolDao
            var roles = rolDao.GetRoles();//Llamada al método que trae la lista de
            cbRoles.Items.AddRange(roles.ToArray());//Agrega lista de roles al combobox

            /*
            * Luis Carlos Pedroza Pineda
            * Muestra en pantalla los datos que se van a editar
            */
            txtPrimerNombre.Text = empleado.Persona.PrimerNombre;
            txtSegundoNombre.Text = empleado.Persona.SegundoNombre;
            txtPrimerApellido.Text = empleado.Persona.PrimerApellido;
            txtSegundoApellido.Text = empleado.Persona.SegundoApellido;
            cbTipoDoc.SelectedItem = empleado.Persona.TiposDeDocumento;
            txtNumIde.Text = empleado.Persona.NumeroDocumento;
            cbGeneros.SelectedItem = empleado.Persona.Generos;
            txtCelular.Text = empleado.Celular;
            txtCorreo.Text = empleado.Email;
            txtDireccion.Text = empleado.Dirreccion;
            txtProfesion.Text = empleado.Profesion;
            cbRoles.SelectedItem = empleado.Rol;
            txtNombreUsuario.Text = empleado.NombreUsuario;
            txtClave.Text = empleado.Clave;
            txtFecNac.Value = empleado.FechaNac;
            txtSalario.Text = empleado.Salario.ToString();
        }

        /*
        *  Autor: Luis Carlos Pedroza Pineda 
        *  Evento que guarda los datos editados del empleado y cierra la ventana
        *  dejando el foco en la tabla de empleados
        */
        private void BtnTerminar_Click(object sender, EventArgs evt) {
            if (validar()) {
                empleado = db.Empleados.Where(e => e.Id == empleado.Id).Single();
                empleado.Persona.PrimerNombre = txtPrimerNombre.Text;
                empleado.Persona.SegundoNombre = txtSegundoNombre.Text;
                empleado.Persona.PrimerApellido = txtPrimerApellido.Text;
                empleado.Persona.SegundoApellido = txtSegundoApellido.Text;
                empleado.Persona.TiposDeDocumento = (TipoDeDocumento)cbTipoDoc.SelectedItem;
                empleado.Persona.NumeroDocumento = txtNumIde.Text;
                empleado.Persona.Generos = (Genero)cbGeneros.SelectedItem;
                empleado.FechaNac = txtFecNac.Value;
                empleado.Celular = txtCelular.Text;
                empleado.Email = txtCorreo.Text;
                empleado.Rol = (Rol)cbRoles.SelectedItem;
                empleado.Profesion = txtProfesion.Text;
                empleado.Dirreccion = txtDireccion.Text;
                empleado.NombreUsuario = txtNombreUsuario.Text;
                empleado.Clave = txtClave.Text;
                empleado.Salario = Convert.ToDouble(txtSalario.Text);

                var editarEmpleadoDao = new EmpleadoDao(db);

                if (editarEmpleadoDao.editarEmpleado(empleado) != null) {
                    MessageBox.Show("El empleado ha sido editado correctamente");
                    Close();
                } else {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }

        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Método privado que valida que los campos no estén vacíos 
        */
        private bool validar() {
            if (!Validacion.validarCampoVacio(txtPrimerNombre)) {
                MessageBox.Show("El campo Primer Nombre no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSegundoNombre)) {
                MessageBox.Show("El campo Segundo Nombre no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtPrimerApellido)) {
                MessageBox.Show("El campo Primer Apellido no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSegundoApellido)) {
                MessageBox.Show("El campo Segundo Apellido no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtDireccion)) {
                MessageBox.Show("El campo Dirección no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtProfesion)) {
                MessageBox.Show("El campo Profesión no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtNumIde)) {
                MessageBox.Show("El campo Número de Identificación no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtCorreo)) {
                MessageBox.Show("El campo Correo no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtCelular)) {
                MessageBox.Show("El campo Celular no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtNombreUsuario)) {
                MessageBox.Show("El campo Nombre de Usuario no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtClave)) {
                MessageBox.Show("El campo Clave no puede estar vacío");
                return false;
            }

            if (!Validacion.validarCombobox(cbRoles)) {
                MessageBox.Show("Debe seleccionar un rol");
                return false;
            }

            if (!Validacion.validarCombobox(cbGeneros)) {
                MessageBox.Show("Debe seleccionar un género");
                return false;
            }

            if (!Validacion.validarCombobox(cbTipoDoc)) {
                MessageBox.Show("Debe seleccionar un tipo de documento");
                return false;
            }

            if (!Validacion.validarCampoVacio(txtSalario)) {
                MessageBox.Show("El campo Salario no puede estar vacío");
                return false;
            }

            return true;
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban letras en este campo
        */
        private void txtNumIde_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban letras en este campo
        */
        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarNumeros(e);
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban números en este campo
        */
        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban números en este campo
        */
        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban números en este campo
        */
        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban números en este campo
        */
        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }

        /*
        * Autor: Luis Carlos Pedroza Pineda 
        * Evento que valida que no se escriban números en este campo
        */
        private void txtProfesion_KeyPress(object sender, KeyPressEventArgs e) {
            Validacion.ValidarLetras(e);
        }
    }
}
