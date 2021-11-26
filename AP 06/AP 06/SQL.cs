using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AP_06
{
    class SQL
    {

        public SqlConnection Connexion()
        {
            SqlConnection connectionsBDD = new SqlConnection(@"Data Source=BTS2020-07\SQLEXPRESS;Initial Catalog=GSB_gesAMM;Integrated Security=True");
            return connectionsBDD;
        }

        public void Open()
        {
            Connexion().Open();
        }

        public void Close()
        {
            Connexion().Close();
        }
    }
}
