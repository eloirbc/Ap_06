using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AP_06
{
    public static class SQL
    {
        private static string ConnexionString = @"Data Source=BTS2020-07\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(ConnexionString);

        public static void lireLesFamilles()
        {
            Global.lesFamilles.Clear();

            SqlCommand commandSQL = new SqlCommand("prc_AllFamille", Connexion);
            SqlDataReader allData = commandSQL.ExecuteReader();

            while (allData.Read())
            {
                string unCode = allData.GetValue(0).ToString();
                string unLibelle = allData.GetValue(1).ToString();
                int unNbMedi = 0; // A CHANGER

                Famille uneFamille = new Famille(unCode, unLibelle, unNbMedi);

                Global.lesFamilles.Add(uneFamille);
            }
        }

        public static void lireLesMedicamentsParFamille()
        {
            Global.lesFamilles.Clear();

            SqlCommand commandSQL = new SqlCommand("prc_MediParFamille", Connexion);
            SqlDataReader allData = commandSQL.ExecuteReader();

            while (allData.Read())
            {
                string unDepot = allData.GetValue(0).ToString();
                string unNomCommercial = allData.GetValue(1).ToString();
                string unFamCode = allData.GetValue(2).ToString();
                string uneComposition = allData.GetValue(3).ToString();
                string unEffet = allData.GetValue(4).ToString();
                string uneContreIndi = allData.GetValue(5).ToString();

                Medicament unMedicament = new Medicament(unDepot, unNomCommercial, unFamCode, uneComposition, unEffet, uneContreIndi);

                Global.lesMedicamentsParFamilles.Add(unMedicament);
            }
        }
    }
}
