﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public class Kredit
    {
        private int kreditID;

        public int KreditID
        {
            get { return kreditID; }
            set { kreditID = value; }
        }

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

        private Kunde k;

        public Kunde kunde
        {
            get { return k; }
            set { k = value; }
        }

        public Kredit (int kreditID, double summe, double zins, DateTime start, DateTime ende, Kunde k)
        {
            this.kreditID = kreditID;
            this.summe = summe;
            this.zins = zins;
            this.start = start;
            this.ende = ende;
            this.k = k;

        }

    }
}