using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Konto
    {
        /********************************
        **                             **
        **  VARIABLEN & EIGENSCHAFTEN  **
        **                             **
        ********************************/
        private int iban;

        public int IBAN
        {
            get { return iban; }
            set { iban = value; }
        }

        private double kontostand;

        public double Kontostand
        {
            get { return kontostand; }
            set { kontostand = value; }
        }

        /******************************
        **                           **
        **  KONSTRUKTOR &FUNKTIONEN  **
        **                           **
        ******************************/
        public Konto(int iban, double kontostand)
        {
            this.iban = iban;
            this.kontostand = kontostand;
        }
    }
}
