//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sprint6_Pellitero_Carles
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrustedDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrustedDevice()
        {
            this.MessiUsers = new HashSet<MessiUser>();
        }
    
        public int idDevice { get; set; }
        public string MAC { get; set; }
        public string HostName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MessiUser> MessiUsers { get; set; }
    }
}
