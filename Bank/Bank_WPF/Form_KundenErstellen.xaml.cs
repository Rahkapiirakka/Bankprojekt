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

namespace Bank_WPF
{
    /// <summary>
    /// Interaktionslogik für Form_KundenErstellen.xaml
    /// </summary>
    public partial class Form_KundenErstellen : Window
    {
        private Boolean istGK;

        public Boolean IstGK
        {
            get { return istGK; }
            set { istGK = value; }
        }

        public Form_KundenErstellen(Boolean istGK)
        {
            this.istGK = istGK;
            InitializeComponent();
        }
    }
}