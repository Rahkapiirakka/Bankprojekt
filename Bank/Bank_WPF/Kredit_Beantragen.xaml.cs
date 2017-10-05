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
using System.Text.RegularExpressions;

namespace Bank_WPF
{
    /// <summary>
    /// Interaktionslogik für Kredit_Beantragen.xaml
    /// </summary>
    public partial class Kredit_Beantragen : Window
    {
        #region Variablen

        private Geschäftskundenberater gberaterInstanz;

        public Geschäftskundenberater GBeraterInstanz
        {
            get { return gberaterInstanz; }
            set { gberaterInstanz = value; }
        }

        private Geschäftskunde gkundenInstanz;

        public Geschäftskunde GKundenInstanz
        {
            get { return gkundenInstanz; }
            set { gkundenInstanz = value; }
        }

        #endregion

        #region Konstruktoren

        public Kredit_Beantragen(Geschäftskundenberater gberaterInstanz, Geschäftskunde gkundenInstanz)
        {
            InitializeComponent();
            this.gberaterInstanz = gberaterInstanz;
            this.gkundenInstanz = gkundenInstanz;
        }

        #endregion

        #region Methoden

        // Ermöglicht nur das Eingeben von Zahlen und einem Komma in den Feldern txtb_Summe und txtb_Zins
        void NumericTextBoxInput(object sender, TextCompositionEventArgs e)
        {
            var regex = new Regex(@"^[0-9]*(?:\,[0-9]*)?$");
            if (regex.IsMatch(e.Text) && !(e.Text == "," && ((TextBox)sender).Text.Contains(e.Text)))
            {
                e.Handled = false;
            }   
            else
            {
                e.Handled = true;
            }    
        }

        private void Button_Click_KreditBeantragen(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtb_Summe.Text) && !String.IsNullOrWhiteSpace(txtb_Zins.Text) && !(dp_StartDatum.SelectedDate == null) && !(dp_EndDatum.SelectedDate == null))
            {
                if (dp_StartDatum.SelectedDate > DateTime.Today.AddDays(-1))
                {
                    if (dp_StartDatum.SelectedDate < dp_EndDatum.SelectedDate)
                    {
                        if (Math.Round(Convert.ToDouble(txtb_Summe.Text)) >= 1000000)
                        {
                            Window Win_Benachrichtigung = new Benachrichtigungen("Kredit zu hoch", "Die eingegebene Kreditsumme übersteigt die maximal mögliche Kredithöhe.");
                            Win_Benachrichtigung.ShowDialog();
                        }
                        else if (Math.Round(Convert.ToDouble(txtb_Zins.Text)) >= 100)
                        {
                            Window Win_Benachrichtigung = new Benachrichtigungen("Zins zu hoch", "Der eingegebene Zinssatz übersteigt den maximal möglichen Zinssatz.");
                            Win_Benachrichtigung.ShowDialog();
                        }
                        else
                        {
                            gberaterInstanz.KreditErstellen(Math.Round(Convert.ToDouble(txtb_Summe.Text), 2), Math.Round(Convert.ToDouble(txtb_Zins.Text), 2), dp_StartDatum.SelectedDate.Value.Date, dp_EndDatum.SelectedDate.Value.Date, gkundenInstanz.Kundennummer);
                            this.Close();
                        }
                    }
                    else
                    {
                        Window Win_Benachrichtigung = new Benachrichtigungen("Zeitraum falsch", "Das Startdatum muss vor dem Enddatum liegen.");
                        Win_Benachrichtigung.ShowDialog();
                    }
                }
                else
                {
                    Window Win_Benachrichtigung = new Benachrichtigungen("Zeitraum falsch", "Das Startdatum darf nicht in der Vergangenheit liegen.");
                    Win_Benachrichtigung.ShowDialog();
                }
            }
        }

        #endregion
    }
}
