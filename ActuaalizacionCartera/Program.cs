using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Negocio.Actualizacion;

namespace ActuaalizacionCartera
{
    class Program
    {
        static void Main(string[] args)
        {
            EnvioCorreo oEnvioCorreo = new EnvioCorreo();
            ActualizacionCarteraNegocio oActualizacion = new ActualizacionCarteraNegocio(); 

            int vActualizacion = oEnvioCorreo.ActualizacionPeriodica();

            if (vActualizacion == 1)
            {
                oEnvioCorreo.EnviarCorreos();
                oActualizacion.InsertaBitacora("CARTERA", "La actualización se ejecutó con éxito");
            }
            else
            {
                oActualizacion.InsertaBitacora("CARTERA", "Error en el proceso de actualización");
            }

            oEnvioCorreo.EliminarSolicitudesEnviadas();
        }
    }
}
