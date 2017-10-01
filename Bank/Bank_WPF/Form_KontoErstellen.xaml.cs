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
    /// Interaktionslogik für Form_KontoErstellen.xaml
    /// </summary>
    public partial class Form_KontoErstellen : Window
    {
        private Kunde kundenInstanz;

        public Kunde KundenInstanz
        {
            get { return kundenInstanz; }
            set { kundenInstanz = value; }
        }

        public Form_KontoErstellen(Kunde kundenInstanz)
        {
            InitializeComponent();
            this.kundenInstanz = kundenInstanz;
        }

        private void Button_Click_KontoErstellen(object sender, RoutedEventArgs e)
        {
            // Kontonummerzuweisung
            kundenInstanz.KontoErstellen(1);
        }

        private void Button_Click_KontoNichtErstellen(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
