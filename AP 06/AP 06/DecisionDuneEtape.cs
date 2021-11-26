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


        private void DecisionDuneEtape_Load(object sender, EventArgs e)
        {
            Connexion.Open();

            SqlCommand commandSQL = new SqlCommand("SELECT * FROM medicaments", Connexion);
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
                uneLigne.SubItems.Add(allData.GetValue(7).ToString());
                uneLigne.SubItems.Add(allData.GetValue(8).ToString());

                lvMedicaments.Items.Add(uneLigne);
            }

            Connexion.Close();
        }

        public int indexlvMedicaments;
        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMedicaments.SelectedItems.Count > 0)
            {
                indexlvMedicaments = lvMedicaments.SelectedItems[0].Index;

                Connexion.Open();

                SqlCommand commandSQL = new SqlCommand("SELECT Etape, Etat FROM medicaments WHERE code = " + indexlvMedicaments, Connexion);
                SqlDataReader Data = commandSQL.ExecuteReader();

                if(Data.GetValue(0).ToString() == lvMedicaments.SelectedItems[indexlvMedicaments].SubItems[7].Text && Data.GetValue(1).ToString() == "Refusé")
                {
                    MessageBox.Show("Ce médicament plus disponible.", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("OK");
                }
                Connexion.Close();
            }
        }
    }
}
