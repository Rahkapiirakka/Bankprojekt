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
    /// Interaktionslogik für Berater_Kunden_Auswahl.xaml
    /// </summary>
    public partial class Berater_Kunden_Auswahl : Window
    {
        public Berater_Kunden_Auswahl()
        {
            Bank Sparbank = new Bank();
            InitializeComponent();
        }


        // Tab Privatkunde

        private void Button_Click_KundeBearbeiten(object sender, RoutedEventArgs e)
        {
            Window Win_PKÜ = new Privat_Kontenübersicht();
            Win_PKÜ.ShowDialog();
        }

        private void Button_Click_BeraterErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_KBeraterErstellen = new Form_BeraterErstellen(false);
            Win_KBeraterErstellen.ShowDialog();
        }

        // Tab Geschäftskunde

        private void Button_Click_GKBeraterErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_GKBeraterErstellen = new Form_BeraterErstellen(true);
            Win_GKBeraterErstellen.ShowDialog();
        }

        private void Button_Click_GKundenBearbeiten(object sender, RoutedEventArgs e)
        {
            Window Win_GKÜ = new Geschäft_Kontoübersicht();
            Win_GKÜ.ShowDialog();
        }
    }
}
