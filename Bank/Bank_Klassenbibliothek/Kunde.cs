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


        private List<Konto> konten;

        public List<Konto> Konten
        {
            get { return konten; }
            set { konten = value; }
        }

        public Kunde(string name, string vorname, int kundennummer) :base(name, vorname)
        {
            this.kundennummer = kundennummer;
            this.Konten = new List<Konto>();
        }

        public void KontoErstellen(int iban)
        {
            Konten.Add(new Konto(iban, 0.00));
        }
    }
}

