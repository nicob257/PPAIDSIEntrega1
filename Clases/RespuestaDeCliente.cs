using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    public class RespuestaDeCliente
    {
        private string FechaEncuesta;
        private RespuestaPosible RP;
        public RespuestaDeCliente(string fechaEncuesta, RespuestaPosible rp)
        {
            FechaEncuesta = fechaEncuesta;
            RP = rp; 
        }


        // Función que devuelve los datos de la Respuesta mediante el llamado a obtenerDatos de la respuesta posible asociada
        public string obtenerDatosRta()
        {
            return this.RP.obtenerDatos();
        }

        // Función que devuelve el Id de la respuesta posible asociada
        public int obtenerId()
        {
            return this.RP.obtenerId();
        }
    }
}
