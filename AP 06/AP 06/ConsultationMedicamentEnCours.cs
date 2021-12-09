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
            lvDecision.Items.Clear();
            if (lvAfficherMedoc.SelectedItems.Count == 0)
            {
                return;
            }
            string clé = lvAfficherMedoc.SelectedItems[0].Text;
            foreach (Workflow unWorkflow in Medicament.LesMedicaments[clé].getLesEtapes())
            {
                ListViewItem ligne = new ListViewItem();
                ListViewItem ligneSuiv = new ListViewItem();
                ligne.Text = unWorkflow.getNumEtapeWorkflow().ToString();

                string norme = "";
                DateTime dateNorme = DateTime.Now;
                foreach (Etape uneEtape in Etape.lesEtapes)
                {
                    if (uneEtape.getNumEtape() == unWorkflow.getNumEtapeWorkflow() && uneEtape.GetType().Name == "EtapeNormee")
                    {
                        norme = (uneEtape as EtapeNormee).getNorme().ToString();
                        dateNorme = (uneEtape as EtapeNormee).getDateNorme();
                        ligne.SubItems.Add(norme);
                        ligne.SubItems.Add(dateNorme.ToString("dd-MM-yyyy"));
                    }
                }
                lvWorkflowMedocChoisi.Items.Add(ligne);
                string libelleDecision = "";
                DateTime dateDecision = DateTime.Now;
                foreach (Decision uneDecision in Decision.lesDecisions)
                {
                    if (unWorkflow.getIdDecisionWorkflow() == uneDecision.getIdDecision())
                    {
                        libelleDecision = uneDecision.getLibelleDecision();
                        dateDecision = unWorkflow.getDateDecisionWorkflow();
                    }
                }
                ligneSuiv.Text = libelleDecision.ToString();
                ligneSuiv.SubItems.Add(dateDecision.ToString("dd-MM-yyyy"));
                lvDecision.Items.Add(ligneSuiv);
            }
        }

        private void btRetour_Click(object sender, EventArgs e)
        {
            Hide();
            Menu oneMenu = new Menu();
            oneMenu.ShowDialog();
        }

        private void lvWorkflowMedocChoisi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
