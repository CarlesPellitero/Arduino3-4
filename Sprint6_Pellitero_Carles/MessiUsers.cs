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
    
    public partial class MessiUsers
    {
        public int idMessiUser { get; set; }
        public int idDevice { get; set; }
        public int idUser { get; set; }
    
        public virtual TrustedDevices TrustedDevices { get; set; }
        public virtual Users Users { get; set; }
    }
}