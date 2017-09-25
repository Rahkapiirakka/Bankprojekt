using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    class Geschäftskunde:Kunde
    {
        private Boolean bonität;

        public Boolean Bonität
        {
            get { return bonität; }
            set { bonität = value; }
        }
        Geschäftskunde(string name, string vorname, DateTime geburtsdatum, string straße, string hausnummer, string stadt, string postleitzahl, string telefonnummer,string kundennummer,Berater ber, Konto kon,Boolean bonität):base(name,vorname,geburtsdatum,straße,hausnummer,stadt,postleitzahl,telefonnummer,kundennummer,ber,kon)
        {

        }
    }
}
