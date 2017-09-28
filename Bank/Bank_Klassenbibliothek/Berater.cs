﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Berater : Person
    {
        private int beraterID;

        public int BeraterID
        {
            get { return beraterID; }
            set { beraterID = value; }
        }

        private List<Kunde> Kunden;

        public Berater(string name, string vorname, int beraterID, List<Kunde> Kunden) : base(name, vorname)
        {
            this.beraterID = beraterID;
            this.Kunden = new List<Kunde>(); 
        }
    }
}
