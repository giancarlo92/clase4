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
    
    public partial class Tarifa_local
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tarifa_local()
        {
            this.DetalleVenta_ = new HashSet<DetalleVenta_>();
        }
    
        public int id { get; set; }
        public int tipoServicio { get; set; }
        public string idDistritoFin { get; set; }
        public Nullable<int> idZonaFin { get; set; }
        public string idDistritoInicio { get; set; }
        public Nullable<int> idZonaInicio { get; set; }
        public int idTipoAuto { get; set; }
        public double tarifa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleVenta_> DetalleVenta_ { get; set; }
        public virtual Distrito_ Distrito_ { get; set; }
        public virtual Distrito_ Distrito_1 { get; set; }
        public virtual TipoAuto_ TipoAuto_ { get; set; }
        public virtual Zona_ Zona_ { get; set; }
        public virtual Zona_ Zona_1 { get; set; }
    }
}