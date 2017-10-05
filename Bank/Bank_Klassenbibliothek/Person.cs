using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Klassenbibliothek
{
    public abstract class Person
    {
        #region Variablen

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

        #endregion

        #region Konstruktor

        public Person(string name, string vorname)
        {
            this.name = name;
            this.vorname = vorname;
        }

        #endregion
    }
}
