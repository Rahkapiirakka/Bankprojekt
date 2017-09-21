using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public abstract class Person
    {
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private String vorname;

        public String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }

        private DateTime geburtsdatum;

        public DateTime Geburtsdatum
        {
            get { return geburtsdatum; }
            set { geburtsdatum = value; }
        }

        private String straße;

        public String Straße
        {
            get { return straße; }
            set { straße = value; }
        }

        private String hausnummer;

        public String Hausnummer
        {
            get { return hausnummer; }
            set { hausnummer = value; }
        }

        private string stadt;

        public string Stadt
        {
            get { return stadt; }
            set { stadt = value; }
        }

        private String postleitzahl;

        public String Postleitzahl
        {
            get { return postleitzahl; }
            set { postleitzahl = value; }
        }

        private String telefonnummer;

        public String Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }

        public Person(string name, string vorname, DateTime geburtsdatum, string straße, string hausnummer, string stadt, string postleitzahl, string telefonnummer)
        {
            this.name = name;
            this.vorname = vorname;
            this.geburtsdatum = geburtsdatum;
            this.straße = straße;
            this.hausnummer = hausnummer;
            this.stadt = stadt;
            this.postleitzahl = postleitzahl;
            this.telefonnummer = telefonnummer;
        }

    }




}
