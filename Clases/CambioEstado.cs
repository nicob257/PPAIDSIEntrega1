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


        // Esta función verifica si el estado asociado al CE es el inicial, retornando true o false
        public bool esEstadoInicial() 
        {
            return this.EstadoAsociado.esIniciada();
        }


        // Esta función devuelve la fecha de inicio mediante un getter
        public DateTime getFechaInicio
        {
            get => FechaHoraInicio;
        }


        // Esta función chequea si el estado es actual, mediante el getter de la fecha de fin del CE
        // "FinEstado", comprobando si el mismo devuelve null
        public bool esActual()
        {
            return FinEstado.Equals(null);
        }


        // Función que devuelve el nombre del estado asociado a este CE
        public string obtenerEstado()
        {
            return this.EstadoAsociado.getNombre();
        }


        // getter y setter de la FechaHoraFin mediante el nombre "FinEstado"
        public DateTime? FinEstado
        {
            get => FechaHoraFin;
            set => FechaHoraFin = value;
        }

    }
}
