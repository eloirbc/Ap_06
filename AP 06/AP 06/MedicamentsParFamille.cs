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

namespace AP_06
{
    public partial class MedicamentsParFamille : Form
    {
        SQL SQL = new SQL();

        public MedicamentsParFamille()
        {
            InitializeComponent();
        }

        private void MedicamentsParFamille_Load(object sender, EventArgs e)
        {
            SQL.Open();

            SqlCommand commandSQL = new SqlCommand("Select * from FAMILLE", SQL.Connexion());
            SqlDataReader allData = commandSQL.ExecuteReader();

            while (allData.Read())
            {
                ListViewItem uneLigne = new ListViewItem();

                uneLigne.Text = allData.GetValue(0).ToString();
                uneLigne.SubItems.Add(allData.GetValue(1).ToString());
                uneLigne.SubItems.Add(allData.GetValue(2).ToString());

                lvFamille.Items.Add(uneLigne);
            }

            SQL.Close();
        }

        public int indexlvFamille;
        private void lvFamille_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvFamille.SelectedItems.Count > 0)
            {
                indexlvFamille = lvFamille.SelectedItems[0].Index;

                SQL.Open();

                SqlCommand commandSQL = new SqlCommand("SELECT * FROM medicaments INNER JOIN famille WHERE idMedicamentFamille = " + indexlvFamille, SQL.Connexion());
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

                SQL.Close();
            }
        }

        private void lvMedicaments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
