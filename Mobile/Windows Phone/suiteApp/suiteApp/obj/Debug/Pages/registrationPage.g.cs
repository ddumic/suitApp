﻿#pragma checksum "C:\Users\Dragutin\documents\visual studio 2013\Projects\suiteApp\suiteApp\Pages\registrationPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "65D54C280B07B50A745F29EE54452BD0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34011
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CS.Windows.Controls;
using Microsoft.Phone.Controls;
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
    
    
    public partial class registrationPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock naslovStranice;
        
        internal System.Windows.Controls.StackPanel pageContent;
        
        internal System.Windows.Controls.TextBlock UserName;
        
        internal System.Windows.Controls.TextBox nameValue;
        
        internal System.Windows.Controls.TextBlock Surname;
        
        internal System.Windows.Controls.TextBox surnameValue;
        
        internal System.Windows.Controls.TextBlock eMail;
        
        internal System.Windows.Controls.TextBox emailValue;
        
        internal System.Windows.Controls.TextBlock Username;
        
        internal System.Windows.Controls.TextBox usernameValue;
        
        internal System.Windows.Controls.TextBlock Password;
        
        internal CS.Windows.Controls.WatermarkPasswordBox passwordValue;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/suiteApp;component/Pages/registrationPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.naslovStranice = ((System.Windows.Controls.TextBlock)(this.FindName("naslovStranice")));
            this.pageContent = ((System.Windows.Controls.StackPanel)(this.FindName("pageContent")));
            this.UserName = ((System.Windows.Controls.TextBlock)(this.FindName("UserName")));
            this.nameValue = ((System.Windows.Controls.TextBox)(this.FindName("nameValue")));
            this.Surname = ((System.Windows.Controls.TextBlock)(this.FindName("Surname")));
            this.surnameValue = ((System.Windows.Controls.TextBox)(this.FindName("surnameValue")));
            this.eMail = ((System.Windows.Controls.TextBlock)(this.FindName("eMail")));
            this.emailValue = ((System.Windows.Controls.TextBox)(this.FindName("emailValue")));
            this.Username = ((System.Windows.Controls.TextBlock)(this.FindName("Username")));
            this.usernameValue = ((System.Windows.Controls.TextBox)(this.FindName("usernameValue")));
            this.Password = ((System.Windows.Controls.TextBlock)(this.FindName("Password")));
            this.passwordValue = ((CS.Windows.Controls.WatermarkPasswordBox)(this.FindName("passwordValue")));
        }
    }
}

