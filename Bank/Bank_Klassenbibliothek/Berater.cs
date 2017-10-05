using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Berater : Person
    {
        #region Variablen

        private List<Kunde> kunden;

        public List<Kunde> Kunden       
        {
            get { return kunden; }
            set { kunden = value; }
        }
        
        #endregion

        #region Konstruktoren

        public Berater(string name, string vorname) : base(name, vorname)
        {
            this.kunden = new List<Kunde>(); 
        }

        #endregion

        #region Methoden

        public void KundeErstellen(string name, string vorname)
        {
            Kunden.Add(new Kunde(name, vorname));
        }

        public void KundeLöschen(int Position)
        {
            Kunden.RemoveAt(Position);
        }

        #endregion
    }
}
