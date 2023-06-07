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
            grdPregYRes.Visible = false;
            limpiarCamposGrdA();

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
            //Aca cargar a la grilla no al cmd

            cmbSelLamada.Items.Clear();
            
            for (int i = 0; i < arrayIdLlamadas.Count; i++)
            {
                cmbSelLamada.Items.Add(arrayIdLlamadas[i].ToString());
                tomarSeleccionLlamada(arrayIdLlamadas[i]);
            }
            /*for (int i = 0; i < arrayIdLlamadas.Count; i++)
            {
                tomarSeleccionLlamada(arrayIdLlamadas[i]);
            }*/
            label4.Visible = true;
            //cmbSelLamada.Visible = true;

        }

        private void cmbSelLamada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //es el otro metodo de datagridItemChange
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
            btnConfirmar.Visible = true;
            //this.btnCsv.Visible = true;
            //this.btnImprimir.Visible = true;
        }
        
        private void tomarFormaVisualizacion(string formaVisualizacion)
        {
            gestor.tomarFormaVisualizacion(formaVisualizacion);
        }

        public void agregarFilaGrdA(DataGridViewRow fila)
        {
            //grdLlamada2.Rows.Clear();
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

        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Esta seguro que desea cancelar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                this.Close();
                
            }
            
            
        }
        //nuevo
        

        private void grdLlamada2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gboxSelecOpGenerar.Visible = true;
            grdPregYRes.Visible = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = grdLlamada2.Rows[indice];
            seleccionLlamada = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
            
            tomarSeleccionLlamada(seleccionLlamada);
        }

        private void checkGenerarCSV_CheckedChanged(object sender, EventArgs e)
        {
            checkImprimir.Checked = false; 
        }

        private void checkImprimir_CheckedChanged(object sender, EventArgs e)
        {
            checkGenerarCSV.Checked = false; 
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (checkImprimir.Checked==true)
            {
                tomarFormaVisualizacion("Imprimir");
            }
            else if (checkGenerarCSV.Checked == true)
            {
                tomarFormaVisualizacion("CSV");
            }
            else
            {
                MessageBox.Show("Seleccione una forma de generacion.");
            }
        }
    }
}
