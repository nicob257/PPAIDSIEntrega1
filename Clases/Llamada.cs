using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PPAIDSIEntrega1.Clases
{
    public class Llamada
    {
        private int Id;
        private string DescripcionOperador ;
        private string DetalleOpcionRequerida;
        private string Duracion;
        private bool EncuestaEnviada;
        private string ObservacionAuditor;
        private Cliente ClienteAsociado;
        private List<CambioEstado> CambiosEst;
        private List<RespuestaDeCliente> RespuestasCliente;

        


        public Llamada(int id, string desc, string detalleOpReq, string duracion, bool encuestaEnviada, string observAuditor, string dniCl, string nomCl, string nroCelCl)
        {
            Id = id;
            DescripcionOperador = desc;
            DetalleOpcionRequerida = detalleOpReq;
            Duracion = duracion;
            EncuestaEnviada = encuestaEnviada;
            ObservacionAuditor = observAuditor;
            ClienteAsociado = new Cliente(dniCl, nomCl, nroCelCl);
            CambiosEst = new List<CambioEstado>();
            CambioEstado primerCambioEstado = new CambioEstado("Iniciada");
            CambiosEst.Add(primerCambioEstado);
            RespuestasCliente = new List<RespuestaDeCliente>();

        }

        // Función para verificar si una llamada tiene encuesta respondida
       public bool tieneEncuestaRespondida()
        {
            return EncuestaEnviada;
        }


        // Función para verificar si la llamada es del período comprendido entre la fecha de inicio y la fecha de fin elegidas por el usuario
        public bool esDePeriodo(DateTime filtroInicio, DateTime filtroFin)
        {
            DateTime? fecha = null;
            for (int i = 0; i < this.CambiosEst.Count; i++)
            {
                if (this.CambiosEst[i].esEstadoInicial())
                    fecha = this.CambiosEst[i].getFechaInicio;
                    
            }
            return (fecha >= filtroInicio && fecha <= filtroFin);   
        }



        // Función para obtener los datos de la llamada, se le pasa como parámetro el gestor asociado para poder guardar en el las respuestas
        public List<string> obtenerDatosLlamada(GestorConsultarEncuesta gestor)
        {
            // Se crea una lista donde vamos a guardar: Nombre del Cliente Asociado, nombre del Estado actual y  Duracion de llamada
            List<String> textos = new List<string>();
            textos.Add(ClienteAsociado.obtenerNombreCliente());
            for (int i = 0; i < CambiosEst.Count; i++)
            {
                //nuevo
                //textos.Add(i.ToString()); //linea de mas
                if (CambiosEst[i].esActual())
                {
                    textos.Add(CambiosEst[i].obtenerEstado());
                }
            }
            textos.Add(Duracion);
            

            // Seteamos el array de respuestas del gestor
            gestor.setArrayRespuestas(getRespuestas());
            return textos;

        }

        // Función para obtener las respuestas del cliente
        public List<string> getRespuestas()
        {
            List<String> textos = new List<string>();
            for (int i = 0; i < this.RespuestasCliente.Count; i++)
            {
                textos.Add(this.RespuestasCliente[i].obtenerDatosRta());
            }
            return textos;
        }


        // Función de soporte para obtener los Ids de las Respuestas del Cliente
        public List<int> obtenerIdsRp()
        {
            List<int> listaIds = new List<int>();
            for (int i = 0; i< this.RespuestasCliente.Count; i++)
            {
                listaIds.Add(this.RespuestasCliente[i].obtenerId());
            }
            return listaIds;
        }


        // Función para obtener el Id de la llamada
        public int getId()
        {
            return Id;
        }


        // Función para agregar una respuesta del cliente a una llamada
        public void agregarRc(RespuestaDeCliente rc)
        {
            RespuestasCliente.Add(rc);
        }


        // Función para actualizar el estado de la llamada, poniendo como fin del CE anterior la fecha actual y agregando 
        // un nuevo Ce pasado como parámetro
        public void actualizarEstado(CambioEstado nuevoCe)
        {
            CambiosEst[CambiosEst.Count -1].FinEstado = DateTime.Now;
            CambiosEst.Add(nuevoCe);
        }

        // Getter del Id mediante el nombre "getid"
        public int getid
        {
            get => Id;
        }
    }
}
