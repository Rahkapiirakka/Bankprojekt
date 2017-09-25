using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Kunde:Person
    {
        private int kundennummer;

        public int Kundennummer
        {
            get { return kundennummer; }
            set { kundennummer = value; }
        }

        private Konto kon;

        public Konto Kon
        {
            get { return kon; }
            set { kon = value; }
        }

        public Kunde(string kundennummer, Konto kon): base(name, vorname)
        {
            this.kundennummer = kundennummer;
            this.kon = kon;
        }
    }
}
