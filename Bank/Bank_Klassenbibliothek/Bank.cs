using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Bank
    {
        #region Variablen

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
            set { gkBer = value; }
        }

        #endregion

        #region Konstruktoren

        public Bank()
        {
            this.ber = new List<Berater>();
            this.gkBer = new List<Geschäftskundenberater>();
        }

        #endregion

        #region Methoden

        public void BeraterErstellen(string name, string vorname)
        {
            ber.Add(new Berater(name, vorname));
        }

        public void GKBeraterErstellen(string name, string vorname)
        {
            gkBer.Add(new Geschäftskundenberater(name, vorname));
        }

        public void BeraterLöschen(int position)
        {
            ber.RemoveAt(position);
        }

        public void GBeraterLöschen(int position)
        {
            GKBer.RemoveAt(position);
        }

        #endregion
    }

}
