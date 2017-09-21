using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Berater : Person
    {
        private int beraterID;

        public int BeraterID
        {
            get { return beraterID; }
            set { beraterID = value; }
        }

        public Berater(string name, string vorname, DateTime geburtsdatum, string straße, string hausnummer, string stadt, string postleitzahl, string telefonnummer, int beraterID) : base(name, vorname, geburtsdatum, straße, hausnummer, stadt, postleitzahl, telefonnummer)
        {
            this.beraterID = beraterID;
        }
    }
}
