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

namespace PPAIDSIEntrega1
{

    public partial class FiltroForm : Form
    {
        private GestorConsultarEncuesta gestor;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private int seleccionLlamada;

        public FiltroForm()
        {
            InitializeComponent();
            gestor = new GestorConsultarEncuesta(this);
            //gestor.configurarManejadorClick(btnBuscarEncuestas);
            opcionConsultarEncuesta();

        }

        public void opcionConsultarEncuesta()
        {
            habilitarPantalla();
        }
        public void habilitarPantalla()
        {
            gestor.consultarEncuesta();
        }



        public void btnBuscarEncuestas_Click(object sender, EventArgs e)
        {
            //FormSeleccionLlamada ventanaLlamadas = new FormSeleccionLlamada(dateTimeInicio.Value, dateTimeFin.Value);
            //ventanaLlamadas.Show();
            //this.Hide();
            fechaDesde = tomarFechaDesde();
            fechaHasta = tomarFechaHasta();
            
            gestor.tomarPeriodo(fechaDesde, fechaHasta);
        }

        private void FiltroForm_Load(object sender, EventArgs e)
        {

        }
        public void pedirSeleccionFechaPeriodo()
        {
            dateTimeInicio.Visible = true;
            dateTimeFin.Visible = true;
        }

        public DateTime tomarFechaDesde()
        {
            return dateTimeInicio.Value;
        }

        public DateTime tomarFechaHasta()
        {
            return dateTimeFin.Value;
        }

        public void pedirSeleccionLlamada(List<int> arrayIdLlamadas)
        {
            //MessageBox.Show(arrayIdLlamadas.Count.ToString());
            //int posY = 17;
            //int separacionY = 25;
            cmbSelLamada.Items.Clear();
            for (int i = 0; i < arrayIdLlamadas.Count; i++)
            {

               
                cmbSelLamada.Items.Add(arrayIdLlamadas[i].ToString());
                
                //RadioButton radBtn = new RadioButton();
                //radBtn.Text = "Llamada " + arrayIdLlamadas[i].ToString();
                //radBtn.Name = arrayIdLlamadas[i].ToString();
                //radBtn.Left = 8;
                //radBtn.Top = posY;
                //panelSelLlamada.Controls.Add(radBtn);
                //posY += separacionY;
                //radBtn.CheckedChanged += RadBtn_CheckedChanged;
            }
            label4.Visible = true;
            cmbSelLamada.Visible = true;
        }


        //public void RadBtn_CheckedChanged(object sender, EventArgs e)
        //{
            
        //    RadioButton radioButton = (RadioButton)sender;
        //    if (radioButton.Checked)
        //    {
        //        seleccionLlamada = int.Parse(radioButton.Name);
        //        tomarSeleccionLlamada(seleccionLlamada);
        //    }
            
        //}

        public void tomarSeleccionLlamada(int id)
        {
            gestor.tomarSeleccionLlamada(id);
        }


        public void agregarFila(DataGridViewRow fila)
        {
            grdLlamada2.Rows.Clear();
            grdLlamada2.Rows.Add(fila);
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CSV Generado con éxito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Archivo Generado con éxito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbSelLamada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            seleccionLlamada = int.Parse(cmbSelLamada.SelectedItem.ToString());
            tomarSeleccionLlamada(seleccionLlamada);
        }



        // 0 = DescripcionOperador
        // 1 = DetalleOpcionRequerida
        // 2 = Duracion
        // 3 = EncuestaEnviada.ToString();
        // 4 = ObservacionAuditor
        // 5 = ClienteAsociado.obtenerNombreCliente
        // 6 = ClienteAsociado.obtenerNombreCliente()

        //if (radioButton.Checked)
        //{
        //    grdLlamada.Rows.Clear();
        //    int idLlamada = int.Parse(radioButton.Name);
        //    //MessageBox.Show(idLlamada.ToString());
        //    List<string> datosLlamada = null;
        //    datosLlamada = arrayLlamadas[idLlamada - 1].obtenerDatosLlamada();
        //    List<int> arrayIdsRP = arrayLlamadas[idLlamada - 1].obtenerIdsRp();
        //    DataGridViewRow fila = new DataGridViewRow();

        //    DataGridViewTextBoxCell celdaCliente = new DataGridViewTextBoxCell();
        //    celdaCliente.Value = datosLlamada[5];
        //    fila.Cells.Add(celdaCliente);

        //    DataGridViewTextBoxCell celdaEstadoActual = new DataGridViewTextBoxCell();
        //    celdaEstadoActual.Value = datosLlamada[6];
        //    fila.Cells.Add(celdaEstadoActual);

        //    DataGridViewTextBoxCell celdaDuracion = new DataGridViewTextBoxCell();
        //    celdaDuracion.Value = datosLlamada[2];
        //    fila.Cells.Add(celdaDuracion);

        //    DataGridViewTextBoxCell celdaRespuestas = new DataGridViewTextBoxCell();
        //    celdaRespuestas.Value = datosLlamada[7];
        //    fila.Cells.Add(celdaRespuestas);


        //    string descEncuesta = "";
        //    string descPreguntas = "";
        //    for (int i = 0; i < arrayEncuestas.Count; i++)
        //    {
        //        //MessageBox.Show(arrayLlamadas[idLlamada - 1].obtenerIdsRp().ToString());
        //        //MessageBox.Show(arrayIdsRP[0].ToString());
        //        if (arrayEncuestas[i].esEncuestaDeCliente(arrayIdsRP[0]))
        //        {
        //            descEncuesta = arrayEncuestas[i].getDescripcionEncuesta();
        //            descPreguntas = arrayEncuestas[i].obtenerPreguntas();
        //        }
        //    }
        //    DataGridViewTextBoxCell celdaDescPreg = new DataGridViewTextBoxCell();
        //    celdaDescPreg.Value = descPreguntas;
        //    fila.Cells.Add(celdaDescPreg);

        //    DataGridViewTextBoxCell celdaDescEnc = new DataGridViewTextBoxCell();
        //    celdaDescEnc.Value = descEncuesta;
        //    fila.Cells.Add(celdaDescEnc);

        //    grdLlamada.Rows.Add(fila);

        //}





    }
}
