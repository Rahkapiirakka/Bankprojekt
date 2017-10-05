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
    /// Interaktionslogik für Auswahl_Kunden_Berater.xaml
    /// </summary>
    public partial class Auswahl_Kunden_Berater : Window
    {
        #region Variablen

        public Bank Sparbank;

        #endregion

        #region Konstruktoren

        public Auswahl_Kunden_Berater()
        {
            InitializeComponent();

            if (Sparbank == null)
            {
                Sparbank = new Bank();
            }

            List_Berater.ItemsSource = Sparbank.Ber;
            List_GBerater.ItemsSource = Sparbank.GKBer;
            btn_GKundebearbeiten.IsEnabled = false;
            btn_Kundebearbeiten.IsEnabled = false;
            btn_NeuerGKunde.IsEnabled = false;
            btn_NeuerKunde.IsEnabled = false;
            btn_KundeLöschen.IsEnabled = false;
            btn_GKundeLöschen.IsEnabled = false;
        }

        #endregion

        #region Tab Privatkunden
        // Methoden für Privatkunde

        private void Button_Click_KundeBearbeiten(object sender, RoutedEventArgs e)
        {
            Window Win_PKÜ = new Übersicht_Kunde(false, Sparbank.Ber[List_Berater.SelectedIndex].Kunden[List_Kunden.SelectedIndex]);
            Win_PKÜ.ShowDialog();
            List_Kunden.Items.Refresh();
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
                btn_NeuerKunde.IsEnabled = true;
        }

        private void Selection_Changed_Kunde(object sender, SelectionChangedEventArgs e)
        {
            if (List_Kunden.HasItems)
            {
                btn_Kundebearbeiten.IsEnabled = true;
                btn_KundeLöschen.IsEnabled = true;
            }
            else
            {
                btn_Kundebearbeiten.IsEnabled = false;
                btn_KundeLöschen.IsEnabled = false;
            }
        }

        private void Button_Click_KundeLöschen(object sender, RoutedEventArgs e)
        {
            Window Win_KundeLöschen = new Form_Löschen(List_Kunden.SelectedIndex, "Kunde", Sparbank.Ber[List_Berater.SelectedIndex]);
            Win_KundeLöschen.ShowDialog();
            List_Kunden.Items.Refresh();
        }

        #endregion

        #region Tab Geschäftskunde
        // Methoden für Geschäftskunde

        private void Button_Click_GKBeraterErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_GKBeraterErstellen = new Form_BeraterErstellen(true, Sparbank);
            Win_GKBeraterErstellen.ShowDialog();
            List_GBerater.Items.Refresh();
        }

        private void Button_Click_GKundenBearbeiten(object sender, RoutedEventArgs e)
        {
            Window Win_GKÜ = new Übersicht_Kunde(true, Sparbank.GKBer[List_GBerater.SelectedIndex].GKunden[List_GKunden.SelectedIndex], Sparbank.GKBer[List_GBerater.SelectedIndex]);
            Win_GKÜ.ShowDialog();
            List_GKunden.Items.Refresh();
        }

        private void Button_Click_GKundenErstellen(object sender, RoutedEventArgs e)
        {
            Window Win_GKundeErstellen = new Form_KundenErstellen(true, Sparbank.GKBer[List_GBerater.SelectedIndex]);
            Win_GKundeErstellen.ShowDialog();
            List_GKunden.Items.Refresh();
        }

        private void Selection_Changed_GBerater(object sender, SelectionChangedEventArgs e)
        {
                List_GKunden.ItemsSource = Sparbank.GKBer[List_GBerater.SelectedIndex].GKunden;
                List_GKunden.Items.Refresh();
                btn_NeuerGKunde.IsEnabled = true;
        }

        private void Selection_Changed_GKunde(object sender, SelectionChangedEventArgs e)
        {
            if (List_GKunden.HasItems)
            {
                btn_GKundebearbeiten.IsEnabled = true;
                btn_GKundeLöschen.IsEnabled = true;
            }
            else
            {
                btn_GKundebearbeiten.IsEnabled = false;
                btn_GKundeLöschen.IsEnabled = false;
            }
        }

        private void Button_Click_GKundeLöschen(object sender, RoutedEventArgs e)
        {
            Window Win_GKundeLöschen = new Form_Löschen(List_GKunden.SelectedIndex, "GKunde", Sparbank.GKBer[List_GBerater.SelectedIndex]);
            Win_GKundeLöschen.ShowDialog();
            List_GKunden.Items.Refresh();
        }

        #endregion
    }  
}
