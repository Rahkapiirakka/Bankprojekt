using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Geschäftskundenberater: Berater
    {
        private Kredit kre;

        public Kredit kredit
        {
            get { return kre; }
            set { kre = value; }
        }

        Geschäftskundenberater(string name, string vorname, DateTime geburtsdatum, string straße, string hausnummer, string stadt, string postleitzahl, string telefonnummer, int beraterID, Kredit kre):base(name, vorname, geburtsdatum, straße, hausnummer, stadt, postleitzahl,telefonnummer,beraterID)
        {
            this.kre = kre;
        }
    }
}
