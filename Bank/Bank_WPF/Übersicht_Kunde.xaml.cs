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
    /// Interaktionslogik für Übersicht_Kunde.xaml
    /// </summary>
    public partial class Übersicht_Kunde : Window
    {
        #region Variablen
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

        #endregion

        #region Kontruktoren 
        // Konstruktoren der Klasse Übersicht_Kunde

        public Übersicht_Kunde(Boolean istGK, Kunde kundenInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.kundenInstanz = kundenInstanz;
            tab_Kredite.IsEnabled = false;
            btn_GeldAuszahlen.IsEnabled = false;
            btn_GeldEinzahlen.IsEnabled = false;
            btn_KontoLöschen.IsEnabled = false;
            List_Konten.ItemsSource = kundenInstanz.Konten;

            chkb_Bonität.IsEnabled = false;
            lbl_Kundennummer.Content = lbl_Kundennummer.Content + kundenInstanz.Kundennummer.ToString();
            txtb_Vorname.Text = kundenInstanz.Vorname;
            txtb_Nachname.Text = kundenInstanz.Name;

            btn_KreditLöschen.IsEnabled = false;
        }

        public Übersicht_Kunde(Boolean istGK, Geschäftskunde gkundenInstanz, Geschäftskundenberater gberaterInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.gkundenInstanz = gkundenInstanz;
            this.gberaterInstanz = gberaterInstanz;
            tab_Kredite.IsEnabled = true;
            btn_GeldAuszahlen.IsEnabled = false;
            btn_GeldEinzahlen.IsEnabled = false;
            btn_KontoLöschen.IsEnabled = false;
            List_Konten.ItemsSource = gkundenInstanz.Konten;
            List_Kredite.ItemsSource = gberaterInstanz.Kre.Where(item => item.Knr == gkundenInstanz.Kundennummer);

            chkb_Bonität.IsEnabled = true;
            chkb_Bonität.IsChecked = gkundenInstanz.Bonität;
            lbl_Kundennummer.Content = lbl_Kundennummer.Content + gkundenInstanz.Kundennummer.ToString();
            txtb_Vorname.Text = gkundenInstanz.Vorname;
            txtb_Nachname.Text = gkundenInstanz.Name;

            btn_KreditLöschen.IsEnabled = false;
        }

#endregion

        #region Tab Konto
        // Methoden für Konto

        private void Button_Click_KontoErstellen(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_KontenErstellen = new Form_KontoErstellen(gkundenInstanz);
                Win_KontenErstellen.ShowDialog();
                List_Konten.Items.Refresh();
            }
            else
            {
                Window Win_KontenErstellen = new Form_KontoErstellen(kundenInstanz);
                Win_KontenErstellen.ShowDialog();
                List_Konten.Items.Refresh();
            }
        }

        private void Button_Click_GeldEinzahlen(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_GeldEinzahlen = new Form_KontoBearbeiten(true, gkundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldEinzahlen.ShowDialog();
                List_Konten.Items.Refresh();
            }
            else
            {
                Window Win_GeldEinzahlen = new Form_KontoBearbeiten(true, kundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldEinzahlen.ShowDialog();
                List_Konten.Items.Refresh();
            }
        }

        private void Button_Click_GeldAbheben(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_GeldAbheben = new Form_KontoBearbeiten(false, gkundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldAbheben.ShowDialog();
                List_Konten.Items.Refresh();
            }
            else
            {
                Window Win_GeldAbheben = new Form_KontoBearbeiten(false, kundenInstanz.Konten[List_Konten.SelectedIndex]);
                Win_GeldAbheben.ShowDialog();
                List_Konten.Items.Refresh();
            }
        }

        private void Selection_Changed_Konten(object sender, SelectionChangedEventArgs e)
        {
            if (List_Konten.HasItems)
            {
                btn_GeldAuszahlen.IsEnabled = true;
                btn_GeldEinzahlen.IsEnabled = true;
                btn_KontoLöschen.IsEnabled = true;
            }
            else
            {
                btn_GeldAuszahlen.IsEnabled = false;
                btn_GeldEinzahlen.IsEnabled = false;
                btn_KontoLöschen.IsEnabled = false;
            }

        }

        private void Button_Click_KontoLöschen(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                Window Win_KontoLöschen = new Form_Löschen(List_Konten.SelectedIndex, "GKonto", gkundenInstanz);
                Win_KontoLöschen.ShowDialog();
                List_Konten.Items.Refresh();
            }
            else
            {
                Window Win_KontoLöschen = new Form_Löschen(List_Konten.SelectedIndex, "Konto", kundenInstanz);
                Win_KontoLöschen.ShowDialog();
                List_Konten.Items.Refresh();
            }
        }

#endregion

        #region Tab Kredite
        // Methoden für Kredite

        private void Button_Click_KreditBeantragen(object sender, RoutedEventArgs e)
        {
            if (gkundenInstanz.Bonität)
            {
                Window Win_KreditBeantragen = new Form_Kreditbeantragen(gberaterInstanz, gkundenInstanz);
                Win_KreditBeantragen.ShowDialog();
                List_Kredite.ItemsSource = gberaterInstanz.Kre.Where(item => item.Knr == gkundenInstanz.Kundennummer);
                List_Kredite.Items.Refresh();
            }
            else
            {
                Window Win_Benachrichtigung = new Benachrichtigungen("Keine Bonität", "Dieser Kunde besitzt keine Bonität. Sollte sich diese nach eben erfolgter Prüfung geändert haben, können Sie den Bonitätsstatus in den Kundeninformationen ändern.");
                Win_Benachrichtigung.ShowDialog();
            }
        }

        private void Button_Click_KreditLöschen(object sender, RoutedEventArgs e)
        {
            Window Win_KreditLöschen = new Form_Löschen(List_Kredite.SelectedIndex, "Kredit", gberaterInstanz);
            Win_KreditLöschen.ShowDialog();
            List_Kredite.ItemsSource = gberaterInstanz.Kre.Where(item => item.Knr == gkundenInstanz.Kundennummer);
            List_Kredite.Items.Refresh();
        }

        private void Selection_Changed_Kredite(object sender, SelectionChangedEventArgs e)
        {
            if (List_Kredite.HasItems)
            {
                btn_KreditLöschen.IsEnabled = true;
            }
            else
            {
                btn_KreditLöschen.IsEnabled = false;
            }
        }

        #endregion

        #region Tab Kundeninformation
        // Methoden für Kundenonformationen

        private void Button_Click_KundenÄndern(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtb_Nachname.Text) && !String.IsNullOrWhiteSpace(txtb_Vorname.Text))
            {
                if (istGK == true)
                {
                    gkundenInstanz.KundeÄndern(txtb_Nachname.Text, txtb_Vorname.Text, chkb_Bonität.IsChecked.Value);
                    Window Win_Benachrichtigung = new Benachrichtigungen("Kundeninformationen geändert", "Die Kundeninformationen wurden für diesen Kunden geändert.");
                    Win_Benachrichtigung.ShowDialog();
                }
                else
                {
                    kundenInstanz.KundeÄndern(txtb_Nachname.Text, txtb_Vorname.Text);
                    Window Win_Benachrichtigung = new Benachrichtigungen("Kundeninformationen geändert", "Die Kundeninformationen wurden für diesen Kunden geändert.");
                    Win_Benachrichtigung.ShowDialog();
                }
            }
            else
            {
                Window Win_Benachrichtigung = new Benachrichtigungen("Fehlende Informationen", "Füllen Sie bitte alle Textfelder aus");
                Win_Benachrichtigung.ShowDialog();
            }
        }

#endregion

    }
}
