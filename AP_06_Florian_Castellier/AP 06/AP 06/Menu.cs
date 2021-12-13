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
            MedicamentsParFamille Form = new MedicamentsParFamille();
            Form.TopLevel = false;
            Controls.Add(Form);
            Form.Show();
        }

        private void décisionDuneÉtapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecisionDuneEtape Form = new DecisionDuneEtape();
            Form.TopLevel = false;
            Controls.Add(Form);
            Form.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
           
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
