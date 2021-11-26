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
        private static string ConnexionString = @"Data Source=BTS2020-07\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(ConnexionString);
    }
}
