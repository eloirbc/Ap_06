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
    public partial class frm_Workflow : Form
    {
        SqlConnection SQL;
        int lignes = 0;

        public frm_Workflow()
        {
            InitializeComponent();
        }

        private void frm_Workflow_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lvWorkflowMedicament_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWorkflowMedicament.SelectedItems.Count == 0) return;
            string connetionString = @"Data Source=BTS2020-15\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
            SQL = new SqlConnection(connetionString);
            SQL.Open();

            string codeMedic = lvWorkflowMedicament.SelectedItems[0].Text;

            SqlCommand sqlCommand = new SqlCommand("fetchEtapes",SQL) { CommandType = CommandType.StoredProcedure };
            SqlParameter param = new SqlParameter("@code", SqlDbType.VarChar) { Value =  codeMedic };
            sqlCommand.Parameters.Add(param);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = reader.GetValue(0).ToString();
                for (int i = 1; i < reader.FieldCount; i++)
                    ligne.SubItems.Add(reader.GetValue(i).ToString());
                lvWorkflowMedicament.Items.Add(ligne);
                lignes++;
            }
            lignes = 0;
        }

        private void frm_Workflow_Load(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=BTS2020-15\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
            SQL = new SqlConnection(connetionString);
            SqlDataReader reader;
            SQL.Open();

            SqlCommand sqlCommand = new SqlCommand("loadWorkflow", SQL);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ligne = new ListViewItem();
                ligne.Text = reader.GetValue(0).ToString();
                for (int i = 1; i < reader.FieldCount; i++)
                    ligne.SubItems.Add(reader.GetValue(i).ToString());
                lvWorkflowMedicament.Items.Add(ligne);
                lignes++;
            }
            lignes = 0;
        }
    }
}
