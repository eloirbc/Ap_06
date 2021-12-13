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

        private void etapeNormeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_EtapeNormee frm_EtapeNormee = new frm_EtapeNormee();
            frm_EtapeNormee.Show();
            this.Close();
        }

        private void workflowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Workflow frm_Workflow = new frm_Workflow();
            frm_Workflow.Show();
            this.Close();
        }
    }
}
