﻿using System;
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

        public List<string> obtenerDatosLlamada()
        {
            List<String> textos = new List<string>();
            // textos.AddRange(new string[] { DescripcionOperador, DetalleOpcionRequerida, Duracion, EncuestaEnviada.ToString(),
            //    ObservacionAuditor, ClienteAsociado.obtenerNombreCliente() });
            // ANTES
            // 0 = DescripcionOperador
            // 1 = DetalleOpcionRequerida
            // 2 = Duracion
            // 3 = EncuestaEnviada.ToString();
            // 4 = ObservacionAuditor
            // 5 = ClienteAsociado.obtenerNombreCliente
            // 6 = ClienteAsociado.obtenerNombreCliente()


            // AHORA
            // 0 = Nombre Cliente
            // 1 = Estado Actual
            // 2 = Duracion
            // 3 = Respuestas
            textos.Add(ClienteAsociado.obtenerNombreCliente());
            for (int i = 0; i < CambiosEst.Count; i++)
            {
                if (CambiosEst[i].esActual())
                {
                    textos.Add(CambiosEst[i].obtenerEstado());
                }
            }
            textos.Add(Duracion);
            textos.Add(getRespuestas());
            return textos;






            //string texto = "";
            //texto = "Descripción de operador: " + DescripcionOperador + " | Detalle Opcion requerida: "
            //    + DetalleOpcionRequerida + " | Duración: " + Duracion + " | Encuesta enviada: " +
            //    EncuestaEnviada.ToString() + " | Observación de auditor: " + ObservacionAuditor +
            //    " Nombre del cliente: " + ClienteAsociado.obtenerNombreCliente();

            //private string DescripcionOperador;
            //private string DetalleOpcionRequerida;
            //private string Duracion;
            //private bool EncuestaEnviada;
            //private string ObservacionAuditor;
            //private Cliente ClienteAsociado;
            //private List<CambioEstado> CambiosEst;
            //private List<RespuestaDeCliente> RespuestasCliente;

        }
        public string getRespuestas()
        {
            string texto = "";
            for (int i = 0; i < this.RespuestasCliente.Count; i++)
            {
                texto += (this.RespuestasCliente[i].obtenerDatosRta() + ", " + '\n');
            }
            return texto;
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