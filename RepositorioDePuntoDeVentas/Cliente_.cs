//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepositorioDePuntoDeVentas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cliente_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente_()
        {
            this.Venta_ = new HashSet<Venta_>();
        }
    
        public int id { get; set; }
        public string ruc { get; set; }
        public string razonSocial { get; set; }
        public double maxCredit { get; set; }
        public int cantidadDeDias { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_> Venta_ { get; set; }
    }
}
