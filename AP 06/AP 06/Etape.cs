using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    public class Etape
    {
        public static List<Etape> lesEtapes = new List<Etape>();

        private int numEtape;
        private string libelleEtape;

        //Constructeur
        public Etape(int leNumEtape, string leLibelleEtape)
        {
            this.numEtape = leNumEtape;
            this.libelleEtape = leLibelleEtape;
        }

        public int getNumEtape()
        {
            return this.numEtape;
        }

        public string getLibelleEtape()
        {
            return this.libelleEtape;
        }
    }
}