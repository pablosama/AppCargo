//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DomainModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class transacciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public transacciones()
        {
            this.valoraciones = new HashSet<valoraciones>();
        }
    
        public int id_transaccion { get; set; }
        public int id_itinerario { get; set; }
        public int id_escala { get; set; }
        public int id_usuario_solicita { get; set; }
        public int id_usuario_oferta { get; set; }
        public System.DateTime fecha_transaccion { get; set; }
        public string observaciones { get; set; }
        public decimal valor { get; set; }
        public string estado { get; set; }
        public int id_valoracion { get; set; }
    
        public virtual escalas escalas { get; set; }
        public virtual usuarios usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<valoraciones> valoraciones { get; set; }
    }
}
