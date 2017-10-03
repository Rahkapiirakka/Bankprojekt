using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Geschäftskunde : Kunde
    {
    	/********************************
	**                             **
	**  VARIABLEN & EIGENSCHAFTEN  **
	**                             **
	********************************/
        private Boolean bonität;

        public Boolean Bonität
        {
            get { return bonität; }
            set { bonität = value; }
        }

	/******************************
	**                           **
	**  KONSTRUKTOR &FUNKTIONEN  **
	**                           **
	******************************/
        public Geschäftskunde(string name, string vorname, Boolean bonität) : base(name, vorname)
        {
            this.bonität = bonität;
        }

        public void KundeÄndern(string name, string vorname, Boolean bonität)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Bonität = bonität;
        }
    }
}
