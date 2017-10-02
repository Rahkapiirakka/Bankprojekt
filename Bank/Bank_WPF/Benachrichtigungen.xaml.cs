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
    /// Interaktionslogik für Benachrichtigungen.xaml
    /// </summary>
    public partial class Benachrichtigungen : Window
    {
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public Benachrichtigungen(string text)
        {
            InitializeComponent();
            this.text = text;

            txtbl_Benachrichtigung.Text = text;
        }

        private void Button_Click_OK(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
