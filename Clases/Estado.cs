using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    public class Estado
    {
        private string Nombre;
        public Estado(string nombre)
        {
            Nombre = nombre;
        }


        // Función que valida si el estado de la llamada es iniciada
        public bool esIniciada()
        {
            return this.Nombre.Equals("Iniciada");
        }


        // Función que reotrna el nombre del estado
        public string getNombre()
        {
            return Nombre;
        }
    }
}
