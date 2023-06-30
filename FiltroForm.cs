using PPAIDSIEntrega1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        // Al hacer click en el botón "Buscar encuestas", se guardan las fechas seleccionadas y el gestor toma este período
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


        // Mostramos los dateTimePickers
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




        // Para pedir la seleccion de llamada mediante la grilla, debemos obtener los datos de la llamada, se llama al método 
        // tomarSeleccionLlamada con este propósito, NO se está tomando la selección del cliente

        public void pedirSeleccionLlamada(List<int> arrayIdLlamadas)
        {
            //Aca cargar a la grilla no al cmd

            //cmbSelLamada.Items.Clear();
            
            for (int i = 0; i < arrayIdLlamadas.Count; i++)
            {
                //cmbSelLamada.Items.Add(arrayIdLlamadas[i].ToString());
                tomarSeleccionLlamada(arrayIdLlamadas[i]);
            }
            /*for (int i = 0; i < arrayIdLlamadas.Count; i++)
            {
                tomarSeleccionLlamada(arrayIdLlamadas[i]);
            }*/

            // Hacemos visible el label de "Seleccione una llamada"
            label4.Visible = true;
            //cmbSelLamada.Visible = true;

        }

        //private void cmbSelLamada_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    //es el otro metodo de datagridItemChange
        //    //seleccionLlamada = int.Parse(cmbSelLamada.SelectedItem.ToString());
        //    tomarSeleccionLlamada(seleccionLlamada);
        //    grdPregYRes.Visible = true;
        //    grdLlamada2.Visible = true;
        //}
        
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

            // GENERACION DE CSV COMENTADO
            /*if (formaVisualizacion == "CSV")
            {
                List<string> headers = grdLlamada2.Columns.Cast<DataGridViewColumn>()
                .Select(column => column.HeaderText)
                .ToList();

                // Obtener los datos de la fila seleccionada
                DataGridViewRow selectedRow = grdLlamada2.SelectedRows[0];
                List<string> rowData = selectedRow.Cells.Cast<DataGridViewCell>()
                    .Select(cell => cell.Value.ToString())
                    .ToList();

                string filePath = "C:/Users/NombreDeUsuario/Desktop/archivo.csv";

                // Crear el archivo CSV
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    
                    // Escribir los encabezados de las columnas
                    for (int i = 0; i < grdPregYRes.Columns.Count; i++)
                    {
                        headers.Add(grdPregYRes.Columns[i].HeaderText);
                       
                    }
                    writer.WriteLine(string.Join(",", headers));

                    // Escribir la fila seleccionada y las respuestas
                    for (int i = 0; i < grdPregYRes.Rows.Count; i++)
                    {
                        List<string> row = new List<string>();
                        for (int j = 0; j < grdPregYRes.Columns.Count; j++)
                        {
                            rowData.Add(grdPregYRes.Rows[i].Cells[j].Value.ToString());
                        }
                        writer.WriteLine(string.Join(",", rowData));
                    }
                }
                
            }*/
            
            gestor.tomarFormaVisualizacion(formaVisualizacion);
        }


        // FUNCIONES DE SOPORTE PARA AGREGAR FILAS Y LIMPIAR LOS CAMPOS DE LOS GRDS
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

        

        // Cuando se hace click en el botón de cancelar, se pide confirmación y de confirmarse se cierra la ventana
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Esta seguro que desea cancelar?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resul == DialogResult.Yes)
            {
                this.Close();
                
            }
            
            
        }
        //nuevo
        

        // Al hacerse click en el grd de llamadas, se muestran el grd con las preguntas y las respuestas seleccionadas
        private void grdLlamada2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gboxSelecOpGenerar.Visible = true;
            grdPregYRes.Visible = true;
            int indice = e.RowIndex;            
            if (e.RowIndex > -1)
            {
                DataGridViewRow filaSeleccionada = grdLlamada2.Rows[indice];
                seleccionLlamada = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());

                // Invocamos el método tomarSeleccionLlamada, esta vez sí haciendo referencia a que se toma la selección del usuario
                tomarSeleccionLlamada(seleccionLlamada);
            }
        }

        private void checkGenerarCSV_CheckedChanged(object sender, EventArgs e)
        {
            checkImprimir.Checked = false; 
        }

        private void checkImprimir_CheckedChanged(object sender, EventArgs e)
        {
            checkGenerarCSV.Checked = false; 
        }


        // Al hacer click en "Confirmar" se toma la forma de visualización elegida
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
