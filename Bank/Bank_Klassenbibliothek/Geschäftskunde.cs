using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Geschäftskunde : Kunde
    {
        #region Variablen

        private Boolean bonität;

        public Boolean Bonität
        {
            get { return bonität; }
            set { bonität = value; }
        }

        #endregion

        #region Konstruktoren

        public Geschäftskunde(string name, string vorname, Boolean bonität) : base(name, vorname)
        {
            this.bonität = bonität;
        }

        #endregion

        #region Methoden

        public void KundeÄndern(string name, string vorname, Boolean bonität)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.Bonität = bonität;
        }

        #endregion
    }
}
