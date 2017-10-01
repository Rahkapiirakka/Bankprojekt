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

        private List<Kunde> kunden;

        public List<Kunde> Kunden       
        {
            get { return kunden; }
            set { kunden = value; }
        }

        public Berater(string name, string vorname) : base(name, vorname)
        {
            this.kunden = new List<Kunde>(); 
        }

        public void KundeErstellen(string name, string vorname, int kundennummer)
        {
            Kunden.Add(new Kunde(name, vorname, kundennummer));
        }
    }
}
