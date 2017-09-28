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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Bank_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // 
        /****************************************************
        **                                                 **
        **  buttonOnClick-Methoden der MainWindow.xaml.cs  **
        **                                                 **
        ****************************************************/

        // Neuen Kunden erstellen
        private void NeuerKunde_Click(object sender, RoutedEventArgs e)
        {
            KundeErstellen NeuerKunde = new KundeErstellen();
            NeuerKunde.ShowDialog();
        }

        // Neuen Gescshäftskunden erstellen
        private void NeuerGeschäftskunde_Click(object sender, RoutedEventArgs e)
        {
            GeschäftskundeErstellen NeuerGK = new GeschäftskundeErstellen();
            NeuerGK.ShowDialog();
        }

        // Neuen Berater erstellen
        private void NeuerBerater_Click(object sender, RoutedEventArgs e)
        {
            BeraterErstellen NeuerBerater = new BeraterErstellen();
            NeuerBerater.ShowDialog();
        }

        // Neuen Geschäftskundenberater erstellen
        private void NeuerGKBerater_Click(object sender, RoutedEventArgs e)
        {
            GKBeraterErstellen NeuerGKBerater = new GKBeraterErstellen();
            NeuerGKBerater.ShowDialog();
        }
    }
}
