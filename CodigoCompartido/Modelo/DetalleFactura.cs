//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Compartido.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFactura
    {
        public int FacturaId { get; set; }
        public int CamisetaId { get; set; }
        public int TallaId { get; set; }
        public int GeneroId { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    
        public virtual Camiseta Camisetas { get; set; }
        public virtual Factura Facturas { get; set; }
        public virtual Genero Generos { get; set; }
        public virtual Talla Tallas { get; set; }
    }
}
