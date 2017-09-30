using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Bank
    {
        private List<Berater> Ber;
        private List<Geschäftskundenberater> GKBer;

        public Bank()
        {
            this.Ber = new List<Berater>();
            this.GKBer = new List<Geschäftskundenberater>();
        }
    }
}
