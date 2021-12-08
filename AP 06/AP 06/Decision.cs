using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    internal class Decision
    {
        public static List<Decision> lesDecisions = new List<Decision>();

        private int idDecision;
        private string libelleDecision;

        //Constructeur
        public Decision(int leIdDecision, string leLibelleDecision)
        {
            this.idDecision = leIdDecision;
            this.libelleDecision = leLibelleDecision;
        }

        public int getIdDecision()
        {
            return this.idDecision;
        }

        public string getLibelleDecision()
        {
            return this.libelleDecision;
        }
    }
}
