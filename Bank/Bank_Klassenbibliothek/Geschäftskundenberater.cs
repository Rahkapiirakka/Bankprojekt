using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Geschäftskundenberater: Berater
    {
        private List<Kredit> kre;

        Geschäftskundenberater(string name, string vorname, int beraterID, List<Kredit> kre) :base(name, vorname, beraterID)
        {
            this.kre = new List<Kredit>(); 
        }
    }
}
