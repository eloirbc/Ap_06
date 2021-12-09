using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AP_06.GestionSql;

namespace AP_06
{
    public partial class AjoutMedicament : Form
    {
        public AjoutMedicament()
        {
            InitializeComponent();
        }

        private void AjoutMedicament_Load(object sender, EventArgs e)
        {
            foreach (Famille uneFamille in Famille.LesFamilles.Values)
            {
                cbChoixFamilles.Items.Add(uneFamille.getCodeFamille());
            }
            cbChoixFamilles.SelectedIndex = 0;
        }

        private void btAjouterMedicament_Click(object sender, EventArgs e)
        {
            if (tbCompositionMedicament.Text == "" || tbContreIndications.Text == "" || tbDepotLegal.Text == "" || tbEffetsMedicament.Text == "" || tbNomCommercial.Text == "" || tbPrix.Text == "")
            {
                MessageBox.Show("Veuillez renseigner tous les champs correctement");
            }
            else
            {
                if (Medicament.LesMedicaments.ContainsKey(tbDepotLegal.Text.ToString()))
                {
                    MessageBox.Show("Ce médicament existe déja");
                }
                else
                {
                    float prix = float.Parse(tbPrix.Text);
                    bool ajouter = ajouterMedicament(tbDepotLegal.Text.ToString().ToUpper(), tbNomCommercial.Text.ToString(), cbChoixFamilles.Text, tbCompositionMedicament.Text.ToString(), tbEffetsMedicament.Text.ToString(), tbContreIndications.Text.ToString(), prix);

                    if (ajouter)
                    {
                        MessageBox.Show("Le médicament a bien été ajouté");
                        getMedicaments();
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors de l'ajout");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Menu oneMenu = new Menu();
            oneMenu.ShowDialog();
        }
    }
}
