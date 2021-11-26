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
                ListViewItem uneLigne = new ListViewItem();

                uneLigne.Text = Global.lesFamilles[i].Code;
                uneLigne.SubItems.Add(Global.lesFamilles[i].Libelle);
                uneLigne.SubItems.Add(Global.lesFamilles[i].NbMedi.ToString());

                lvFamille.Items.Add(uneLigne);
            }

            Connexion.Close();
        }

        public int indexlvFamille;
        private void lvFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvFamille.SelectedItems.Count > 0)
            //{
            //    indexlvFamille = lvFamille.SelectedItems[0].Index;

            //    Connexion.Open();

            //    SqlCommand commandSQL = new SqlCommand("SELECT * FROM medicaments INNER JOIN famille WHERE idMedicamentFamille = " + indexlvFamille, Connexion);
            //    SqlDataReader allData = commandSQL.ExecuteReader();

            //    while (allData.Read())
            //    {
            //        ListViewItem uneLigne = new ListViewItem();

            //        uneLigne.Text = allData.GetValue(0).ToString();
            //        uneLigne.SubItems.Add(allData.GetValue(1).ToString());
            //        uneLigne.SubItems.Add(allData.GetValue(2).ToString());
            //        uneLigne.SubItems.Add(allData.GetValue(3).ToString());
            //        uneLigne.SubItems.Add(allData.GetValue(4).ToString());
            //        uneLigne.SubItems.Add(allData.GetValue(5).ToString());
            //        uneLigne.SubItems.Add(allData.GetValue(6).ToString());

            //        lvMedicaments.Items.Add(uneLigne);
            //    }

            //    Connexion.Close();
            //}
        }

        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
