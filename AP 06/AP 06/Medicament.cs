using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    public class Medicament
    {
        public static Dictionary<string, Medicament> LesMedicaments = new Dictionary<string, Medicament>();

        private string depotLegalMed;
        private string nomCommercialMed;
        private Famille laFamille;
        private string compositionMed;
        private string effetsMed;
        private string contreIndicationMed;
        private float prixEchantillonMed;
        private int derniereEtape;
        private List<Workflow> lesEtapes = new List<Workflow>();

        //Constructeur
        public Medicament(string leDepotLegalMed, string leNomCommercialMed, string laFamilleCode, string laCompositionMed, string leEffetMed, string laContreIndicationMed, float lePrixEchantillonMed, int laDerniereEtape)
        {
            this.depotLegalMed = leDepotLegalMed;
            this.nomCommercialMed = leNomCommercialMed;
            this.laFamille = Famille.LesFamilles[laFamilleCode];
            this.compositionMed = laCompositionMed;
            this.effetsMed = leEffetMed;
            this.contreIndicationMed = laContreIndicationMed;
            this.prixEchantillonMed = lePrixEchantillonMed;
            this.derniereEtape = laDerniereEtape;
            LesMedicaments.Add(depotLegalMed, this);
        }
        public string getDepotLegalMed()
        {
            return this.depotLegalMed;
        }
        public string getNomCommercialMed()
        {
            return this.nomCommercialMed;
        }
        public Famille getLaFamille()
        {
            return this.laFamille;
        }
        public string getCompositionMed()
        {
            return this.compositionMed;
        }
        public string getEffetsMed()
        {
            return this.effetsMed;
        }
        public string getContreIndicationMed()
        {
            return this.contreIndicationMed;
        }
        public float getPrixEchantillon()
        {
            return this.prixEchantillonMed;
        }
        public int getDerniereEtape()
        {
            return this.derniereEtape;
        }
        public List<Workflow> getLesEtapes()
        {
            return this.lesEtapes;
        }
        public void setLesEtapes(List<Workflow> lesEtapes)
        {
            this.lesEtapes = lesEtapes;
        }
    }
}
