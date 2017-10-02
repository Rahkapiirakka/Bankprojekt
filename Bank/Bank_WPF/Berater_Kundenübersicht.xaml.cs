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
    /// Interaktionslogik für Berater_Kundenübersicht.xaml
    /// </summary>
    public partial class Berater_Kundenübersicht : Window
    {

        Bank Sparbank;

        public Berater_Kundenübersicht()
        {
            InitializeComponent();
            if (Sparbank == null)
            {
                Sparbank = new Bank();
            }

            Sparbank.Ber.Add(new Berater("Meurer", "Felix"));
            List_Berater.ItemsSource = Sparbank.Ber;
            List_GBerater.ItemsSource = Sparbank.GKBer;
        }

        // Tab Privatkunde

        private void Button_Click_KundeBearbeiten(object sender, RoutedEventArgs e)
        {
            Window Win_PKÜ = new Kontoübersicht(false, Sparbank.Ber[List_Berater.SelectedIndex].Kunden[List_Kunden.SelectedIndex]);
            Win_PKÜ.ShowDialog();
        }

        private void Button_Click_BeraterErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_KBeraterErstellen = new Form_BeraterErstellen(false, Sparbank);
            Win_KBeraterErstellen.ShowDialog();
            List_Berater.Items.Refresh();
        }

        private void Button_Click_KundeErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_KundeErstellen = new Form_KundenErstellen(false, Sparbank.Ber[List_Berater.SelectedIndex]);
            Win_KundeErstellen.ShowDialog();
            List_Kunden.Items.Refresh();
        }

        private void Selection_Changed_Berater(object sender, SelectionChangedEventArgs e)
        {
            List_Kunden.ItemsSource = Sparbank.Ber[List_Berater.SelectedIndex].Kunden;
            List_Kunden.Items.Refresh();
        }

        // Tab Geschäftskunde

        private void Button_Click_GKBeraterErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_GKBeraterErstellen = new Form_BeraterErstellen(true, Sparbank);
            Win_GKBeraterErstellen.ShowDialog();
        }

        private void Button_Click_GKundenBearbeiten(object sender, RoutedEventArgs e)
        {
            Window Win_GKÜ = new Kontoübersicht(true, Sparbank.GKBer[List_GBerater.SelectedIndex].GKunden[List_GKunden.SelectedIndex], Sparbank.GKBer[List_GBerater.SelectedIndex]);
            Win_GKÜ.ShowDialog();
        }

        private void Button_Click_GKundenErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_GKundeErstellen = new Form_KundenErstellen(true, Sparbank.GKBer[List_GBerater.SelectedIndex]);
            Win_GKundeErstellen.ShowDialog();
        }
    }
}
