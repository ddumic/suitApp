﻿#pragma checksum "C:\Users\Dragutin\Documents\Visual Studio 2013\Projects\suiteApp\suiteApp\UserControls\basketView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "80584D4060DFE5FAEE121B40DC77D14E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.33440
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace suiteApp {
    
    
    public partial class basketView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock Naziv;
        
        internal System.Windows.Controls.TextBlock Price;
        
        internal System.Windows.Controls.TextBlock kuna;
        
        internal System.Windows.Controls.TextBlock ShortDesc;
        
        internal System.Windows.Controls.Image Level1Image;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/suiteApp;component/UserControls/basketView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.Naziv = ((System.Windows.Controls.TextBlock)(this.FindName("Naziv")));
            this.Price = ((System.Windows.Controls.TextBlock)(this.FindName("Price")));
            this.kuna = ((System.Windows.Controls.TextBlock)(this.FindName("kuna")));
            this.ShortDesc = ((System.Windows.Controls.TextBlock)(this.FindName("ShortDesc")));
            this.Level1Image = ((System.Windows.Controls.Image)(this.FindName("Level1Image")));
        }
    }
}
