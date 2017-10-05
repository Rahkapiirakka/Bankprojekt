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
    /// Interaktionslogik für Form_KundenErstellen.xaml
    /// </summary>
    public partial class Form_KundenErstellen : Window
    {
        #region Variablen

        private Boolean istGK;

        public Boolean IstGK
        {
            get { return istGK; }
            set { istGK = value; }
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

        #endregion

        #region Konstruktoren

        public Form_KundenErstellen(Boolean istGK, Berater beraterInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.beraterInstanz = beraterInstanz; 
            Chkb_Bonität.IsEnabled = false;
        }

        public Form_KundenErstellen(Boolean istGK, Geschäftskundenberater gberaterInstanz)
        {
            InitializeComponent();
            this.istGK = istGK;
            this.gberaterInstanz = gberaterInstanz;
            Chkb_Bonität.IsEnabled = true;
        }

        #endregion

        #region Methoden

        private void Button_Clicked_KundeErstellen(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtb_KundeNachname.Text) && !String.IsNullOrWhiteSpace(txtb_KundeVorname.Text))
            {
                if (istGK == true)
                {
                    this.gberaterInstanz.GKundeErstellen(txtb_KundeNachname.Text, txtb_KundeVorname.Text, Chkb_Bonität.IsChecked.Value);
                    this.Close();
                }
                else
                {
                    this.beraterInstanz.KundeErstellen(txtb_KundeNachname.Text, txtb_KundeVorname.Text);
                    this.Close();
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
