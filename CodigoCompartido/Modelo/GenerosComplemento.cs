﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compartido.Modelo {
    public partial class Genero {
        public override string ToString() {
            return Nombre;
        }

        public override bool Equals(object obj) {
            if (obj == null) {
                return false;
            }

            if (obj is Genero) {
                return Id == ((Genero)obj).Id;
            }

            return false;
        }
    }
}