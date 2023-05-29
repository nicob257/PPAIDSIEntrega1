using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    public class Cliente
    {
        private string Dni;
        private string NombreCompleto;
        private string NroCelular;

        public Cliente(string dni, string nombreCompleto, string nroCelular)
        {
            Dni = dni;
            NombreCompleto = nombreCompleto;
            NroCelular = nroCelular;
        }

        public string obtenerNombreCliente()
        {
            return NombreCompleto;
        }
    }
}
