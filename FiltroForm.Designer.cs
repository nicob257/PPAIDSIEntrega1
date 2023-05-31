namespace PPAIDSIEntrega1
{
    partial class FiltroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarEncuestas = new System.Windows.Forms.Button();
            this.dateTimeInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimeFin = new System.Windows.Forms.DateTimePicker();
            this.panelSelLlamada = new System.Windows.Forms.Panel();
            this.grdLlamada2 = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespuestasSeleccionadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescPreguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamada2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(76, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consultar Encuesta";
            // 
            // btnBuscarEncuestas
            // 
            this.btnBuscarEncuestas.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnBuscarEncuestas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarEncuestas.Location = new System.Drawing.Point(138, 165);
            this.btnBuscarEncuestas.Name = "btnBuscarEncuestas";
            this.btnBuscarEncuestas.Size = new System.Drawing.Size(121, 36);
            this.btnBuscarEncuestas.TabIndex = 3;
            this.btnBuscarEncuestas.Text = "Buscar";
            this.btnBuscarEncuestas.UseVisualStyleBackColor = false;
            this.btnBuscarEncuestas.Click += new System.EventHandler(this.btnBuscarEncuestas_Click);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(138, 73);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(282, 22);
            this.dateTimeInicio.TabIndex = 6;
            this.dateTimeInicio.Visible = false;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(138, 114);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(282, 22);
            this.dateTimeFin.TabIndex = 7;
            this.dateTimeFin.Visible = false;
            // 
            // panelSelLlamada
            // 
            this.panelSelLlamada.Location = new System.Drawing.Point(16, 229);
            this.panelSelLlamada.Name = "panelSelLlamada";
            this.panelSelLlamada.Size = new System.Drawing.Size(230, 400);
            this.panelSelLlamada.TabIndex = 8;
            // 
            // grdLlamada2
            // 
            this.grdLlamada2.AllowUserToAddRows = false;
            this.grdLlamada2.AllowUserToDeleteRows = false;
            this.grdLlamada2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLlamada2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.EstadoActual,
            this.DuracionLlamada,
            this.RespuestasSeleccionadas,
            this.DescPreguntas,
            this.DescripcionEncuesta});
            this.grdLlamada2.Location = new System.Drawing.Point(16, 642);
            this.grdLlamada2.Name = "grdLlamada2";
            this.grdLlamada2.ReadOnly = true;
            this.grdLlamada2.RowHeadersWidth = 51;
            this.grdLlamada2.RowTemplate.Height = 24;
            this.grdLlamada2.Size = new System.Drawing.Size(931, 125);
            this.grdLlamada2.TabIndex = 9;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 6;
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 125;
            // 
            // EstadoActual
            // 
            this.EstadoActual.HeaderText = "Estado Actual";
            this.EstadoActual.MinimumWidth = 6;
            this.EstadoActual.Name = "EstadoActual";
            this.EstadoActual.ReadOnly = true;
            this.EstadoActual.Width = 125;
            // 
            // DuracionLlamada
            // 
            this.DuracionLlamada.HeaderText = "Duracion de Llamada";
            this.DuracionLlamada.MinimumWidth = 6;
            this.DuracionLlamada.Name = "DuracionLlamada";
            this.DuracionLlamada.ReadOnly = true;
            this.DuracionLlamada.Width = 125;
            // 
            // RespuestasSeleccionadas
            // 
            this.RespuestasSeleccionadas.HeaderText = "Respuestas Seleccionadas";
            this.RespuestasSeleccionadas.MinimumWidth = 6;
            this.RespuestasSeleccionadas.Name = "RespuestasSeleccionadas";
            this.RespuestasSeleccionadas.ReadOnly = true;
            this.RespuestasSeleccionadas.Width = 125;
            // 
            // DescPreguntas
            // 
            this.DescPreguntas.HeaderText = "Descripcion Preguntas";
            this.DescPreguntas.MinimumWidth = 6;
            this.DescPreguntas.Name = "DescPreguntas";
            this.DescPreguntas.ReadOnly = true;
            this.DescPreguntas.Width = 250;
            // 
            // DescripcionEncuesta
            // 
            this.DescripcionEncuesta.HeaderText = "Descripcion Encuesta";
            this.DescripcionEncuesta.MinimumWidth = 6;
            this.DescripcionEncuesta.Name = "DescripcionEncuesta";
            this.DescripcionEncuesta.ReadOnly = true;
            this.DescripcionEncuesta.Width = 200;
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(1027, 642);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(116, 49);
            this.btnCsv.TabIndex = 10;
            this.btnCsv.Text = "Generar CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1027, 718);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 49);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FiltroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 779);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.grdLlamada2);
            this.Controls.Add(this.panelSelLlamada);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.btnBuscarEncuestas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FiltroForm";
            this.Text = "FiltroForm";
            this.Load += new System.EventHandler(this.FiltroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamada2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarEncuestas;
        private System.Windows.Forms.DateTimePicker dateTimeInicio;
        private System.Windows.Forms.DateTimePicker dateTimeFin;
        private System.Windows.Forms.Panel panelSelLlamada;
        private System.Windows.Forms.DataGridView grdLlamada2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespuestasSeleccionadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEncuesta;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnImprimir;
    }
}