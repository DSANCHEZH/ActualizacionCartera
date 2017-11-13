using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos.Actualizacion;

namespace Negocio.Actualizacion
{
    public class ActualizacionCarteraNegocio
    {
        public List<proc_CorreosSolicitudesPendientesSelect_Result> ObtieneSolicitudPendiente(string pId_Empleado = null)
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            return oPeriodo.ObtenerSolicitudPendiente(pId_Empleado);
        }

        public List<proc_CorreosSolicitudesPendientesSelectAll_Result> ObtieneSolicitudesPendientes()
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            return oPeriodo.ObtenerSolicitudesPendientes();
        }

        public List<proc_ConfiguracionSelectAll_Result> ObtieneConfiguracion()
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            return oPeriodo.ObtenerConfiguracion();
        }

        public int EliminaSolicitudPendiente(int pIdSolicitud)
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            int vResul = oPeriodo.EliminarSolicitudPendiente(pIdSolicitud);
            return vResul; 
        }

        public int EliminaSolicitudesPeriodicas()
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            int vResul = oPeriodo.EliminarSolicitudesPeriodicas();
            return vResul;
        }

        public int InsertaSolicitudesPendientes(int? pIdSolicitud = null, int? pPrioridadEnvio = null, string pEmail = null, string pAsuntoCorreo = null, string pCuerpoCorreo = null, string pStatus = null)
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            int vResul = oPeriodo.InsertarSolicitudesPendientes(pIdSolicitud, pPrioridadEnvio, pEmail, pAsuntoCorreo, pCuerpoCorreo, pStatus);
            return vResul;
        }

        public int ActualizaSolicitudesPendientes(int? pId = null, int? pIdSolicitud = null, int? pPrioridadEnvio = null, string pEmail = null, string pAsuntoCorreo = null, string pCuerpoCorreo = null, string pStatus = null)
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            int vResul = oPeriodo.ActualizarSolicitudesPendientes( pId, pIdSolicitud, pPrioridadEnvio, pEmail, pAsuntoCorreo, pCuerpoCorreo, pStatus);
            return vResul;
        }

        public void InsertaBitacora(string pClave = null, string pMensaje = null)
        {
            ActualizacionCarteraOperaciones oPeriodo = new ActualizacionCarteraOperaciones();
            oPeriodo.InsertarBitacora(pClave, pMensaje);
        }
    }
}
