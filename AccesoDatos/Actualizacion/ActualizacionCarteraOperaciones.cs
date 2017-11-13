using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;
using System.Data.Objects;


namespace AccesoDatos.Actualizacion
{
    public class ActualizacionCarteraOperaciones
    {
        ActualizacionCarteraEntities context;

        public List<proc_CorreosSolicitudesPendientesSelect_Result> ObtenerSolicitudPendiente(string pIdEmpleado = null)
        {
            using (context = new ActualizacionCarteraEntities())
            {
                return context.proc_CorreosSolicitudesPendientesSelect(pIdEmpleado).ToList();
            }
        }

        public List<proc_CorreosSolicitudesPendientesSelectAll_Result> ObtenerSolicitudesPendientes()
        {
            using (context = new ActualizacionCarteraEntities())
            {
                return context.proc_CorreosSolicitudesPendientesSelectAll().ToList();
            }
        }

        public List<proc_ConfiguracionSelectAll_Result> ObtenerConfiguracion()
        {
            using (context = new ActualizacionCarteraEntities())
            {
                return context.proc_ConfiguracionSelectAll().ToList();
            }
        }

        public int EliminarSolicitudPendiente(int? pIdSolicitud)
        {
            using (context = new ActualizacionCarteraEntities())
            {
                ObjectParameter poutClaveRetorno = new ObjectParameter("FL_VALOR_RETORNO", typeof(int));
                context.proc_CorreosSolicitudesPendientesDelete(pIdSolicitud, poutClaveRetorno);
                return int.Parse(poutClaveRetorno.Value.ToString());
            }
        }

        public int  EliminarSolicitudesPeriodicas()
        {
            using (context = new ActualizacionCarteraEntities())
            {
                ObjectParameter poutClaveRetorno = new ObjectParameter("FL_VALOR_RETORNO", typeof(int));
                context.proc_SolicitudesEliminacionPeriodica(poutClaveRetorno);
                return int.Parse(poutClaveRetorno.Value.ToString());
            }
        }

        public int InsertarSolicitudesPendientes(int? pIdSolicitud , int? pPrioridadEnvio, string pEmail, string pAsuntoCorreo, string pCuerpoCorreo, string pStatus)
        {
            using (context = new ActualizacionCarteraEntities())
            {
                ObjectParameter poutClaveRetorno = new ObjectParameter("FL_VALOR_RETORNO", typeof(int));
                context.proc_CorreosSolicitudesPendientesInsert(pIdSolicitud, pPrioridadEnvio, pEmail, pAsuntoCorreo, pCuerpoCorreo, pStatus, poutClaveRetorno);
                return int.Parse(poutClaveRetorno.Value.ToString());
            }
        }

        public int ActualizarSolicitudesPendientes( int? pId, int? pIdSolicitud, int? pPrioridadEnvio, string pEmail, string pAsuntoCorreo, string pCuerpoCorreo, string pStatus)
        {
            using (context = new ActualizacionCarteraEntities())
            {
                ObjectParameter poutClaveRetorno = new ObjectParameter("FL_VALOR_RETORNO", typeof(int));
                context.proc_CorreosSolicitudesPendientesUpdate(pId, pIdSolicitud, pPrioridadEnvio, pEmail, pAsuntoCorreo, pCuerpoCorreo, pStatus, poutClaveRetorno);
                return int.Parse(poutClaveRetorno.Value.ToString());
            }
        }

        public void InsertarBitacora( string pClave, string pMensaje)
        {
            using (context = new ActualizacionCarteraEntities())
            {
                context.SIG_INSERTA_BITACORA_SOLICITUDES_PENDIENTES(pClave, pMensaje);
            }
        }
    }
}
