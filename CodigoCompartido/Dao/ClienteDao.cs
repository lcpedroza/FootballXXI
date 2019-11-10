﻿using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class ClienteDao {

        private Entidades db;

        public ClienteDao(Entidades db) {
            this.db = db;
        }

        public Cliente CrearCliente(Cliente cliente) {
            db.Clientes.Add(cliente);
            db.SaveChanges();
            return cliente;
        }

        public List<Cliente> GetClientes() {
            return db.Clientes.ToList();
        }
    }
}