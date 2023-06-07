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
            this.grdLlamada2 = new System.Windows.Forms.DataGridView();
            this.cmbSelLamada = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grdPregYRes = new System.Windows.Forms.DataGridView();
            this.rtaSelec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descPreg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuracionLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionEncuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboxSelecOpGenerar = new System.Windows.Forms.GroupBox();
            this.checkGenerarCSV = new System.Windows.Forms.CheckBox();
            this.checkImprimir = new System.Windows.Forms.CheckBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamada2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregYRes)).BeginInit();
            this.gboxSelecOpGenerar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(391, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consultar Encuesta";
            // 
            // btnBuscarEncuestas
            // 
            this.btnBuscarEncuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBuscarEncuestas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscarEncuestas.Location = new System.Drawing.Point(104, 222);
            this.btnBuscarEncuestas.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEncuestas.Name = "btnBuscarEncuestas";
            this.btnBuscarEncuestas.Size = new System.Drawing.Size(118, 29);
            this.btnBuscarEncuestas.TabIndex = 3;
            this.btnBuscarEncuestas.Text = "Buscar llamadas";
            this.btnBuscarEncuestas.UseVisualStyleBackColor = false;
            this.btnBuscarEncuestas.Click += new System.EventHandler(this.btnBuscarEncuestas_Click);
            // 
            // dateTimeInicio
            // 
            this.dateTimeInicio.Location = new System.Drawing.Point(122, 132);
            this.dateTimeInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeInicio.Name = "dateTimeInicio";
            this.dateTimeInicio.Size = new System.Drawing.Size(195, 20);
            this.dateTimeInicio.TabIndex = 6;
            this.dateTimeInicio.Visible = false;
            // 
            // dateTimeFin
            // 
            this.dateTimeFin.Location = new System.Drawing.Point(122, 172);
            this.dateTimeFin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeFin.Name = "dateTimeFin";
            this.dateTimeFin.Size = new System.Drawing.Size(195, 20);
            this.dateTimeFin.TabIndex = 7;
            this.dateTimeFin.Visible = false;
            // 
            // grdLlamada2
            // 
            this.grdLlamada2.AllowUserToAddRows = false;
            this.grdLlamada2.AllowUserToDeleteRows = false;
            this.grdLlamada2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLlamada2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cliente,
            this.EstadoActual,
            this.DuracionLlamada,
            this.DescripcionEncuesta});
            this.grdLlamada2.Location = new System.Drawing.Point(396, 132);
            this.grdLlamada2.Margin = new System.Windows.Forms.Padding(2);
            this.grdLlamada2.Name = "grdLlamada2";
            this.grdLlamada2.ReadOnly = true;
            this.grdLlamada2.RowHeadersWidth = 51;
            this.grdLlamada2.RowTemplate.Height = 24;
            this.grdLlamada2.Size = new System.Drawing.Size(635, 173);
            this.grdLlamada2.TabIndex = 9;
            this.grdLlamada2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLlamada2_CellClick);
            // 
            // cmbSelLamada
            // 
            this.cmbSelLamada.FormattingEnabled = true;
            this.cmbSelLamada.Location = new System.Drawing.Point(11, 9);
            this.cmbSelLamada.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelLamada.Name = "cmbSelLamada";
            this.cmbSelLamada.Size = new System.Drawing.Size(178, 21);
            this.cmbSelLamada.TabIndex = 12;
            this.cmbSelLamada.Visible = false;
            this.cmbSelLamada.SelectionChangeCommitted += new System.EventHandler(this.cmbSelLamada_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(393, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Seleccione una llamada";
            this.label4.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(188, 532);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 27);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grdPregYRes
            // 
            this.grdPregYRes.AllowUserToAddRows = false;
            this.grdPregYRes.AllowUserToDeleteRows = false;
            this.grdPregYRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPregYRes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rtaSelec,
            this.descPreg});
            this.grdPregYRes.Location = new System.Drawing.Point(396, 355);
            this.grdPregYRes.Margin = new System.Windows.Forms.Padding(2);
            this.grdPregYRes.Name = "grdPregYRes";
            this.grdPregYRes.ReadOnly = true;
            this.grdPregYRes.RowHeadersWidth = 51;
            this.grdPregYRes.RowTemplate.Height = 24;
            this.grdPregYRes.Size = new System.Drawing.Size(635, 160);
            this.grdPregYRes.TabIndex = 15;
            this.grdPregYRes.Visible = false;
            // 
            // rtaSelec
            // 
            this.rtaSelec.HeaderText = "Respuesta Seleccionada";
            this.rtaSelec.MinimumWidth = 6;
            this.rtaSelec.Name = "rtaSelec";
            this.rtaSelec.ReadOnly = true;
            this.rtaSelec.Width = 260;
            // 
            // descPreg
            // 
            this.descPreg.HeaderText = "Descripción Pregunta";
            this.descPreg.MinimumWidth = 6;
            this.descPreg.Name = "descPreg";
            this.descPreg.ReadOnly = true;
            this.descPreg.Width = 420;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(324, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Seleccione el periodo por el cual desea filtrar";
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
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
            // DescripcionEncuesta
            // 
            this.DescripcionEncuesta.HeaderText = "Descripcion Encuesta";
            this.DescripcionEncuesta.MinimumWidth = 6;
            this.DescripcionEncuesta.Name = "DescripcionEncuesta";
            this.DescripcionEncuesta.ReadOnly = true;
            this.DescripcionEncuesta.Width = 200;
            // 
            // gboxSelecOpGenerar
            // 
            this.gboxSelecOpGenerar.Controls.Add(this.checkImprimir);
            this.gboxSelecOpGenerar.Controls.Add(this.checkGenerarCSV);
            this.gboxSelecOpGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gboxSelecOpGenerar.Location = new System.Drawing.Point(18, 355);
            this.gboxSelecOpGenerar.Name = "gboxSelecOpGenerar";
            this.gboxSelecOpGenerar.Size = new System.Drawing.Size(314, 119);
            this.gboxSelecOpGenerar.TabIndex = 18;
            this.gboxSelecOpGenerar.TabStop = false;
            this.gboxSelecOpGenerar.Text = "Seleccione forma de generacion";
            this.gboxSelecOpGenerar.Visible = false;
            // 
            // checkGenerarCSV
            // 
            this.checkGenerarCSV.AutoSize = true;
            this.checkGenerarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGenerarCSV.Location = new System.Drawing.Point(21, 42);
            this.checkGenerarCSV.Name = "checkGenerarCSV";
            this.checkGenerarCSV.Size = new System.Drawing.Size(101, 20);
            this.checkGenerarCSV.TabIndex = 0;
            this.checkGenerarCSV.Text = "Archivo CSV";
            this.checkGenerarCSV.UseVisualStyleBackColor = true;
            this.checkGenerarCSV.CheckedChanged += new System.EventHandler(this.checkGenerarCSV_CheckedChanged);
            // 
            // checkImprimir
            // 
            this.checkImprimir.AutoSize = true;
            this.checkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkImprimir.Location = new System.Drawing.Point(21, 81);
            this.checkImprimir.Name = "checkImprimir";
            this.checkImprimir.Size = new System.Drawing.Size(76, 21);
            this.checkImprimir.TabIndex = 1;
            this.checkImprimir.Text = "Imprimir";
            this.checkImprimir.UseVisualStyleBackColor = true;
            this.checkImprimir.CheckedChanged += new System.EventHandler(this.checkImprimir_CheckedChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConfirmar.Location = new System.Drawing.Point(68, 532);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(80, 27);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FiltroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1066, 633);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.gboxSelecOpGenerar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdPregYRes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSelLamada);
            this.Controls.Add(this.grdLlamada2);
            this.Controls.Add(this.dateTimeFin);
            this.Controls.Add(this.dateTimeInicio);
            this.Controls.Add(this.btnBuscarEncuestas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FiltroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.Load += new System.EventHandler(this.FiltroForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLlamada2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPregYRes)).EndInit();
            this.gboxSelecOpGenerar.ResumeLayout(false);
            this.gboxSelecOpGenerar.PerformLayout();
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
        private System.Windows.Forms.DataGridView grdLlamada2;
        private System.Windows.Forms.ComboBox cmbSelLamada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView grdPregYRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtaSelec;
        private System.Windows.Forms.DataGridViewTextBoxColumn descPreg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuracionLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionEncuesta;
        private System.Windows.Forms.GroupBox gboxSelecOpGenerar;
        private System.Windows.Forms.CheckBox checkImprimir;
        private System.Windows.Forms.CheckBox checkGenerarCSV;
        private System.Windows.Forms.Button btnConfirmar;
    }
}