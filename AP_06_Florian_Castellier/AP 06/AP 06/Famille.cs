using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_06
{
    class Famille
    {
        public string Code;
        public string Libelle;
        public int NbMedi;

        public Famille(string Code, string Libelle, int NbMedi)
        {
            this.Code = Code;
            this.Libelle = Libelle;
            this.NbMedi = NbMedi;
        }
    }
}
