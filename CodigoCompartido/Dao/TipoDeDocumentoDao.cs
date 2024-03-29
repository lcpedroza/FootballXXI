﻿using Compartido.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Dao {
    public class TipoDeDocumentoDao {

        private Entidades db;

        public TipoDeDocumentoDao(Entidades db) {
            this.db = db;
        }
        /*
         * Autor: Johan Sebastian Piza Acosta
       * Método que devuelve una lista de tipoDocumento
       */
        public List<TipoDeDocumento> GetTiposDeDocumento() {
            return db.TiposDeDocumento.ToList();
        }
    }
}
