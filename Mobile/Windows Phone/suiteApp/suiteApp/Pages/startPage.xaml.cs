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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace suiteApp
{
    public partial class startPage : PhoneApplicationPage
    {
        public startPage()
        {
            InitializeComponent();
            postaviSucelje();
            BuildLocalizedApplicationBar();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton logoutButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Logout.png", UriKind.Relative));
            logoutButton.Text = "logout";
            logoutButton.Click += logoutButton_Click;
            ApplicationBar.Buttons.Add(logoutButton);
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        }
        private void logoutButton_Click(object o, EventArgs e)
        {
            ///obrisi iz baze
            
            loginJSON a = loginJSON.Instance;
            a.Username = null;
            a.Name = null;
            a.Surname = null;
            a.Status = null;
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
        private void postaviSucelje()
        {
            loginJSON a = loginJSON.Instance;
            korisnickoIme.Text = a.Name + " " + a.Surname;
            if (a.Status == "1")
            {
                ///korisnik
                string[] imena = { "Personal data", "Model", "Search", "Basket" };
                string[] slike = { "/Assets/Icons/Data-Settings.png", "/Assets/Icons/User-Modify.png", "/Assets/Icons/Search-Find.png", "/Assets/Icons/Basket.png" };
                List<twoLevelGrids> Grids = new List<twoLevelGrids>();

                for (int i = 0; i < 4; i++)
                {
                    if (i % 2 == 0)
                    {
                        twoLevelGrids grid = new twoLevelGrids();
                        Grids.Add(grid);
                        Uri uri = new Uri(slike[i], UriKind.Relative);
                        ImageSource imgSource = new BitmapImage(uri);
                        grid.Level1Image.Source = imgSource;
                        grid.Level1Name.Text = imena[i];
                    }

                    else
                    {
                        twoLevelGrids grid = Grids.Last();
                        Uri uri = new Uri(slike[i], UriKind.Relative);
                        ImageSource imgSource = new BitmapImage(uri);
                        grid.Level2Image.Source = imgSource;
                        grid.Level2Name.Text = imena[i];

                    }
                }
                foreach (twoLevelGrids grid in Grids)
                {
                    stackPanel.Children.Add(grid);
                }
            }
            if (a.Status == "2")
            {
                ///ducan
            }
            if (a.Status == "3")
            {
                ///administrator
                string[] imena = { "Personal data", "Users" };
                string[] slike = { "/Assets/Icon/Data-Settings.png", "/Assets/Icon/User-Modify.png" };
                List<twoLevelGrids> Grids = new List<twoLevelGrids>();

                for (int i = 0; i < 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        twoLevelGrids grid = new twoLevelGrids();
                        Grids.Add(grid);
                        Uri uri = new Uri(slike[i], UriKind.Relative);
                        ImageSource imgSource = new BitmapImage(uri);
                        grid.Level1Image.Source = imgSource;
                        grid.Level1Name.Text = imena[i];
                    }

                    else
                    {
                        twoLevelGrids grid = Grids.Last();
                        Uri uri = new Uri(slike[i], UriKind.Relative);
                        ImageSource imgSource = new BitmapImage(uri);
                        grid.Level2Image.Source = imgSource;
                        grid.Level2Name.Text = imena[i];
                    }
                }
            }

        }
    }
}