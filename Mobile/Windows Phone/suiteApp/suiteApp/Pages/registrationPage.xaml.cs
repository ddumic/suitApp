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
using System.Net.Http;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace suiteApp
{
    public partial class registrationPage : PhoneApplicationPage
    {
        public registrationPage()
        {
            InitializeComponent();
            loginJSON a = loginJSON.Instance;
            if (a.Name == null)
            {
                naslovStranice.Text = "Sign up";
            }
            else
            {
                dohvatiPodatke();
            }
            BuildLocalizedApplicationBar();
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton saveButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Save.png", UriKind.Relative));
            saveButton.Text = "save";
            saveButton.Click += saveButton_Click;
            ApplicationBar.Buttons.Add(saveButton);
            ApplicationBarIconButton cancelButton = new ApplicationBarIconButton(new Uri("/Assets/Icons/Delete.png", UriKind.Relative));
            cancelButton.Text = "cancel";
            cancelButton.Click += cancelButton_Click;
            ApplicationBar.Buttons.Add(cancelButton);
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        }
        private void saveButton_Click(object o, EventArgs e)
        {
            loginJSON a = loginJSON.Instance;
            if (a.Name == null)
            {
                ///forma za registraciju
                bool correct = true;
                foreach (var item in pageContent.Children)
                {
                    if (item is TextBox)
                    {
                        TextBox other = (TextBox)item;
                        if (other.Text == "")
                            correct = false;
                    }
                }
                if (correct)
                {
                    ///registracija
                }
                else
                {
                    vibration.mobileVibration();
                    MessageBox.Show("Missing arguments");
                }
            }
            else
            {
                ///forma za uredivanje podataka
            }
        }
        private void cancelButton_Click(object o, EventArgs e)
        {
            loginJSON a = loginJSON.Instance;
            if (a.Name == null)
            {
                NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            }
            else
            {
                NavigationService.Navigate(new Uri("/Pages/startPage.xaml", UriKind.Relative));
            }
        }
        private async void dohvatiPodatke()
        {
            naslovStranice.Text = "Personal data";
            loginJSON a = loginJSON.Instance;
            userDataJSON userData = new userDataJSON();
            HttpClient client = new HttpClient();
            ///POST
            if (checkInternet.checkInternetConnection())
            {
                var values = new List<KeyValuePair<string, string>>();
                values.Add(new KeyValuePair<string, string>("username", a.Username));

                var content = new FormUrlEncodedContent(values);
                var response = await client.PostAsync("http://arka.foi.hr/~ddumic/air2.php", content);
                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    ///primanje
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(userDataJSON));
                    userDataJSON odgovor = JsonConvert.DeserializeObject<userDataJSON>(response.Content.ReadAsStringAsync().Result);
                    nameValue.Text = odgovor.ime;
                    surnameValue.Text = odgovor.prezime;
                    usernameValue.Text = odgovor.korIme;
                    passwordValue.Password = odgovor.lozinka;
                    emailValue.Text = odgovor.mail;
                }
            }
            else
            {
                MessageBox.Show("Internet error");
            }
        }

    }
}