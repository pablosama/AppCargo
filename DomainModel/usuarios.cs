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
    
    public partial class usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuarios()
        {
            this.itinerarios = new HashSet<itinerarios>();
            this.transacciones = new HashSet<transacciones>();
            this.transporte = new HashSet<transporte>();
            this.valoraciones = new HashSet<valoraciones>();
        }
    
        public int id_usuario { get; set; }
        public string alias { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo_usuario { get; set; }
        public string telefono_movil { get; set; }
        public string codigo_area { get; set; }
        public string telefono_fijo { get; set; }
        public string mail { get; set; }
        public int id_comuna { get; set; }
        public string direccion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public System.DateTime fecha_actualizacion { get; set; }
        public string estado { get; set; }
    
        public virtual ciudades ciudades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<itinerarios> itinerarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transacciones> transacciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<transporte> transporte { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<valoraciones> valoraciones { get; set; }
    }
}
