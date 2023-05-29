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

        public string obtenerDatosRta()
        {
            return this.RP.obtenerDatos();
        }
        public int obtenerId()
        {
            return this.RP.obtenerId();
        }
    }
}
