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
    public partial class twoLevelGrids : UserControl
    {
        public twoLevelGrids()
        {
            InitializeComponent();
        }

        private void LevelGrid1_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ///korisnik
            if (Level1Name.Text == "Personal data")
            {
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Pages/registrationPage.xaml", UriKind.RelativeOrAbsolute));
            }
            if (Level1Name.Text == "Search")
            {
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Pages/searchModule.xaml", UriKind.RelativeOrAbsolute));
            }
            ///ducan

            ///administrator
            if (Level1Name.Text == "Personal data")
            {
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Pages/registrationPage.xaml", UriKind.RelativeOrAbsolute));
            }
        }

        private void LevelGrid2_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ///korisnik
            if (Level2Name.Text == "Model")
            {

            }
            if (Level2Name.Text == "Basket")
            {
                (Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/Pages/basket.xaml", UriKind.RelativeOrAbsolute));
            }
            ///ducan

            ///administrator
            if (Level1Name.Text == "Users")
            {

            }
        }
    }
}
