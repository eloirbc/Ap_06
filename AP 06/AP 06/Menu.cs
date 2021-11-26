using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_06
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void médicamentsFamilleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedicamentsParFamille FormMedFam = new MedicamentsParFamille();
            FormMedFam.Show();            
        }
    }
}
