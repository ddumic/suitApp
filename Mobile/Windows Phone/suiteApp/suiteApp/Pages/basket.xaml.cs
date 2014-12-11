using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using suiteApp.Resources;

namespace suiteApp
{
    public partial class basket : PhoneApplicationPage
    {
        public static List<basketView> kosarica = new List<basketView>();
        public static string izracunato = "0";
        public basket()
        {
            InitializeComponent();
            BuildLocalizedApplicationBar();
            dohvatiArtikle();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton buyButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Store.png", UriKind.Relative));
            buyButton.Text = "buy";
            buyButton.Click += buyButton_Click;
            ApplicationBar.Buttons.Add(buyButton);

            ApplicationBarIconButton discardButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Garbage.png", UriKind.Relative));
            discardButton.Text = "discard";
            discardButton.Click += discardButton_Click;
            ApplicationBar.Buttons.Add(discardButton);

            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        }
        private static void buyButton_Click(object o, EventArgs e)
        {
            //nije implementirano
        }
        private void discardButton_Click(object o, EventArgs e)
        {
            MessageBoxResult m = MessageBox.Show("Are you shure you want to delete all items?", "Warning", MessageBoxButton.OKCancel);
            if (m == MessageBoxResult.Cancel)
            {
                //MessageBox.Show("cancelled!");
            }
            else
            {
                //MessageBox.Show("not cancelled!");
                izracunato = "0";
                ocistiArtikle();
                kosarica.Clear();
            }

        }
        private void ocistiArtikle()
        {
            stackPanel.Children.Clear();

        }
        private void dohvatiArtikle()
        {
            sum zbroj = new sum();
            if (kosarica.Count > 0)
            {
                zbroj.kuna.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                zbroj.kuna.Visibility = System.Windows.Visibility.Collapsed;
            }
            foreach (basketView proizvod in kosarica)
            {
                stackPanel.Children.Add(proizvod);
            }
            zbroj.kuna.Text = "Total: " + izracunato + "kn";
            stackPanel.Children.Add(zbroj);
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            ocistiArtikle();
        }
    }
}