using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace suiteApp
{
    public partial class item : UserControl
    {
        public item()
        {
            InitializeComponent();
        }
        private void dohvatiInformacije(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MessageBox.Show(ShortDesc.Text + Naziv.Text);
        }
    }
}
