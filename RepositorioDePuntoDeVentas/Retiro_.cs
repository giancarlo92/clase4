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
    
    public partial class Retiro_
    {
        public int id { get; set; }
        public double montoRetiro { get; set; }
        public System.DateTime HoraRetiro { get; set; }
        public int idMoneda { get; set; }
        public string idUsuario { get; set; }
        public int idTurno { get; set; }
        public string idOrdenador { get; set; }
        public System.DateTime TIME_STAMP { get; set; }
        public string Motivo { get; set; }
    
        public virtual Moneda_ Moneda_ { get; set; }
        public virtual Ordenador_ Ordenador_ { get; set; }
        public virtual Turno_ Turno_ { get; set; }
        public virtual Usuario_ Usuario_ { get; set; }
    }
}
