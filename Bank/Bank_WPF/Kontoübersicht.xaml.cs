using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bank_Klassenbibliothek;

namespace Bank_WPF
{
    /// <summary>
    /// Interaktionslogik für Kontoübersicht.xaml
    /// </summary>
    public partial class Kontoübersicht : Window
    {
        private Boolean istGK;

        public Boolean IstGK
        {
            get { return istGK; }
            set { istGK = value; }
        }

        private Kunde kundenInstanz;

        public Kunde KundenInstanz
        {
            get { return kundenInstanz; }
            set { kundenInstanz = value; }
        }

        private Geschäftskunde gkundenInstanz;

        public Geschäftskunde GKundenInstanz
        {
            get { return gkundenInstanz; }
            set { gkundenInstanz = value; }
        }


        public Kontoübersicht(Boolean istGK, Kunde kundenInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.kundenInstanz = kundenInstanz;
            tab_Kredite.IsEnabled = false;
        }

        public Kontoübersicht(Boolean istGK, Geschäftskunde gkundenInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.gkundenInstanz = gkundenInstanz;
            tab_Kredite.IsEnabled = true;
        }
    }
}
