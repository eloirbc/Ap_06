using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static AP_06.SQL;

namespace AP_06
{
    public partial class DecisionDuneEtape : Form
    {
        public DecisionDuneEtape()
        {
            InitializeComponent();
        }

        Random R = new Random();
        private void DecisionDuneEtape_Load(object sender, EventArgs e)
        {
            ChargementListView();
        }

        public string codeFam;
        public string Etat;
        public int Etape;
        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedicaments.SelectedItems.Count > 0)
            {
                codeFam = lvMedicaments.SelectedItems[0].SubItems[2].Text;
                Etat = lvMedicaments.SelectedItems[0].SubItems[8].Text;
                Etape = int.Parse(lvMedicaments.SelectedItems[0].SubItems[7].Text);

                if (Etat == "Refusé") //En cours //Refusé
                {
                    gbMettreAJourEtat.Hide();
                    MessageBox.Show("Ce médicament plus disponible.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    lbMedicament.Text = lvMedicaments.SelectedItems[0].SubItems[1].Text;

                    Connexion.Open();

                    SqlCommand commandSQL = new SqlCommand("prc_getEtape", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param = new SqlParameter("@numEtape", SqlDbType.Int) { Value = Etape };
                    commandSQL.Parameters.Add(param);
                    SqlDataReader allData = commandSQL.ExecuteReader();
                    allData.Read();

                    lbNumero.Text = allData.GetValue(0).ToString();
                    lbDate.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
                    lbLibelle.Text = allData.GetValue(1).ToString();

                    Connexion.Close();
                    Connexion.Open();

                    SqlCommand commandSQL2 = new SqlCommand("prc_getEtapeNormee", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param2 = new SqlParameter("@numEtape", SqlDbType.Int) { Value = Etape };
                    commandSQL2.Parameters.Add(param2);
                    SqlDataReader allData2 = commandSQL2.ExecuteReader();
                    allData2.Read();

                    try
                    {
                        lbNorme.Text = allData2.GetValue(1).ToString();
                        lbDateNorme.Text = allData2.GetValue(2).ToString();
                    }
                    catch
                    {
                        lbNorme.Text = "";
                        lbDateNorme.Text = "";
                    }

                    Connexion.Close();
                    Connexion.Open();

                    SqlCommand commandSQL3 = new SqlCommand("prc_getEtape", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param3 = new SqlParameter("@numEtape", SqlDbType.Int) { Value = Etape + 1};
                    commandSQL3.Parameters.Add(param3);
                    SqlDataReader allData3 = commandSQL3.ExecuteReader();
                    allData3.Read();

                    try
                    {
                        lbNumeroNext.Text = allData3.GetValue(0).ToString();
                        lbLibelleNext.Text = allData3.GetValue(1).ToString();
                    }
                    catch
                    {
                        lbNumeroNext.Text = "Plus d'étape displonible";
                        lbLibelleNext.Text = "Plus d'étape displonible";
                    }

                    Connexion.Close();
                    Connexion.Open();

                    SqlCommand commandSQL4 = new SqlCommand("prc_getEtapeNormee", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param4 = new SqlParameter("@numEtape", SqlDbType.Int) { Value = Etape + 1};
                    commandSQL4.Parameters.Add(param4);
                    SqlDataReader allData4 = commandSQL4.ExecuteReader();
                    allData4.Read();

                    try
                    {
                        lbReferenceNext.Text = allData4.GetValue(1).ToString();
                    }
                    catch
                    {
                        lbReferenceNext.Text = "Aucune référence";
                    }

                    Connexion.Close();


                    gbMettreAJourEtat.Show();
                }
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes vous sur de vouloir changer l'etape de " + codeFam + " ? ","Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(cbTypeDécision.SelectedIndex == 0)
                {
                    Connexion.Open();

                    SqlCommand commandSQL5 = new SqlCommand("prc_ChangeEtapeMedicament", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param51 = new SqlParameter("@unCodeFamille", SqlDbType.VarChar, 255) { Value = codeFam };
                    SqlParameter param52 = new SqlParameter("@unNumEtape", SqlDbType.Int) { Value = Etape + 1 };
                    commandSQL5.Parameters.Add(param51);
                    commandSQL5.Parameters.Add(param52);
                    commandSQL5.ExecuteReader();

                    Connexion.Close();
                }
                else
                {
                    Connexion.Open();

                    SqlCommand commandSQL5 = new SqlCommand("prc_ChangeEtapeMedicament", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param51 = new SqlParameter("@unCodeFamille", SqlDbType.VarChar, 255) { Value = codeFam };
                    SqlParameter param52 = new SqlParameter("@unNumEtape", SqlDbType.Int) { Value = 1 };
                    commandSQL5.Parameters.Add(param51);
                    commandSQL5.Parameters.Add(param52);
                    commandSQL5.ExecuteReader();

                    Connexion.Close();
                }

                ChargementListView();
            }
            else
            {
                MessageBox.Show("Changement annulé", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ChargementListView()
        {
            lvMedicaments.Items.Clear();

            Connexion.Open();

            SqlCommand commandSQL = new SqlCommand("prc_AllMedicament", Connexion) { CommandType = CommandType.StoredProcedure };
            SqlDataReader allData = commandSQL.ExecuteReader();

            while (allData.Read())
            {
                int randomEtat = R.Next(1, 3);
                ListViewItem uneLigne = new ListViewItem();

                uneLigne.Text = allData.GetValue(0).ToString();
                for (int i = 1; i < 8; i++)
                {
                    uneLigne.SubItems.Add(allData.GetValue(i).ToString());
                }

                if (randomEtat == 1) uneLigne.SubItems.Add("En cours");
                else if (randomEtat == 2) uneLigne.SubItems.Add("Refusé");

                lvMedicaments.Items.Add(uneLigne);
            }

            Connexion.Close();
            cbTypeDécision.SelectedIndex = 0;
        }
    }
}
