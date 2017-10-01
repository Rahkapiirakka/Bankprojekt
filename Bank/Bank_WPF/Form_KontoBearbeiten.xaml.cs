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
    /// Interaktionslogik für Form_KontoBearbeiten.xaml
    /// </summary>
    public partial class Form_KontoBearbeiten : Window
    {
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

        public Form_KontoBearbeiten(Boolean einzahlen, Konto kontoInstanz)
        {
            InitializeComponent();
            this.einzahlen = einzahlen;
            this.kontoInstanz = kontoInstanz;

            if (einzahlen == true)
            {
                lbl_BetragÄndern.Content = "Betrag einzahlen";
                lbl_VerfügbaresGuthZahl.Content = kontoInstanz.Kontostand;
                btn_Bearbeiten.Content = "Einzahlen";

            }
            else
            {
                lbl_BetragÄndern.Content = "Gewünschter Betrag";
                lbl_VerfügbaresGuthZahl.Content = kontoInstanz.Kontostand;
                btn_Bearbeiten.Content = "Auszahlen";
            }
        }

        private void Button_Click_BetragÄndern(object sender, RoutedEventArgs e)
        {
            if (einzahlen == true)
            {
                kontoInstanz.Kontostand = kontoInstanz.Kontostand + Convert.ToDouble(txtb_BetragÄndern.Text);
            }
            else
            {
                if (Convert.ToDouble(txtb_BetragÄndern.Text) > kontoInstanz.Kontostand)
                {
                    Window Win_Benachrichtigung = new Benachrichtigungen("Der gewünschte Betrag übersteigt den verfügbaren Betrag auf dem Konto.");
                    Win_Benachrichtigung.ShowDialog();
                }
                else
                {
                    kontoInstanz.Kontostand = kontoInstanz.Kontostand - Convert.ToDouble(txtb_BetragÄndern.Text);
                }
            }
        }
    }
}
