//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    
    public partial class proc_CorreosSolicitudesPendientesSelectAll_Result
    {
        public int ID { get; set; }
        public int ID_Solicitud { get; set; }
        public Nullable<int> MailItem_ID { get; set; }
        public Nullable<int> PrioridadEnvio { get; set; }
        public string Email { get; set; }
        public string AsuntoCorreo { get; set; }
        public string CuerpoCorreo { get; set; }
        public string Estatus { get; set; }
    }
}