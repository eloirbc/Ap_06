using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_06
{
    public partial class frm_EtapeNormee : Form
    {
        public frm_EtapeNormee()
        {
            InitializeComponent();
        }

        private void frm_EtapeNormee_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private SqlConnection SQL;
        private int lignes = 0;

        private void frm_EtapeNormee_Load(object sender, EventArgs e)
        {
            const string connetionString = @"Data Source=BTS2020-15\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
            SQL = new SqlConnection(connetionString);
            SqlDataReader reader;
            SQL.Open();

            SqlCommand sqlCommand = new SqlCommand("loadEtapesNormees", SQL);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = reader.GetValue(0).ToString();
                for (int i = 1; i < reader.FieldCount; i++)
                    ligne.SubItems.Add(reader.GetValue(i).ToString());
                lvEtapeNormee.Items.Add(ligne);
                lignes++;
            }
            lignes = 0;
        }

        private void lvEtapeNormee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEtapeNormee.SelectedItems.Count == 0) return;
            string norme = lvEtapeNormee.SelectedItems[0].SubItems[2].Text;
            string dateNorme = lvEtapeNormee.SelectedItems[0].SubItems[3].Text;

            tbNorme.Text = norme;
            tbDateNorme.Text = dateNorme;

            btMaj.Enabled = true;
        }

        private void btMaj_Click(object sender, EventArgs e)
        {
            if (lvEtapeNormee.SelectedItems.Count == 0) return;
            const string connetionString = @"Data Source=BTS2020-15\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
            SQL = new SqlConnection(connetionString);
            SQL.Open();

            SqlCommand sqlCommand = new SqlCommand("updateEtapeNormee", SQL) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@norme", SqlDbType.VarChar, 20) { Value = tbNorme.Text };
            SqlParameter param2 = new SqlParameter("@dateNorme", SqlDbType.Date) { Value = tbDateNorme.Text };
            SqlParameter param3 = new SqlParameter("@numEtape", SqlDbType.Int) { Value = lvEtapeNormee.SelectedItems[0].Text};
            sqlCommand.Parameters.Add(param);
            sqlCommand.Parameters.Add(param2);
            sqlCommand.Parameters.Add(param3);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            reader.Close();

            lvEtapeNormee.Items.Clear();

            SqlCommand sqlCommand2 = new SqlCommand("loadEtapesNormees", SQL);
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            reader = sqlCommand2.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = reader.GetValue(0).ToString();
                for (int i = 1; i < reader.FieldCount; i++)
                    ligne.SubItems.Add(reader.GetValue(i).ToString());
                lvEtapeNormee.Items.Add(ligne);
                lignes++;
            }
            lignes = 0;
            tbDateNorme.Clear();
            tbNorme.Clear();
            MessageBox.Show("La norme a bien été mise à jour.");
        }
    }
}
