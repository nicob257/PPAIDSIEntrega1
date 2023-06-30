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


        // Función que recibe como parámetro un idRP y verifica si la encuesta es del cliente, recorriendo la lista de  preguntas y invocando
        //  en cada una la función esEncuestaDeCliente con el id recibido como parámetro
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


        // Funcion para agregar una pregunta (recibida como parámetro) a la lista de preguntas de la encuesta
        public void agregarPregunta(Pregunta preg)
        {
            ListaPreguntas.Add(preg);
        }


        // Función que devuelve la descripción de la encuesta
        public string getDescripcionEncuesta()
        {
            return Descripcion;
        }


        // Función que obtiene las preguntas de la encuesta
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
