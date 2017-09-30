using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Bank
    {
        private List<Berater> ber;

        public List<Berater> Ber
        {
            get { return ber; }
            set { ber = value; }
        }

        private List<Geschäftskundenberater> gkBer;

        public List<Geschäftskundenberater> GKBer
        {
            get { return gkBer; }
            set { gker = value; }
        }

        public Bank()
        {
            this.Ber = new List<Berater>();
            this.GKBer = new List<Geschäftskundenberater>();
        }

        public void BeraterErstellen(string name, string vorname)
        {
            Ber.Add(new Berater(name, vorname));
        }

        public void GKBeraterErstellen(string name, string vorname)
        {
            GKBer.Add(new Geschäftskundenberater(name, vorname));
        }
    }

}
