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

        private List<Konto> Konten;

        public Kunde(string name, string vorname, int kundennummer, List<Konto> Konten) :base(name, vorname)
        {
            this.kundennummer = kundennummer;
            this.Konten = new List<Konto>();
        }
    }
}
