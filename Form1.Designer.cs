namespace PPAIDSIEntrega1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEncuestaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soportreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.encuestasToolStripMenuItem,
            this.soportreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // encuestasToolStripMenuItem
            // 
            this.encuestasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEncuestaToolStripMenuItem,
            this.consultarEncuestaToolStripMenuItem});
            this.encuestasToolStripMenuItem.Name = "encuestasToolStripMenuItem";
            this.encuestasToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.encuestasToolStripMenuItem.Text = "Encuestas";
            // 
            // registrarEncuestaToolStripMenuItem
            // 
            this.registrarEncuestaToolStripMenuItem.Name = "registrarEncuestaToolStripMenuItem";
            this.registrarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarEncuestaToolStripMenuItem.Text = "Registrar Encuesta";
            // 
            // consultarEncuestaToolStripMenuItem
            // 
            this.consultarEncuestaToolStripMenuItem.Name = "consultarEncuestaToolStripMenuItem";
            this.consultarEncuestaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarEncuestaToolStripMenuItem.Text = "Consultar Encuesta";
            this.consultarEncuestaToolStripMenuItem.Click += new System.EventHandler(this.consultarEncuestaToolStripMenuItem_Click);
            // 
            // soportreToolStripMenuItem
            // 
            this.soportreToolStripMenuItem.Name = "soportreToolStripMenuItem";
            this.soportreToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.soportreToolStripMenuItem.Text = "Soporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido al Sistema de IVR!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(56, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(635, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para Consultar una encuesta, vaya a Encuestas => Consultar Encuesta";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "IVR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encuestasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEncuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEncuestaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soportreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

