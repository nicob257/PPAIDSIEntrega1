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

        public bool esIniciada()
        {
            return this.Nombre.Equals("Iniciada");
        }

        public string getNombre()
        {
            return Nombre;
        }
    }
}
