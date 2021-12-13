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
    public partial class FormConnexion : Form
    {
        public FormConnexion()
        {
            InitializeComponent();
        }

        string depot;
        int num;
        int dcs;
        DateTime date;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void btConnexion_Click(object sender, EventArgs e)
        {
            Connexion.Open();

            SqlCommand commandSQL = new SqlCommand("prc_connexion", Connexion);

            SqlDataReader allData = commandSQL.ExecuteReader();

            bool trouver = false;

            while (allData.Read() && !trouver)
            {
                if(allData.GetValue(1).ToString() == tbIdentifiant.Text && allData.GetValue(2).ToString() == tbMotDePasse.Text) trouver = true;
            }

            Connexion.Close();
            if (!trouver) MessageBox.Show("AUCUN COMPTE TROUVER","ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Hide();
                Menu oneMenu = new Menu();

                oneMenu.ShowDialog();
            }
        }
    }
}
