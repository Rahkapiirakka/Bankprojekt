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

        private Geschäftskundenberater gberaterInstanz;

        public Geschäftskundenberater GBeraterInstanz
        {
            get { return gberaterInstanz; }
            set { gberaterInstanz = value; }
        }

        public Kontoübersicht(Boolean istGK, Kunde kundenInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.kundenInstanz = kundenInstanz;
            tab_Kredite.IsEnabled = false;
            List_Konten.ItemsSource = kundenInstanz.Konten;
        }

        public Kontoübersicht(Boolean istGK, Geschäftskunde gkundenInstanz, Geschäftskundenberater gberaterInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.gkundenInstanz = gkundenInstanz;
            tab_Kredite.IsEnabled = true;
            List_Konten.ItemsSource = kundenInstanz.Konten;
            List_Kredite.ItemsSource = gberaterInstanz.Kre;
        }

        private void Button_Click_KontoErstellen(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_KontenErstellen = new Form_KontoErstellen(gkundenInstanz);
                Win_KontenErstellen.ShowDialog();
            }
            else
            {
                Window Win_KontenErstellen = new Form_KontoErstellen(kundenInstanz);
                Win_KontenErstellen.ShowDialog();
            }
        }

        private void Button_Click_GeldEinzahlen(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_GeldEinzahlen = new Form_KontoBearbeiten(true, gkundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldEinzahlen.ShowDialog();
            }
            else
            {
                Window Win_GeldEinzahlen = new Form_KontoBearbeiten(true, kundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldEinzahlen.ShowDialog();
            }
        }

        private void Button_Click_GeldAbheben(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_GeldAbheben = new Form_KontoBearbeiten(false, gkundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldAbheben.ShowDialog();
            }
            else
            {
                Window Win_GeldAbheben = new Form_KontoBearbeiten(false, kundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldAbheben.ShowDialog();
            }
        }

        private void Button_Click_KreditBeantragen(object sender, RoutedEventArgs e)
        {
            Window Win_KreditBeantragen = new Form_Kreditbeantragen(gberaterInstanz);
            Win_KreditBeantragen.ShowDialog();
        }
    }
}
