﻿using System;
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
    /// Interaktionslogik für Form_BeraterErstellen.xaml
    /// </summary>
    public partial class Form_BeraterErstellen : Window
    {
        private Boolean istGKB;

        public Boolean IstGKB
        {
            get { return istGKB; }
            set { istGKB = value; }
        }

        private Bank bankInstanz;

        public Bank Bankinstanz
        {
            get { return bankInstanz; }
            set { bankInstanz = value; }
        }


        public Form_BeraterErstellen(Boolean istGKB, Bank bankInstanz)
        {
            this.bankInstanz = bankInstanz;
            this.istGKB = istGKB;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (istGKB == true)
            {
                
                bankInstanz.GKBeraterErstellen(txtb_Nachname.Text, txtb_Vorname.Text);
                this.Close();
            }
            else
            {
                bankInstanz.BeraterErstellen(txtb_Nachname.Text, txtb_Vorname.Text);
                this.Close();
            }
        }
    }
}