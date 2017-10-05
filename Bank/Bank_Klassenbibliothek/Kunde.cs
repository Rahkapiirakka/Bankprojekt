using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Kunde : Person
    {
        #region Variablen

        public static int auto_kundennummer;

        private int kundennummer;

        public int Kundennummer
        {
            get { return kundennummer; }
            set { kundennummer = value; }
        }

        private List<Konto> konten;

        public List<Konto> Konten
        {
            get { return konten; }
            set { konten = value; }
        }

        #endregion

        #region Konstruktoren

        public Kunde(string name, string vorname) :base(name, vorname)
        {
            this.kundennummer = System.Threading.Interlocked.Increment(ref auto_kundennummer);
            this.Konten = new List<Konto>();
        }

        #endregion

        #region Methoden

        public void KontoErstellen()
        {
            Konten.Add(new Konto(0.00));
        }

        public void KontoLöschen(int position)
        {
            Konten.RemoveAt(position);
        }

        public void KundeÄndern(string name, string vorname)
        {
            this.Name = name;
            this.Vorname = vorname;
        }

        #endregion
    }
}
