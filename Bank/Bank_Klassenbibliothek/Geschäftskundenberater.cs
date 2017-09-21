using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Geschäftskundenberater: Berater
    {
        private Kredit kre;

        public Kredit kredit
        {
            get { return kre; }
            set { kre = value; }
        }

        Geschäftskundenberater(int BeraterID ,Kredit kre):base(BeraterID)
        {
            this.kre = kre;
        }
    }
}
