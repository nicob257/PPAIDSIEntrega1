using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAIDSIEntrega1.Clases
{
    public class GestorConsultarEncuesta
    {
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private List<Llamada> arrayLlamadas;
        private List<int> arrayIdsRP;
        private int seleccionLlamada;
        private List<string> datosLlamadaSeleccionada;
        public FiltroForm PantallaAsociada;
        private List<int>arrayIdLlamadas;
        private string descEncuesta;
        private string descPreguntas;
        private List<Encuesta> arrayEncuestas;



        public GestorConsultarEncuesta(FiltroForm pantalla)
        {
            //fechaInicio = null;
            //fechaFin = null;
            arrayLlamadas = new List<Llamada>();
            arrayIdsRP = new List<int>();
            datosLlamadaSeleccionada = new List<string>();
            PantallaAsociada = pantalla;
            arrayEncuestas = new List<Encuesta>();
            arrayIdLlamadas = new List<int>();

        }

        public void consultarEncuesta()
        {
            //List<Llamada> arrayLlamadas = new List<Llamada>();
            Llamada llam1 = new Llamada(1, "", "", "6m20s", true, "", "39924511", "Matias", "3513221641");
            Llamada llam2 = new Llamada(2, "", "", "12m46s", true, "", "32115644", "Facundo", "3516428615");
            CambioEstado ceLlam2 = new CambioEstado("finalizado");
            llam2.actualizarEstado(ceLlam2);
            CambioEstado ceLlam1 = new CambioEstado("finalizado");
            llam1.actualizarEstado(ceLlam1);
            //List<Encuesta> arrayEncuestas = new List<Encuesta>();
            Encuesta enc1 = new Encuesta("Atencion al cliente", "25/8/2025");
            Pregunta preg1 = new Pregunta("¿Te sentiste cómodo con la atención brindada?");
            RespuestaPosible rp1 = new RespuestaPosible("Si", "Si", 1);
            RespuestaPosible rp2 = new RespuestaPosible("No", "No", 2);
            RespuestaDeCliente rdc1 = new RespuestaDeCliente("17-05-22", rp1);
            Pregunta preg2 = new Pregunta("¿Se resolvio tu problema?");
            RespuestaPosible rp3 = new RespuestaPosible("Si", "Si", 1);
            RespuestaPosible rp4 = new RespuestaPosible("No", "No", 2);
            RespuestaDeCliente rdc2 = new RespuestaDeCliente("17-05-22", rp4);
            llam1.agregarRc(rdc2);
            preg2.agregarRp(rp3);
            llam2.agregarRc(rdc2);
            preg2.agregarRp(rp4);
            enc1.agregarPregunta(preg2);
            llam1.agregarRc(rdc1);
            preg1.agregarRp(rp1);
            preg1.agregarRp(rp2);
            enc1.agregarPregunta(preg1);
            arrayEncuestas.Add(enc1);
            arrayLlamadas.Add(llam1);
            arrayLlamadas.Add(llam2);
            PantallaAsociada.pedirSeleccionFechaPeriodo();
        }

        public void tomarPeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            fechaInicio = fechaDesde;
            fechaFin = fechaHasta;
            buscarLlamadasConEncuestasRespondidas();
        }

        public void buscarLlamadasConEncuestasRespondidas()
        {
            int posY = 17;
            int separacionY = 25;
            for (int i = 0; i < arrayLlamadas.Count; i++)
            {
                if (arrayLlamadas[i].esDePeriodo(fechaInicio, fechaFin) && arrayLlamadas[i].tieneEncuestaRespondida())
                {
                    //RadioButton radBtn = new RadioButton();
                    //radBtn.Text = "Llamada " + arrayLlamadas[i].getId().ToString();
                    //radBtn.Name = arrayLlamadas[i].getId().ToString();
                    //radBtn.Left = 8;
                    //radBtn.Top = posY;
                    //PantallaAsociada.Controls.Add(radBtn);
                    //posY += separacionY;
                    //radBtn.CheckedChanged += RadBtn_CheckedChanged;
                    arrayIdLlamadas.Add(arrayLlamadas[i].getid);
                    PantallaAsociada.pedirSeleccionLlamada(arrayIdLlamadas);
                }
            }
        }


        public void tomarSeleccionLlamada(int id)
        {
            mostrarDatosLlamada(id);
          
        }

        public void mostrarDatosLlamada(int id)
        {
            seleccionLlamada = id;
            for (int i = 0; i < arrayLlamadas.Count; i++)
            {
                if (arrayLlamadas[i].getid.Equals(id-1))
                {
                    arrayLlamadas[i].obtenerDatosLlamada();
                }

            }
            arrayIdsRP = arrayLlamadas[id - 1].obtenerIdsRp();
            for (int i = 0; i < arrayEncuestas.Count; i++)
            {
                //MessageBox.Show(arrayLlamadas[idLlamada - 1].obtenerIdsRp().ToString());
                //MessageBox.Show(arrayIdsRP[0].ToString());
                if (arrayEncuestas[i].esEncuestaDeCliente(arrayIdsRP[0]))
                {
                    descEncuesta = arrayEncuestas[i].getDescripcionEncuesta();
                    descPreguntas = arrayEncuestas[i].obtenerPreguntas();
                }
            }


            //List<string> datosLlamada = null;
            datosLlamadaSeleccionada = arrayLlamadas[seleccionLlamada - 1].obtenerDatosLlamada();
            //List<int> arrayIdsRP = arrayLlamadas[seleccionLlamada - 1].obtenerIdsRp();
            DataGridViewRow fila = new DataGridViewRow();

            DataGridViewTextBoxCell celdaCliente = new DataGridViewTextBoxCell();
            celdaCliente.Value = datosLlamadaSeleccionada[0];
            fila.Cells.Add(celdaCliente);

            DataGridViewTextBoxCell celdaEstadoActual = new DataGridViewTextBoxCell();
            celdaEstadoActual.Value = datosLlamadaSeleccionada[1];
            fila.Cells.Add(celdaEstadoActual);

            DataGridViewTextBoxCell celdaDuracion = new DataGridViewTextBoxCell();
            celdaDuracion.Value = datosLlamadaSeleccionada[2];
            fila.Cells.Add(celdaDuracion);

            DataGridViewTextBoxCell celdaRespuestas = new DataGridViewTextBoxCell();
            celdaRespuestas.Value = datosLlamadaSeleccionada[3];
            fila.Cells.Add(celdaRespuestas);

            DataGridViewTextBoxCell celdaDescPreg = new DataGridViewTextBoxCell();
            celdaDescPreg.Value = descPreguntas;
            fila.Cells.Add(celdaDescPreg);

            DataGridViewTextBoxCell celdaDescEnc = new DataGridViewTextBoxCell();
            celdaDescEnc.Value = descEncuesta;
            fila.Cells.Add(celdaDescEnc);

            PantallaAsociada.agregarFila(fila);
        }

        
        //public void configurarManejadorClick(Button boton)
        //{
        //    boton.Click += ConsultarEncuesta;
        //}

        //public void ConsultarEncuesta(object sender, EventArgs e)
        //{
        //    FechaInicio = PantallaAsociada.getDateTimeInicio();
        //    FechaFin = PantallaAsociada.getDateTimeFin();
        //    MessageBox.Show("Hola" + FechaFin.ToString());
        //}

        //public void tomarPeriodo()
        //{

        //}
        
    }

}
