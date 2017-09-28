using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    class Geschäftskunde:Kunde
    {
        private Boolean bonität;

        public Boolean Bonität
        {
            get { return bonität; }
            set { bonität = value; }
        }
        Geschäftskunde(string name, string vorname, int kundennummer, List<Konto> Konten, Boolean bonität) : base(name, vorname, kundennummer, Konten)
        {
            this.bonität = bonität;
        }
    }
}
