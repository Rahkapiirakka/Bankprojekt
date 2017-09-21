using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Kunde:Person
    {
        private string kundennummer;

        public string Kundennummer
        {
            get { return kundennummer; }
            set { kundennummer = value; }
        }

        private Berater ber;

        public Berater berater
        {
            get { return ber; }
            set { ber = value; }
        }
        private Konto kon;

        public Konto konto
        {
            get { return kon; }
            set { kon = value; }
        }


        public Kunde(string name, string vorname, DateTime geburtsdatum, string straße, string hausnummer,string stadt,string postleitzahl, string telefonnummer,string kundennummer,Berater ber,Konto kon): base(name,vorname,geburtsdatum,straße,hausnummer,stadt,postleitzahl,telefonnummer)
        {
            this.kundennummer = kundennummer;
            this.ber = ber;
            this.kon = kon;
        }
    }
}
