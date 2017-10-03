using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Kredit
    {
	/********************************
	**                             **
	**  VARIABLEN & EIGENSCHAFTEN  **
	**                             **
	********************************/
        private double summe;

        public double Summe
        {
            get { return summe; }
            set { summe = value; }
        }

        private double zins;

        public double Zins
        {
            get { return zins; }
            set { zins = value; }
        }

        private DateTime start;

        public DateTime Start
        {
            get { return start; }
            set { start = value; }
        }

        private DateTime ende;

        public DateTime Ende
        {
            get { return ende; }
            set { ende = value; }
        }

        private int knr;

	public int Knr
	{
	    get { return knr;}
	    set { knr = value;}
	}
	    
	/******************************
	**                           **
	**  KONSTRUKTOR &FUNKTIONEN  **
	**                           **
	******************************/
        public Kredit (double summe, double zins, DateTime start, DateTime ende, int knr)
        {
            this.summe = summe;
            this.zins = zins;
            this.start = start;
            this.ende = ende;
            this.knr = knr;
        }
    }
}
