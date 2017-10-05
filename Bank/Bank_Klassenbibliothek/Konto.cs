using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Konto
    {
        #region Variablen

        private static int AUTO_KONTONUMMER;

        private int kontonummer;

        public int Kontonummer
        {
            get { return kontonummer; }
            set { kontonummer = value; }
        }

        private double kontostand;

        public double Kontostand
        {
            get { return kontostand; }
            set { kontostand = value; }
        }

        #endregion

        #region Konstruktor

        public Konto(double kontostand)
        {
            this.kontonummer = System.Threading.Interlocked.Increment(ref AUTO_KONTONUMMER);
            this.kontostand = kontostand;
        }

        #endregion

        #region Methoden

        public void GeldEinzahlen(double Betrag)
        {
            kontostand = kontostand + Betrag;
        }

        public void GeldAuszahlen(double Betrag)
        {
            kontostand = kontostand - Betrag;
        }

        #endregion
    }
}
