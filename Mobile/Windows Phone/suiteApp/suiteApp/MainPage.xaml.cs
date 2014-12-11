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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.IO;
using Windows.Phone.Speech.VoiceCommands;
using Windows.ApplicationModel.Activation;

namespace suiteApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            ///provjera da li je korisnik logiran

            InitializeComponent();
            postaviSliku();
            BuildLocalizedApplicationBar();
        }
        private async void checkVoiceDefinition()
        {
            await VoiceCommandService.InstallCommandSetsFromFileAsync(new Uri("ms-appx:///ContosoWidgets.xml"));
        }
        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Terminate();
        }
        private void postaviSliku()
        {
            if (checkTheme.check())
            {
                Uri uri = new Uri("/Assets/Icons/logo2b.png", UriKind.Relative);
                ImageSource imgSource = new BitmapImage(uri);
                icon.Source = imgSource;
            }
            else
            {
                Uri uri = new Uri("/Assets/Icons/logo2c.png", UriKind.Relative);
                ImageSource imgSource = new BitmapImage(uri);
                icon.Source = imgSource;
            }
        }
        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();
            ApplicationBarIconButton loginBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/check-icon.png", UriKind.Relative));
            loginBtn.Text = "login";
            loginBtn.Click += Login;
            ApplicationBar.Buttons.Add(loginBtn);

            ApplicationBarIconButton registerBtn = new ApplicationBarIconButton(new Uri("/Assets/Icons/ID-Add.png", UriKind.Relative));
            registerBtn.Text = "register";
            registerBtn.Click += Register;
            ApplicationBar.Buttons.Add(registerBtn);
        }
        private void Register(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pages/registrationPage.xaml", UriKind.Relative));
        }
        private async void Login(object sender, EventArgs e)
        {
            if (username.Text == "" || password.Password == "")
            {

            }
            else
            {
                if (checkInternet.checkInternetConnection())
                {
                    AES aes = new AES();
                    RSA rsa = new RSA();
                    SetProgress(true);
                    ///dohvati javni kljuc servera
                    HttpClient client = new HttpClient();
                    var key = await client.GetAsync("http://arka.foi.hr/~ddumic/rscPlus.php");
                    LocalizedStrings.publicKey = await key.Content.ReadAsStringAsync();
                    ///kriptiraj username i password
                    string Username = aes.AESkriptiranje(username.Text);
                    string Password = aes.AESkriptiranje(password.Password);
                    ///kriptiraj AES kljuc
                    string AESkey = Convert.ToBase64String(rsa.kriptiranje(LocalizedStrings.AESkey));
                    ///posalji na server
                    var values = new List<KeyValuePair<string, string>>();
                    values.Add(new KeyValuePair<string, string>("username", Username));
                    values.Add(new KeyValuePair<string, string>("password", Password));
                    values.Add(new KeyValuePair<string, string>("key", AESkey));
                    var content = new FormUrlEncodedContent(values);
                    var response = await client.PostAsync("http://arka.foi.hr/~ddumic/mia.php", content);
                    var responseString = await response.Content.ReadAsStringAsync();
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(loginJSON));
                    loginJSON odgovor = JsonConvert.DeserializeObject<loginJSON>(response.Content.ReadAsStringAsync().Result);
                    
                    if (response.IsSuccessStatusCode)
                    {
                        if (odgovor.Username != "")
                        {
                            loginJSON a = loginJSON.Instance;
                            a.Name = odgovor.Name;
                            a.Surname = odgovor.Surname;
                            a.Username = odgovor.Username;
                            a.Status = odgovor.Status;
                            a.Mail = odgovor.Mail;
                            ///zapisi podatke o korisniku i modelu
                            
                            SetProgress(false);
                            ///navigacija na pocetni ekran
                            NavigationService.Navigate(new Uri("/Pages/startPage.xaml", UriKind.Relative));
                        }
                        else
                        {
                            ///pogresni podaci
                            SetProgress(false);
                            vibration.mobileVibration();
                            password.Password = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Service error");
                    }

                }
                else
                {
                    MessageBox.Show("Internet error");
                }
            }


        }
        public void SetProgress(bool value)
        {
            if (SystemTray.ProgressIndicator == null)
            {
                SystemTray.ProgressIndicator = new ProgressIndicator();
                SystemTray.ProgressIndicator.Text = "logging in";
            }

            SystemTray.ProgressIndicator.IsIndeterminate = value;
            SystemTray.ProgressIndicator.IsVisible = value;
        }


        


        


    }
}