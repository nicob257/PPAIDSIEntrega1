using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    internal class Pregunta
    {
        private string TextoPregunta;
        private List<RespuestaPosible> ListaRP;
        public Pregunta(string texto)
        {
            TextoPregunta = texto;
            ListaRP = new List<RespuestaPosible>();
        }

        public bool esEncuestaDeCliente(int idRP)
        {
            return tieneRtaPosible(idRP);
        }

        public bool tieneRtaPosible(int idRP)
        {
            for (int i = 0; i < ListaRP.Count; i++)
            {
                if (ListaRP[i].obtenerId().Equals(idRP))
                {
                    return true;
                }
            }
            return false;
        }

        public void agregarRp(RespuestaPosible rp)
        {
            ListaRP.Add(rp);
        }

        public string getDescripcion()
        {
            return TextoPregunta;
        }
    }
}
