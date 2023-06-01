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
       public bool tieneEncuestaRespondida()
        {
            return EncuestaEnviada;
        }

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

        public List<string> obtenerDatosLlamada(GestorConsultarEncuesta gestor)
        {
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
            
            gestor.setArrayRespuestas(getRespuestas());
            return textos;

        }
        public List<string> getRespuestas()
        {
            List<String> textos = new List<string>();
            for (int i = 0; i < this.RespuestasCliente.Count; i++)
            {
                textos.Add(this.RespuestasCliente[i].obtenerDatosRta());
            }
            return textos;
        }

        public List<int> obtenerIdsRp()
        {
            List<int> listaIds = new List<int>();
            for (int i = 0; i< this.RespuestasCliente.Count; i++)
            {
                listaIds.Add(this.RespuestasCliente[i].obtenerId());
            }
            return listaIds;
        }

        public int getId()
        {
            return Id;
        }

        public void agregarRc(RespuestaDeCliente rc)
        {
            RespuestasCliente.Add(rc);
        }

        public void actualizarEstado(CambioEstado nuevoCe)
        {
            CambiosEst[CambiosEst.Count -1].FinEstado = DateTime.Now;
            CambiosEst.Add(nuevoCe);
        }

        public int getid
        {
            get => Id;
        }
    }
}
