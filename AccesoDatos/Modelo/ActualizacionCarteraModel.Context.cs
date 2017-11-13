﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class ActualizacionCarteraEntities : DbContext
    {
        public ActualizacionCarteraEntities()
            : base("name=ActualizacionCarteraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int proc_CorreosSolicitudesPendientesInsert(Nullable<int> iD_Solicitud, Nullable<int> prioridad_Envio, string email, string asunto_Correo, string cuerpo_Correo, string estatus, ObjectParameter fL_VALOR_RETORNO)
        {
            var iD_SolicitudParameter = iD_Solicitud.HasValue ?
                new ObjectParameter("ID_Solicitud", iD_Solicitud) :
                new ObjectParameter("ID_Solicitud", typeof(int));
    
            var prioridad_EnvioParameter = prioridad_Envio.HasValue ?
                new ObjectParameter("Prioridad_Envio", prioridad_Envio) :
                new ObjectParameter("Prioridad_Envio", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var asunto_CorreoParameter = asunto_Correo != null ?
                new ObjectParameter("Asunto_Correo", asunto_Correo) :
                new ObjectParameter("Asunto_Correo", typeof(string));
    
            var cuerpo_CorreoParameter = cuerpo_Correo != null ?
                new ObjectParameter("Cuerpo_Correo", cuerpo_Correo) :
                new ObjectParameter("Cuerpo_Correo", typeof(string));
    
            var estatusParameter = estatus != null ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_CorreosSolicitudesPendientesInsert", iD_SolicitudParameter, prioridad_EnvioParameter, emailParameter, asunto_CorreoParameter, cuerpo_CorreoParameter, estatusParameter, fL_VALOR_RETORNO);
        }
    
        public virtual ObjectResult<proc_CorreosSolicitudesPendientesSelect_Result> proc_CorreosSolicitudesPendientesSelect(string iD_Empleado)
        {
            var iD_EmpleadoParameter = iD_Empleado != null ?
                new ObjectParameter("ID_Empleado", iD_Empleado) :
                new ObjectParameter("ID_Empleado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_CorreosSolicitudesPendientesSelect_Result>("proc_CorreosSolicitudesPendientesSelect", iD_EmpleadoParameter);
        }
    
        public virtual ObjectResult<proc_CorreosSolicitudesPendientesSelectAll_Result> proc_CorreosSolicitudesPendientesSelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_CorreosSolicitudesPendientesSelectAll_Result>("proc_CorreosSolicitudesPendientesSelectAll");
        }
    
        public virtual int proc_CorreosSolicitudesPendientesUpdate(Nullable<int> iD, Nullable<int> iD_Solicitud, Nullable<int> prioridad_Envio, string email, string asunto_Correo, string cuerpo_Correo, string estatus, ObjectParameter fL_VALOR_RETORNO)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var iD_SolicitudParameter = iD_Solicitud.HasValue ?
                new ObjectParameter("ID_Solicitud", iD_Solicitud) :
                new ObjectParameter("ID_Solicitud", typeof(int));
    
            var prioridad_EnvioParameter = prioridad_Envio.HasValue ?
                new ObjectParameter("Prioridad_Envio", prioridad_Envio) :
                new ObjectParameter("Prioridad_Envio", typeof(int));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var asunto_CorreoParameter = asunto_Correo != null ?
                new ObjectParameter("Asunto_Correo", asunto_Correo) :
                new ObjectParameter("Asunto_Correo", typeof(string));
    
            var cuerpo_CorreoParameter = cuerpo_Correo != null ?
                new ObjectParameter("Cuerpo_Correo", cuerpo_Correo) :
                new ObjectParameter("Cuerpo_Correo", typeof(string));
    
            var estatusParameter = estatus != null ?
                new ObjectParameter("Estatus", estatus) :
                new ObjectParameter("Estatus", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_CorreosSolicitudesPendientesUpdate", iDParameter, iD_SolicitudParameter, prioridad_EnvioParameter, emailParameter, asunto_CorreoParameter, cuerpo_CorreoParameter, estatusParameter, fL_VALOR_RETORNO);
        }
    
        public virtual int proc_SolicitudesEliminacionPeriodica(ObjectParameter fL_VALOR_RETORNO)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_SolicitudesEliminacionPeriodica", fL_VALOR_RETORNO);
        }
    
        public virtual ObjectResult<proc_ConfiguracionSelectAll_Result> proc_ConfiguracionSelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_ConfiguracionSelectAll_Result>("proc_ConfiguracionSelectAll");
        }
    
        public virtual int proc_CorreosSolicitudesPendientesDelete(Nullable<int> iD_Solicitud, ObjectParameter fL_VALOR_RETORNO)
        {
            var iD_SolicitudParameter = iD_Solicitud.HasValue ?
                new ObjectParameter("ID_Solicitud", iD_Solicitud) :
                new ObjectParameter("ID_Solicitud", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_CorreosSolicitudesPendientesDelete", iD_SolicitudParameter, fL_VALOR_RETORNO);
        }
    
        public virtual int SIG_INSERTA_BITACORA_SOLICITUDES_PENDIENTES(string p_CLAVE, string p_MENSAJE)
        {
            var p_CLAVEParameter = p_CLAVE != null ?
                new ObjectParameter("P_CLAVE", p_CLAVE) :
                new ObjectParameter("P_CLAVE", typeof(string));
    
            var p_MENSAJEParameter = p_MENSAJE != null ?
                new ObjectParameter("P_MENSAJE", p_MENSAJE) :
                new ObjectParameter("P_MENSAJE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SIG_INSERTA_BITACORA_SOLICITUDES_PENDIENTES", p_CLAVEParameter, p_MENSAJEParameter);
        }
    }
}