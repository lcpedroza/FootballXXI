﻿using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    class PersonaDao {
        private Entidades db;

        public PersonaDao(Entidades db) {
            this.db = db;
        }

        /*
         * Autor: Luis Carlos Pedroza Pineda
        * Método que crea una persona
        */
        public Persona CrearPersona(Persona persona) {
            db.Personas.Add(persona);
            db.SaveChanges();
            return persona;
        }
    }
}
