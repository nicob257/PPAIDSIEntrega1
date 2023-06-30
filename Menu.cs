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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        // Al hacerse click en la opción "Consultar encuesta" se oculta esta pantalla y se muestra la pantalla FiltroForm
        private void consultarEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FiltroForm pantalla = new FiltroForm();
            pantalla.Show();
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
