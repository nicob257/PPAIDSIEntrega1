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


        // Función que valida si la encuesta es del cliente, recibiendo como parámetro el idRP de la respuesta posible asociada a la RC
        public bool esEncuestaDeCliente(int idRP)
        {
            return tieneRtaPosible(idRP);
        }


        // Función que valida si la pregunta tiene RP igual al idRP pasado como parámetro
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


        // Función para agregar una respuesta posible a la lista de Respuestas posibles de una pregunta
        public void agregarRp(RespuestaPosible rp)
        {
            ListaRP.Add(rp);
        }


        // Función que devuelve el Texto de la Pregunta, o sea su descripción
        public string getDescripcion()
        {
            return TextoPregunta;
        }
    }
}
