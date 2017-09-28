using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Geschäftskunde:Kunde
    {
        private Boolean bonität;

        public Boolean Bonität
        {
            get { return bonität; }
            set { bonität = value; }
        }

        public Geschäftskunde(string name, string vorname, int kundennummer, Boolean bonität) : base(name, vorname, kundennummer)
        {
            this.bonität = bonität;
        }
    }
}
