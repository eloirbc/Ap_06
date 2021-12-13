using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    internal class Medicament
    {
        public string DepotLegal;
        public string NomCommercial;
        public string FamCode;
        public string Composition;
        public string Effets;
        public string ContreIndic;
        public float Prix;

        public Medicament(string DepotLegal, string NomCommercial, string FamCode, string Composition, string Effets, string ContreIndi, float unPrix)
        {
            this.DepotLegal = DepotLegal;
            this.NomCommercial = NomCommercial;
            this.FamCode = FamCode;
            this.Composition = Composition;
            this.Effets = Effets;
            this.ContreIndic = ContreIndi;
            this.Prix = unPrix;
        }
    }
}
