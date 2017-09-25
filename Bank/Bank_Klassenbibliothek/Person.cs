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

        public Person(string name, string vorname)
        {
            this.name = name;
            this.vorname = vorname;
        }

    }




}
