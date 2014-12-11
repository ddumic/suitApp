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
    public partial class searchModule : PhoneApplicationPage
    {
        public List<item> Grids = new List<item>();
        public searchModule()
        {
            InitializeComponent();
            dohvatiSadrzaj();
            BuildLocalizedApplicationBar();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton buyButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Store.png", UriKind.Relative));
            buyButton.Text = "buy";
            buyButton.Click += buy_Click;
            ApplicationBar.Buttons.Add(buyButton);
            ApplicationBarIconButton modelButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Customer.png", UriKind.Relative));
            modelButton.Text = "model";
            modelButton.Click += model_Click;
            ApplicationBar.Buttons.Add(modelButton);
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        }
        private void model_Click(object o, EventArgs e)
        {
            ///prikazi model
        }
        private void buy_Click(object sender, EventArgs e)
        {
            //dodaj u kosaricu
            int brojac = 0;
            foreach (var element in Grids)
            {
                if (element.oznaka.IsChecked == true)
                {
                    //MessageBox.Show(element.Naziv.Text);
                    basketView nova = new basketView();
                    nova.Naziv.Text = element.Naziv.Text;
                    nova.Price.Text = "12,99";
                    nova.ShortDesc.Text = element.ShortDesc.Text;
                    basket.kosarica.Add(nova);
                    basket.izracunato = (float.Parse(basket.izracunato) + float.Parse(nova.Price.Text)).ToString();
                    element.oznaka.IsChecked = false;
                    brojac++;
                }
            }
            if (brojac == 1)
            {
                MessageBox.Show("Item added to your basket!");
            }
            if (brojac > 1)
            {
                MessageBox.Show("Items added to your basket!");
            }
        }
        private void pretrazi(object sender, EventArgs e)
        {
            // MessageBox.Show("test");
            foreach (var element in Grids)
            {
                //MessageBox.Show(element.Naziv.Text);
                if (element.Naziv.Text.Contains(search.Text))
                {
                    element.Visibility = System.Windows.Visibility.Visible;
                }
                else
                {
                    element.Visibility = System.Windows.Visibility.Collapsed;
                }
            }
        }
        private void dohvatiSadrzaj()
        {
            loginJSON a = loginJSON.Instance;
            if (a.Username == null)
            {
                MessageBox.Show("Login first!");
                Application.Current.Terminate();
            }
            for (int i = 0; i < 3; i++)
            {
                item it = new item();
                Grids.Add(it);
                it.Naziv.Text = i.ToString();
            }
            foreach (item it in Grids)
            {
                stackPanel.Children.Add(it);
            }
        }
    }
}