﻿#pragma checksum "..\..\Kredit_Beantragen.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4808A7696A8E764E494444902AB1A47D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using Bank_WPF;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Bank_WPF {
    
    
    /// <summary>
    /// Kredit_Beantragen
    /// </summary>
    public partial class Kredit_Beantragen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Bank_WPF.Kredit_Beantragen Win_KreditBeantragen;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp_StartDatum;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp_EndDatum;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_Summe;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtb_Zins;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Summe;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_Zins;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_StartDatum;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbl_EndDatum;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Kredit_Beantragen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_Beantragen;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Bank_WPF;component/form_kreditbeantragen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Kredit_Beantragen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Win_KreditBeantragen = ((Bank_WPF.Kredit_Beantragen)(target));
            return;
            case 2:
            this.dp_StartDatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.dp_EndDatum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.txtb_Summe = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\Kredit_Beantragen.xaml"
            this.txtb_Summe.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBoxInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtb_Zins = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\Kredit_Beantragen.xaml"
            this.txtb_Zins.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.NumericTextBoxInput);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbl_Summe = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.lbl_Zins = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lbl_StartDatum = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lbl_EndDatum = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.btn_Beantragen = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Kredit_Beantragen.xaml"
            this.btn_Beantragen.Click += new System.Windows.RoutedEventHandler(this.Button_Click_KreditBeantragen);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

