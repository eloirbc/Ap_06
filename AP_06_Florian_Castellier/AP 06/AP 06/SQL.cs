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
        private static string ConnexionString = @"Data Source=BTS2020-23\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True;MultipleActiveResultSets=True;";
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

                Global.lesFamilles.Add(unCode,uneFamille);
            }
        }
    }
}
