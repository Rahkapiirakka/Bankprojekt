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
    /// Interaktionslogik für Form_KontoBearbeiten.xaml
    /// </summary>
    public partial class Form_KontoBearbeiten : Window
    {
        #region Variablen

        private Boolean einzahlen;

        public Boolean Einzahlen
        {
            get { return einzahlen; }
            set { einzahlen = value; }
        }

        private Konto kontoInstanz;

        public Konto KontoInstanz
        {
            get { return kontoInstanz; }
            set { kontoInstanz = value; }
        }

        #endregion

        #region Konstruktoren

        public Form_KontoBearbeiten(Boolean einzahlen, Konto kontoInstanz)
        {
            InitializeComponent();
            this.einzahlen = einzahlen;
            this.kontoInstanz = kontoInstanz;

            if (einzahlen == true)
            {
                lbl_BetragÄndern.Content = "Betrag einzahlen";
                lbl_VerfügbaresGuthZahl.Content = kontoInstanz.Kontostand.ToString("F") + "€";
                btn_Bearbeiten.Content = "Einzahlen";
                Win_KontoBearbeiten.Title = "Geld einzahlen";
            }
            else
            {
                lbl_BetragÄndern.Content = "Gewünschter Betrag";
                lbl_VerfügbaresGuthZahl.Content = kontoInstanz.Kontostand.ToString("F") + "€";
                btn_Bearbeiten.Content = "Auszahlen";
                Win_KontoBearbeiten.Title = "Geld auszahlen";
            }
        }

        #endregion

        #region Methoden

        // Ermöglicht nur das Eingeben von Zahlen und einem Komma im Feld txtb_BetragÄndern
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

        
        private void Button_Click_BetragÄndern(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtb_BetragÄndern.Text))
            {
                if (einzahlen == true)
                {
                    if ((kontoInstanz.Kontostand + Math.Round(Convert.ToDouble(txtb_BetragÄndern.Text), 2)) < 1000000)
                    {
                        kontoInstanz.GeldEinzahlen(Math.Round(Convert.ToDouble(txtb_BetragÄndern.Text), 2));
                        this.Close();
                    }
                    else
                    {
                        Window Win_Benachrichtigung = new Benachrichtigungen("Kontolimit erreicht", "Der einzuzahlende Betrag übersteigt mit dem verfügbaren Guthaben das Kontolimit.");
                        Win_Benachrichtigung.ShowDialog();
                    }
                }
                else
                {
                    if (Math.Round(Convert.ToDouble(txtb_BetragÄndern.Text), 2) > kontoInstanz.Kontostand)
                    {
                        Window Win_Benachrichtigung = new Benachrichtigungen("Konto nicht gedeckt", "Der gewünschte Betrag übersteigt den verfügbaren Betrag auf dem Konto.");
                        Win_Benachrichtigung.ShowDialog();
                    }
                    else
                    {
                        kontoInstanz.GeldAuszahlen(Math.Round(Convert.ToDouble(txtb_BetragÄndern.Text), 2));
                        this.Close();
                    }
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
