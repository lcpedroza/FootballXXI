﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compartido.Modelo;

namespace Compartido.Dao {
    public class EmpleadoDao {
        private Entidades db;

        public EmpleadoDao(Entidades db) {
            this.db = db;
        }

        public Empleado Login(string usuario, string clave) {
            var consulta = from e in db.Empleados
                           where e.NombreUsuario == usuario && e.Clave == clave
                           select e;

            return consulta.SingleOrDefault();
        }

        public Empleado CrearEmpleado(Empleado empleado) {
            db.Empleados.Add(empleado);
            db.SaveChanges();
            return empleado;
        }

        public List<Empleado> GetEmpleados() {
            return db.Empleados.ToList();
        }

        public Empleado buscarVendedor(string numeroDocumento) {
            var consulta = from e in db.Empleados
                           where e.Persona.NumeroDocumento == numeroDocumento
                           select e;

            return consulta.SingleOrDefault();
        }

        public Empleado editarEmpleado(Empleado empleado) {
            db.SaveChanges();
            return empleado;
        }

        public List<PagoEmpleados> GetNomina() {
            var consulta = from e in db.Empleados
                           select new {
                               Codigo = e.Id,
                               Nombres = e.Persona.PrimerNombre + " " + e.Persona.SegundoNombre,
                               Apellidos = e.Persona.PrimerApellido + " " + e.Persona.SegundoApellido,
                               Cargo = e.Rol,
                               SalarioBasico = e.Salario,
                               UltimaFechaPago = (
                                    from p in db.Pagos where p.EmpleadoId == e.Id
                                    select (DateTime?)p.FechaPago
                               ).Max()
                           };
            var datos = consulta.ToList();
            var pagoEmpleados = new List<PagoEmpleados>();
            foreach (var pe in datos) {
                pagoEmpleados.Add(new PagoEmpleados {
                    Codigo = pe.Codigo,
                    Nombres = pe.Nombres,
                    Apellidos = pe.Apellidos,
                    Cargo = pe.Cargo,
                    SalarioBasico = pe.SalarioBasico,
                    UltimaFechaPago = pe.UltimaFechaPago,

                });
            }
            return pagoEmpleados;
        }
    }
}
