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

        public Form_KontoBearbeiten()
        {
            InitializeComponent();
        }
    }
}
