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

        public List<Kredit> Kre
        {
            get { return kre; }
            set { kre = value; }
        }

        private List<Geschäftskunde> gKunden;

        public List<Geschäftskunde> GKunden
        {
            get { return gKunden; }
            set { gKunden = value; }
        }

        public Geschäftskundenberater(string name, string vorname) : base(name, vorname)
        {
            this.kre = new List<Kredit>();
            this.GKunden = new List<Geschäftskunde>();
        }

        public void KreditErstellen(double summe, double zins, DateTime start, DateTime ende, int knr)
        {
            kre.Add(new Kredit(summe, zins, start, ende, knr));
        }

        public void GKundeErstellen(string name, string vorname, Boolean bonität)
        { 
            GKunden.Add(new Geschäftskunde(name, vorname, bonität));
        }
    }
}