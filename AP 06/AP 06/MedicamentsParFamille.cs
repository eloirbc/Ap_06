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

            for (int i = 0; i < Global.lesFamilles.Count; i++)
            {
                ListViewItem uneLigne = new ListViewItem { Text = Global.lesFamilles[i].Code };
                uneLigne.SubItems.Add(Global.lesFamilles[i].Libelle);

                SqlCommand commandSQL = new SqlCommand("prc_MedicamentParFamille", Connexion) { CommandType = CommandType.StoredProcedure };
                SqlParameter param = new SqlParameter("@CodeFamille", SqlDbType.VarChar, 255) { Value = Global.lesFamilles[i].Code };
                commandSQL.Parameters.Add(param);

                int nbMedicaments = 0;

                SqlDataReader allData = commandSQL.ExecuteReader();
                while (allData.Read()) nbMedicaments++;

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
                SqlParameter param = new SqlParameter("@CodeFamille", SqlDbType.VarChar,255) { Value = CodeFamille };
                commandSQL.Parameters.Add(param);

                SqlDataReader allData = commandSQL.ExecuteReader();

                while (allData.Read())
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

                Connexion.Close();
            }
        }

        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
