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
    public partial class ConsultationMedicamentEnCours : Form
    {
        public ConsultationMedicamentEnCours()
        {
            InitializeComponent();
        }
        private void ConsultationMedicamentEnCours_Load(object sender, EventArgs e)
        {
            lvAfficherMedoc.Items.Clear();
            foreach (Medicament unMedicament in Medicament.LesMedicaments.Values)
            {
                if (unMedicament.getLesEtapes().Count == 0) continue;
                if (unMedicament.getDerniereEtape() != 8 && unMedicament.getLesEtapes()[unMedicament.getLesEtapes().Count - 1].getIdDecisionWorkflow() == 1)
                {
                    ListViewItem ligne = new ListViewItem();
                    ligne.Text = unMedicament.getDepotLegalMed().ToString();
                    ligne.SubItems.Add(unMedicament.getNomCommercialMed().ToString());
                    ligne.SubItems.Add(unMedicament.getLaFamille().getLibelleFamille());
                    lvAfficherMedoc.Items.Add(ligne);
                }
            }
        }
        private void lvAfficherMedoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvWorkflowMedocChoisi.Items.Clear();
            if (lvAfficherMedoc.SelectedItems.Count == 0)
            {
                return;
            }
            string clé = lvAfficherMedoc.SelectedItems[0].Text;
            foreach (Workflow unWorkflow in Medicament.LesMedicaments[clé].getLesEtapes())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = unWorkflow.getNumEtapeWorkflow().ToString();
                ligne.SubItems.Add(unWorkflow.getDateDecisionWorkflow().ToString());
                lvWorkflowMedocChoisi.Items.Add(ligne);
            }
        }
    }
}
