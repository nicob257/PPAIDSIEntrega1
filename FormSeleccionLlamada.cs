using PPAIDSIEntrega1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PPAIDSIEntrega1
{
    public partial class FormSeleccionLlamada : Form
    {
        public FormSeleccionLlamada(DateTime fechaInicio, DateTime fechaFin)
        {
            InitializeComponent();
            List<Llamada> arrayLlamadas = new List<Llamada>();
            Llamada llam1 = new Llamada(1, "", "", "6m20s", true, "", "39924511", "Matias", "3513221641");
            Llamada llam2 = new Llamada(2, "", "", "12m46s", true, "", "32115644", "Facundo", "3516428615");
            CambioEstado ceLlam2 = new CambioEstado("finalizado");
            llam2.actualizarEstado(ceLlam2);
            CambioEstado ceLlam1 = new CambioEstado("finalizado");
            llam1.actualizarEstado(ceLlam1);
            List<Encuesta> arrayEncuestas = new List<Encuesta>();
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
            // RespuestaDeCliente = 
            int posY = 17;
            int separacionY = 25;
            for (int i = 0; i < arrayLlamadas.Count; i++)
            {
                if (arrayLlamadas[i].esDePeriodo(fechaInicio, fechaFin) && arrayLlamadas[i].tieneEncuestaRespondida())
                {
                    RadioButton radBtn = new RadioButton();
                    radBtn.Text = "Llamada " + arrayLlamadas[i].getId().ToString();
                    radBtn.Name = arrayLlamadas[i].getId().ToString();
                    radBtn.Left = 8;
                    radBtn.Top = posY;
                    panelSelLlamada.Controls.Add(radBtn);
                    posY += separacionY;
                    radBtn.CheckedChanged += RadBtn_CheckedChanged;
                }
            }

            //if (llam1.esDePeriodo(fechaInicio, fechaFin) && llam1.tieneEncuestaRespondida())
            //{
            //    RadioButton radBtn = new RadioButton();
            //    radBtn.Text = llam1.getId.ToString();
            //    radBtn.Left = 8;
            //    radBtn.Top = 17;
            //    radBtn.Name = llam1.getId.ToString();
            //    panelSelLlamada.Controls.Add(radBtn);

            //}
            //else
            //{
            //    MessageBox.Show("CHAU");
            //}
            void RadBtn_CheckedChanged(object sender, EventArgs e)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Checked)
                {
                    grdLlamada.Rows.Clear();
                    int idLlamada = int.Parse(radioButton.Name);
                    //MessageBox.Show(idLlamada.ToString());
                    List<string> datosLlamada = null;
                    datosLlamada = arrayLlamadas[idLlamada-1].obtenerDatosLlamada();
                    List<int> arrayIdsRP = arrayLlamadas[idLlamada-1].obtenerIdsRp(); 
                    DataGridViewRow fila = new DataGridViewRow();

                    DataGridViewTextBoxCell celdaCliente = new DataGridViewTextBoxCell();
                    celdaCliente.Value = datosLlamada[5];
                    fila.Cells.Add(celdaCliente);

                    DataGridViewTextBoxCell celdaEstadoActual = new DataGridViewTextBoxCell();
                    celdaEstadoActual.Value = datosLlamada[6];
                    fila.Cells.Add(celdaEstadoActual);

                    DataGridViewTextBoxCell celdaDuracion = new DataGridViewTextBoxCell();
                    celdaDuracion.Value = datosLlamada[2];
                    fila.Cells.Add(celdaDuracion);

                    DataGridViewTextBoxCell celdaRespuestas = new DataGridViewTextBoxCell();
                    celdaRespuestas.Value = datosLlamada[7];
                    fila.Cells.Add(celdaRespuestas);

                    
                    string descEncuesta = "";
                    string descPreguntas = "";
                    for (int i = 0; i < arrayEncuestas.Count; i++)
                    {
                        //MessageBox.Show(arrayLlamadas[idLlamada - 1].obtenerIdsRp().ToString());
                        //MessageBox.Show(arrayIdsRP[0].ToString());
                        if(arrayEncuestas[i].esEncuestaDeCliente(arrayIdsRP[0]))
                        {
                            descEncuesta = arrayEncuestas[i].getDescripcionEncuesta();
                            descPreguntas = arrayEncuestas[i].obtenerPreguntas();
                        }
                    }
                    DataGridViewTextBoxCell celdaDescPreg = new DataGridViewTextBoxCell();
                    celdaDescPreg.Value = descPreguntas;
                    fila.Cells.Add(celdaDescPreg);

                    DataGridViewTextBoxCell celdaDescEnc = new DataGridViewTextBoxCell();
                    celdaDescEnc.Value = descEncuesta;
                    fila.Cells.Add(celdaDescEnc);

                    grdLlamada.Rows.Add(fila);

                }

            }



        }
        //private void AgregarPersona(Persona per)
        //{
        //    DataGridViewRow fila = new DataGridViewRow();

        //    DataGridViewTextBoxCell celdaDocumento = new DataGridViewTextBoxCell();
        //    celdaDocumento.Value = per.DocumentoPersona;
        //    fila.Cells.Add(celdaDocumento);

        //    DataGridViewTextBoxCell celdaApellido = new DataGridViewTextBoxCell();
        //    celdaApellido.Value = per.ApellidoPersona;
        //    fila.Cells.Add(celdaApellido);

        //    DataGridViewTextBoxCell celdaNombre = new DataGridViewTextBoxCell();
        //    celdaNombre.Value = per.NombrePersona;
        //    fila.Cells.Add(celdaNombre);

        //    grdPersonas.Rows.Add(fila);
        //    MessageBox.Show("Persona agregada con éxito");
        //    LimpiarCampos();
        //    txtNombre.Focus();

        //}


        private void FormSeleccionLlamada_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CSV Generado con éxito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivo Generado con éxito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
