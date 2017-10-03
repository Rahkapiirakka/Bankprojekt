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
    /// Interaktionslogik für Form_Löschen.xaml
    /// </summary>
    public partial class Form_Löschen : Window
    {
        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        private Berater beraterInstanz;

        public Berater BeraterInstanz
        {
            get { return beraterInstanz; }
            set { beraterInstanz = value; }
        }

        private Geschäftskundenberater gberaterInstanz;

        public Geschäftskundenberater GBeraterInstanz
        {
            get { return gberaterInstanz; }
            set { gberaterInstanz = value; }
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

        private string typ;

        public string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Form_Löschen(int position, string typ, Berater beraterInstanz)
        {
            InitializeComponent();
            this.position = position;
            this.typ = typ;
            this.beraterInstanz = beraterInstanz;
            Win_Löschen.Title = "Kunde löschen";
            lbl_KontoerstellenFrage.Content = "Wollen Sie den Kunden löschen?"; 
        }

        public Form_Löschen(int position, string typ, Geschäftskundenberater gberaterInstanz)
        {
            InitializeComponent();
            this.position = position;
            this.typ = typ;
            this.gberaterInstanz = gberaterInstanz;

            if (typ == "GKunde")
            {
                Win_Löschen.Title = "Geschäftskunde löschen";
                lbl_KontoerstellenFrage.Content = "Wollen Sie den Geschäftskunden löschen?";
            }

            if (typ == "Kredit")
            {
                Win_Löschen.Title = "Kredit löschen";
                lbl_KontoerstellenFrage.Content = "Wollen Sie den Kredit löschen?";
            }

        }

        public Form_Löschen(int position, string typ, Geschäftskunde gkundenInstanz)
        {
            InitializeComponent();
            this.position = position;
            this.typ = typ;
            this.gkundenInstanz = gkundenInstanz;
            Win_Löschen.Title = "Konto löschen";
            lbl_KontoerstellenFrage.Content = "Wollen Sie das Konto löschen?";
        }

        public Form_Löschen(int position, string typ, Kunde kundenInstanz)
        {
            InitializeComponent();
            this.position = position;
            this.typ = typ;
            this.kundenInstanz = kundenInstanz;
            Win_Löschen.Title = "Konto löschen";
            lbl_KontoerstellenFrage.Content = "Wollen Sie das Konto löschen?";
        }

        private void Button_Click_NichtLöschen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Löschen(object sender, RoutedEventArgs e)
        {
            switch (typ)
            {
                case "Kunde" :
                    beraterInstanz.KundeLöschen(position);
                    this.Close();
                    break;
                case "GKunde":
                    gberaterInstanz.GKundeLöschen(position);
                    this.Close();
                    break;
                case "Kredit":
                    gberaterInstanz.KreditLöschen(position);
                    this.Close();
                    break;
                case "Konto":
                    kundenInstanz.KontoLöschen(position);
                    this.Close();
                    break;
                case "GKonto":
                    gkundenInstanz.KontoLöschen(position);
                    this.Close();
                    break;
                default :
                    this.Close();
                    break;
            }
        }
    }
}
