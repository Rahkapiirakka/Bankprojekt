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
    /// Interaktionslogik für Form_Kreditbeantragen.xaml
    /// </summary>
    public partial class Form_Kreditbeantragen : Window
    {
        private Geschäftskundenberater gberaterInstanz;

        public Geschäftskundenberater GBeraterInstanz
        {
            get { return gberaterInstanz; }
            set { gberaterInstanz = value; }
        }

        public Form_Kreditbeantragen(Geschäftskundenberater gberaterInstanz)
        {
            InitializeComponent();
            this.gberaterInstanz = gberaterInstanz;
        }

        private void Button_Click_KreditBeantragen(object sender, RoutedEventArgs e)
        {
            gberaterInstanz.KreditErstellen(Convert.ToDouble(txtb_Summe.Text), Convert.ToDouble(txtb_Zins.Text), dp_StartDatum.SelectedDate.Value.Date, dp_EndDatum.SelectedDate.Value.Date, 1);
        }
    }
}
