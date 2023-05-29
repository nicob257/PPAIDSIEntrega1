using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PPAIDSIEntrega1.Clases
{
    public class CambioEstado
    {
        private DateTime FechaHoraInicio;
        private DateTime? FechaHoraFin;
        private Estado EstadoAsociado;
        public CambioEstado(string nombre)
        {
            FechaHoraInicio = DateTime.Now;
            FechaHoraFin = null;
            EstadoAsociado = new Estado(nombre);
        }

        public bool esEstadoInicial()
        {
            return this.EstadoAsociado.esIniciada();
        }

        public DateTime getFechaInicio
        {
            get => FechaHoraInicio;
        }

        public bool esActual()
        {
            return FinEstado.Equals(null);
        }

        public string obtenerEstado()
        {
            return this.EstadoAsociado.getNombre();
        }

        public DateTime? FinEstado
        {
            get => FechaHoraFin;
            set => FechaHoraFin = value;
        }

    }
}
