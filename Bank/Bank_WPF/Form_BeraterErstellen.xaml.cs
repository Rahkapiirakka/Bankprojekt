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

namespace Bank_WPF
{
    /// <summary>
    /// Interaktionslogik für Form_BeraterErstellen.xaml
    /// </summary>
    public partial class Form_BeraterErstellen : Window
    {
        private Boolean istGK;

        public Boolean IstGK
        {
            get { return istGK; }
            set { istGK = value; }
        }

        public Form_BeraterErstellen(Boolean istGK)
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (istGK == true)
            {
                //Geschäftskunde erstellen
            }
            else
            {
                //Kunde erstellen
            }
        }
    }
}
