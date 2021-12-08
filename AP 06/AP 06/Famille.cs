using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    public class Famille
    {
        public static Dictionary<string, Famille> LesFamilles = new Dictionary<string, Famille>();

        private string codeFamille;
        private string libelleFamille;

        //Constructeur
        public Famille(string leCodeFamille, string leLibelleFamille)
        {
            this.codeFamille = leCodeFamille;
            this.libelleFamille = leLibelleFamille;
            LesFamilles.Add(codeFamille, this);
        }

        public string getCodeFamille()
        {
            return this.codeFamille;
        }

        public string getLibelleFamille()
        {
            return this.libelleFamille;
        }
    }
}
