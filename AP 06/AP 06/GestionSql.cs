using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace AP_06
{
    public static class GestionSql
    {
        private static string Connexionstring = @"Data Source=BTS2020-23\SQLEXPRESS;Initial Catalog=DB_gesAMM;Integrated Security=True";
        public static SqlConnection Connexion = new SqlConnection(Connexionstring);

        public static void getFamilles()
        {
            Famille.LesFamilles.Clear();
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prcGetFamilles", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                string codeFamille = resultat["FAM_CODE"].ToString();
                string libelleFamille = resultat["FAM_LIBELLE"].ToString();

                new Famille(codeFamille, libelleFamille);
            }
            Connexion.Close();
        }

        public static void getMedicaments()
        {
            Medicament.LesMedicaments.Clear();
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prcGetMedicaments", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlDataReader resultat = commande.ExecuteReader();

            while (resultat.Read())
            {
                string depotLegalMed = resultat["MED_DEPOTLEGAL"].ToString();
                string nomCommercialMed = resultat["MED_NOMCOMMERCIAL"].ToString();
                string familleCode = resultat["FAM_CODE"].ToString();
                string compositionMed = resultat["MED_COMPOSITION"].ToString();
                string effetsMed = resultat["MED_EFFETS"].ToString();
                string contreIndicationMed = resultat["MED_CONTREINDIC"].ToString();


                object prix = resultat["MED_PRIXECHANTILLON"];
                float prixEchantillonMed = 0.0f;
                if (prix.GetType() != typeof(DBNull))
                    prixEchantillonMed= (float)resultat["MED_PRIXECHANTILLON"];

                object derEtape = resultat["Derniere_etape"];
                int derniereEtape = 0;
                if(derEtape.GetType() != typeof(DBNull))
                    derniereEtape = (int)resultat["Derniere_etape"];

                new Medicament(depotLegalMed, nomCommercialMed, familleCode, compositionMed, effetsMed, contreIndicationMed, prixEchantillonMed, derniereEtape);
            }
            Connexion.Close();
            foreach (Medicament unMedicament in Medicament.LesMedicaments.Values)
            {
                getWorkflow(unMedicament);
            }
        }

        public static void getWorkflow(Medicament unMedicament)
        {
            Connexion.Open();
            SqlCommand commande = new SqlCommand("prcGetWorkflow", Connexion);
            commande.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@depotLegal", SqlDbType.VarChar, 10)
            {
                Value = unMedicament.getDepotLegalMed()
            };
            commande.Parameters.Add(param);
            SqlDataReader resultat = commande.ExecuteReader();

            List<Workflow> lesEtapes = new List<Workflow>();

            while (resultat.Read())
            {
                string depotLegalMed = resultat["MED_DEPOTLEGAL"].ToString();
                int numEtape = (int)resultat["ETP_NUM"];
                int idDecision = (int)resultat["DCS_ID"];
                DateTime dateDecision = (DateTime)resultat["dateDecision"];

                Workflow unWorkflow = new Workflow (depotLegalMed, numEtape, idDecision, dateDecision);
                lesEtapes.Add(unWorkflow);
            }
            unMedicament.setLesEtapes(lesEtapes);
            Connexion.Close();
        }


        public static Boolean ajouterMedicament(string depotLegal, string nomCommercialMed, string familleCode, string compositionMed, string effetMed, string contreIndicationMed, float prixEchantillon)
        {
            Connexion.Open();
            //appel de la procedure
            SqlCommand maRequete = new SqlCommand("prc_ajouter_medicament", Connexion);
            maRequete.CommandType = System.Data.CommandType.StoredProcedure;
            //affectation des paramètres pour la procedure stockée
            SqlParameter paramDepotLegal = new SqlParameter("@DepotLegal", System.Data.SqlDbType.NVarChar, 10);
            paramDepotLegal.Value = depotLegal;
            SqlParameter paramNomCommercial = new SqlParameter("@NomCommercial", System.Data.SqlDbType.NVarChar, 25);
            paramNomCommercial.Value = nomCommercialMed;
            SqlParameter paramFamilleCode = new SqlParameter("@FamilleCode", System.Data.SqlDbType.NVarChar, 3);
            paramFamilleCode.Value = familleCode;
            SqlParameter paramComposition = new SqlParameter("@Composition", System.Data.SqlDbType.NVarChar, 255);
            paramComposition.Value = compositionMed;
            SqlParameter paramEffet = new SqlParameter("@Effet", System.Data.SqlDbType.NVarChar, 255);
            paramEffet.Value = effetMed;
            SqlParameter paramContreIndication = new SqlParameter("@ContreIndication", System.Data.SqlDbType.NVarChar, 255);
            paramContreIndication.Value = contreIndicationMed;
            SqlParameter paramPrixEchantillon = new SqlParameter("@PrixEchantillon", System.Data.SqlDbType.Real);
            paramPrixEchantillon.Value = prixEchantillon;
            maRequete.Parameters.Add(paramDepotLegal);
            maRequete.Parameters.Add(paramNomCommercial);
            maRequete.Parameters.Add(paramFamilleCode);
            maRequete.Parameters.Add(paramComposition);
            maRequete.Parameters.Add(paramEffet);
            maRequete.Parameters.Add(paramContreIndication);
            maRequete.Parameters.Add(paramPrixEchantillon);

            //éxécuter la procedure stockée
            try
            {
                maRequete.ExecuteNonQuery();
                Connexion.Close();
                return true;
            }
            catch
            {
                Connexion.Close();
                return false;
            }
        }
    }
}
