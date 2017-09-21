using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Konto
    {
        /*********************************
         **                             **
         **  VARIABLEN & EIGENSCHAFTEN  **
         **                             **
         ********************************/

        // Variable & Eigenschaften für die IBAN
        private string iban;

        public string IBAN
        {
            get { return iban; }
            set { iban = value; }
        }


        // Variable & Eigenschaften für den Kontostand
        private double kontostand;

        public double Kontostand
        {
            get { return kontostand; }
            set { kontostand = value; }
        }


        // Liste für die Speicherung der Transaktionen
        List<int> transaktionen = new List<int>();




        /******************************
        **                           **
        **  KONSTRUKTOR &FUNKTIONEN  **
        **                           **
        ******************************/

        // Konstruktor der Klasse
        public Konto(string i, double ktostd)
        {
            // ...
        }


        // Funktion: Erstellen eines Kontos 
        public void KontoErstellen()
        {
            // ...
        }


        // Funktion

    }
}
