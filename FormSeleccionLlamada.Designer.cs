namespace PPAIDSIEntrega1
{
    partial class FormSeleccionLlamada
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
            this.panelSelLlamada = new System.Windows.Forms.Panel();
            this.tituloSelLlamada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdLlamada = new System.Windows.Forms.DataGridView();
            this.btnCsv = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RespuestasSeleccionadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescPreguntas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamada)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSelLlamada
            // 
            this.panelSelLlamada.Location = new System.Drawing.Point(24, 80);
            this.panelSelLlamada.Name = "panelSelLlamada";
            this.panelSelLlamada.Size = new System.Drawing.Size(230, 400);
            this.panelSelLlamada.TabIndex = 2;
            // 
            // tituloSelLlamada
            // 
            this.tituloSelLlamada.AutoSize = true;
            this.tituloSelLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloSelLlamada.ForeColor = System.Drawing.Color.Blue;
            this.tituloSelLlamada.Location = new System.Drawing.Point(512, 9);
            this.tituloSelLlamada.Name = "tituloSelLlamada";
            this.tituloSelLlamada.Size = new System.Drawing.Size(264, 29);
            this.tituloSelLlamada.TabIndex = 3;
            this.tituloSelLlamada.Text = "Seleccion de Llamada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la llamada que desee:";
            // 
            // grdLlamada
            // 
            this.grdLlamada.AllowUserToAddRows = false;
            this.grdLlamada.AllowUserToDeleteRows = false;
            this.grdLlamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLlamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.EstadoActual,
            this.DuracionLlamada,
            this.RespuestasSeleccionadas,
            this.DescPreguntas,
            this.DescripcionEncuesta});
            this.grdLlamada.Location = new System.Drawing.Point(24, 486);
            this.grdLlamada.Name = "grdLlamada";
            this.grdLlamada.ReadOnly = true;
            this.grdLlamada.RowHeadersWidth = 51;
            this.grdLlamada.RowTemplate.Height = 24;
            this.grdLlamada.Size = new System.Drawing.Size(1324, 100);
            this.grdLlamada.TabIndex = 5;
            // 
            // btnCsv
            // 
            this.btnCsv.Location = new System.Drawing.Point(366, 630);
            this.btnCsv.Name = "btnCsv";
            this.btnCsv.Size = new System.Drawing.Size(116, 49);
            this.btnCsv.TabIndex = 6;
            this.btnCsv.Text = "Generar CSV";
            this.btnCsv.UseVisualStyleBackColor = true;
            this.btnCsv.Click += new System.EventHandler(this.btnCsv_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(770, 630);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 49);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            // FormSeleccionLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 718);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCsv);
            this.Controls.Add(this.grdLlamada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tituloSelLlamada);
            this.Controls.Add(this.panelSelLlamada);
            this.Name = "FormSeleccionLlamada";
            this.Text = "FormSeleccionLlamada";
            this.Load += new System.EventHandler(this.FormSeleccionLlamada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSelLlamada;
        private System.Windows.Forms.Label tituloSelLlamada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdLlamada;
        private System.Windows.Forms.Button btnCsv;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn RespuestasSeleccionadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEncuesta;
    }
}