using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Actualizacion;
using Negocio.Utilerias;


namespace ActuaalizacionCartera
{
    class EnvioCorreo
    {
        public void EnviarCorreos() {
      
            string FontFamily  = "Century Gothic";
            string FontSize = "10pt";
            ActualizacionCarteraNegocio oActualizacion = new ActualizacionCarteraNegocio();
            var vSolicitudesPen = oActualizacion.ObtieneSolicitudesPendientes();
            var vConfiguracion = oActualizacion.ObtieneConfiguracion().FirstOrDefault();
            Mail vMail = new Mail(vConfiguracion.MailHost, int.Parse(vConfiguracion.MailPort.ToString()), vConfiguracion.MailUserName, vConfiguracion.MailUserPassword,true, vConfiguracion.MailFrom);

            if (vSolicitudesPen.Count > 0)
            {
                foreach (var s in vSolicitudesPen)
                {
                    if (s.Estatus != "OK"){
                        if (s.Email != "NOTIENEEMAIL")
                        {
                            var vSuject = s.AsuntoCorreo;
                            var vMensaje = String.Format("{0}", " <html><head><meta http-equiv='Content-Language' content='es-mx'> <meta http-equiv='Content-Type' content='text/html; charset=windows-1252'><title> " + s.AsuntoCorreo + "</title> </head> <body style='font-family: " + FontFamily + "; font-size:" + FontSize + ";'>" + s.CuerpoCorreo + "</body></html>");
                            vMail.addToAddress(s.Email);
                            string vSender = vMail.Send(s.AsuntoCorreo, vMensaje, null);

                            if (vSender == "1")
                            {
                                s.Estatus = "OK";
                            }
                            else
                            {
                                s.Estatus = "ERROR";
                            }

                            oActualizacion.ActualizaSolicitudesPendientes(s.ID, s.ID_Solicitud, s.PrioridadEnvio, s.Email, s.AsuntoCorreo, s.CuerpoCorreo, s.Estatus);
                        }
                        else
                        {
                            oActualizacion.EliminaSolicitudPendiente(s.ID_Solicitud);
                        }
                    }
                }
            }
        }

        public void EliminarSolicitudesEnviadas() {
            ActualizacionCarteraNegocio oActualizacion = new ActualizacionCarteraNegocio();
            var vSolicitudesPen = oActualizacion.ObtieneSolicitudesPendientes();

            if (vSolicitudesPen.Count > 0)
            {
                foreach (var s in vSolicitudesPen)
                {
                    if (s.Estatus == "OK")
                    {
                        oActualizacion.EliminaSolicitudPendiente(s.ID_Solicitud);
                    }
                }
            }
        }

        public int ActualizacionPeriodica(){
            ActualizacionCarteraNegocio oActualizacion = new ActualizacionCarteraNegocio();
            int vRes = oActualizacion.EliminaSolicitudesPeriodicas();
            return vRes;
        }

    }
}
