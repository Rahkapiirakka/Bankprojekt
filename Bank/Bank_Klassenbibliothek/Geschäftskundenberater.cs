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

        private List<Geschäftskunde> GKunden;

        public Geschäftskundenberater(string name, string vorname) : base(name, vorname)
        {
            this.kre = new List<Kredit>();
            this.GKunden = new List<Geschäftskunde>();
        }

        public void KreditErstellen(int kreditID, double summe, double zins, DateTime start, DateTime ende, int knr)
        {
            kre.Add(new Kredit(kreditID, summe, zins, start, ende, knr));
        }

        public void GKundeErstellen(string name, string vorname, int kundennummer)
        {
            GKunden.Add(new Geschäftskunde(name, vorname, kundennummer, true));
        }
    }
}