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
            cmbSelLamada.Items.Clear();
            for (int i = 0; i < arrayIdLlamadas.Count; i++)
            {
                cmbSelLamada.Items.Add(arrayIdLlamadas[i].ToString());
            }
            label4.Visible = true;
            cmbSelLamada.Visible = true;
        }

        private void cmbSelLamada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            seleccionLlamada = int.Parse(cmbSelLamada.SelectedItem.ToString());
            tomarSeleccionLlamada(seleccionLlamada);
            grdPregYRes.Visible = true;
            grdLlamada2.Visible = true;
        }
        
        public void tomarSeleccionLlamada(int id)
        {
            gestor.tomarSeleccionLlamada(id);
        }


        public void pedirFormaVisualizacion()
        {
            this.btnCsv.Visible = true;
            this.btnImprimir.Visible = true;
        }
        private void btnCsv_Click(object sender, EventArgs e)
        {
            tomarFormaVisualizacion("CSV");     
        }
        private void tomarFormaVisualizacion(string formaVisualizacion)
        {
            gestor.tomarFormaVisualizacion(formaVisualizacion);
        }

        public void agregarFilaGrdA(DataGridViewRow fila)
        {
            grdLlamada2.Rows.Clear();
            grdLlamada2.Rows.Add(fila);
        }

        public void limpiarCamposGrdA()
        {
            grdLlamada2.Rows.Clear();
        }

        public void agregarFilaGrdB(DataGridViewRow fila)
        {
            grdPregYRes.Rows.Add(fila);
        }

        public void limpiarCamposGrdB()
        {
            grdPregYRes.Rows.Clear();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            tomarFormaVisualizacion("Imprimir");
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
