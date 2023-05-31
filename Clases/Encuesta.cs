using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    internal class Encuesta
    {
        private string Descripcion;
        private string FechaFinVigencia;
        private List<Pregunta> ListaPreguntas;

        public Encuesta(string descripcion, string fechaFinVigencia)
        {
            Descripcion = descripcion;
            FechaFinVigencia = fechaFinVigencia;
            ListaPreguntas = new List<Pregunta>();
        }

        public bool esEncuestaDeCliente(int idRP)
        {
            bool respuesta = false;
            for (int i = 0; i < ListaPreguntas.Count; i++)
            {
                if(ListaPreguntas[i].esEncuestaDeCliente(idRP))
                {
                    respuesta = true;
                };
            }
            return respuesta;
        }

        public void agregarPregunta(Pregunta preg)
        {
            ListaPreguntas.Add(preg);
        }

        public string getDescripcionEncuesta()
        {
            return Descripcion;
        }

        public List<string> obtenerPreguntas()
        {
            List<String> textos = new List<String>();
            for (int i = 0; i < ListaPreguntas.Count; i++)
            {
                textos.Add(ListaPreguntas[i].getDescripcion());
            }
            return textos;
        }
    }
}
