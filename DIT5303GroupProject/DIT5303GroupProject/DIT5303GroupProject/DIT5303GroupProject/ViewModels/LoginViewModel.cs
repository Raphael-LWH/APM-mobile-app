using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DIT5303GroupProject.Models;
using DIT5303GroupProject.Views;
using Firebase.Auth;
using Firebase.Database;
using Firebase.Database.Query;
using GalaSoft.MvvmLight.Command;
using Newtonsoft.Json;
using Xamarin.Essentials;
using Xamarin.Forms;
using DIT5303GroupProject.Models;

namespace DIT5303GroupProject.ViewModels
{

     public class LoginViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Product
        { get; set; } = new ObservableCollection<Product>();
        public string LOGGINGED;
        public string email;
        public string password;
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }


        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(LoginMethod);
            }

        }

        public async void LoginMethod()
        {
            if (string.IsNullOrEmpty(this.email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email.",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter a password.",
                    "Accept");
                return;
            }

            string WebAPIkey = "AIzaSyDdfRaWciuvsn83afnPIHsQfM55kTGbxUI";


            var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));

            {
                try
                {
                    var auth = await authProvider.SignInWithEmailAndPasswordAsync(EmailTxt.ToString(), PasswordTxt.ToString());
                    var content = await auth.GetFreshAuthAsync();
                    var serializedcontnet = JsonConvert.SerializeObject(content);

                    Preferences.Set("MyFirebaseRefreshToken", serializedcontnet);
                    await App.Current.MainPage.DisplayAlert("Success", "Welcome back", "OK");


                    Application.Current.MainPage = new AppShell();
                    await Shell.Current.GoToAsync("//Main Page");
                   
                    Loginned.login = "yes";


                }
                catch (Exception ex)
                {
                    await App.Current.MainPage.DisplayAlert("Alert", "Invalid useremail or password"+ ex.Message, "OK");
                }
            }

            


        }

       
        }



    }


