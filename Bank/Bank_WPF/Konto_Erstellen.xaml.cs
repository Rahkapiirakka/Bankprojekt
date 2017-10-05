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
    /// Interaktionslogik für Konto_Erstellen.xaml
    /// </summary>
    public partial class Konto_Erstellen : Window
    {
        #region Variablen

        private Kunde kundenInstanz;

        public Kunde KundenInstanz
        {
            get { return kundenInstanz; }
            set { kundenInstanz = value; }
        }

        #endregion

        #region Kontruktoren

        public Konto_Erstellen(Kunde kundenInstanz)
        {
            InitializeComponent();
            this.kundenInstanz = kundenInstanz;
        }

        #endregion

        #region Methoden

        private void Button_Click_KontoErstellen(object sender, RoutedEventArgs e)
        {
            kundenInstanz.KontoErstellen();
            this.Close();
        }

        private void Button_Click_KontoNichtErstellen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        #endregion
    }
}
