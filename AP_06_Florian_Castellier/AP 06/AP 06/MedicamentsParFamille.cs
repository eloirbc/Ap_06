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
    public partial class MedicamentsParFamille : Form
    {
        public MedicamentsParFamille()
        {
            InitializeComponent();
        }

        private void MedicamentsParFamille_Load(object sender, EventArgs e)
        {
            Connexion.Open();

            lireLesFamilles();

            foreach (KeyValuePair<string, Famille> uneFamille in Global.lesFamilles)
            {
                ListViewItem uneLigne = new ListViewItem { Text = uneFamille.Key };
                uneLigne.SubItems.Add(uneFamille.Value.Libelle);

                SqlCommand commandSQL = new SqlCommand("prc_MedicamentParFamille", Connexion) { CommandType = CommandType.StoredProcedure };
                SqlParameter param = new SqlParameter("@CodeFamille", SqlDbType.VarChar, 255) { Value = uneFamille.Key };
                commandSQL.Parameters.Add(param);

                int nbMedicaments = 0;

                SqlDataReader allData = commandSQL.ExecuteReader();

                while (allData.Read())
                {
                    SqlCommand commandSQL2 = new SqlCommand("prc_getSubir", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param2 = new SqlParameter("@depotLegal", SqlDbType.VarChar, 255) { Value = allData.GetValue(0).ToString() };
                    commandSQL2.Parameters.Add(param2);
                    SqlDataReader allData2 = commandSQL2.ExecuteReader();

                    while (allData2.Read())
                    {
                        if (allData2.GetValue(1).ToString() == "8") nbMedicaments++;
                    }
                }

                uneLigne.SubItems.Add(nbMedicaments.ToString());

                lvFamille.Items.Add(uneLigne);
            }

            Connexion.Close();
        }

        public string CodeFamille;
        private void lvFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFamille.SelectedItems.Count > 0)
            {
                lvMedicaments.Items.Clear();

                CodeFamille = lvFamille.SelectedItems[0].Text;

                Connexion.Open();

                SqlCommand commandSQL = new SqlCommand("prc_MedicamentParFamille", Connexion) { CommandType = CommandType.StoredProcedure };
                SqlParameter param = new SqlParameter("@CodeFamille", SqlDbType.VarChar, 255) { Value = CodeFamille };
                commandSQL.Parameters.Add(param);

                SqlDataReader allData = commandSQL.ExecuteReader();

                while (allData.Read())
                {
                    SqlCommand commandSQL2 = new SqlCommand("prc_getSubir", Connexion) { CommandType = CommandType.StoredProcedure };
                    SqlParameter param2 = new SqlParameter("@depotLegal", SqlDbType.VarChar, 255) { Value = allData.GetValue(0).ToString() };
                    commandSQL2.Parameters.Add(param2);
                    SqlDataReader allData2 = commandSQL2.ExecuteReader();

                    while (allData2.Read())
                    {
                        if (allData2.GetValue(1).ToString() == "8")
                        {
                            ListViewItem uneLigne = new ListViewItem();

                            uneLigne.Text = allData.GetValue(0).ToString();
                            uneLigne.SubItems.Add(allData.GetValue(1).ToString());
                            uneLigne.SubItems.Add(allData.GetValue(2).ToString());
                            uneLigne.SubItems.Add(allData.GetValue(3).ToString());
                            uneLigne.SubItems.Add(allData.GetValue(4).ToString());
                            uneLigne.SubItems.Add(allData.GetValue(5).ToString());
                            uneLigne.SubItems.Add(allData.GetValue(6).ToString());

                            lvMedicaments.Items.Add(uneLigne);
                        }
                    }
                }

                Connexion.Close();
            }
        }

        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
