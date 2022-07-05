using System;
using System.Windows.Input;
using DIT5303GroupProject.Views;
using Firebase.Auth;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace DIT5303GroupProject.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public INavigation Navigation { get; set; }

        public string email;
        public string password;
        public string repassword;



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
        public string RePasswordTxt
        {
            get { return this.repassword; }
            set { SetValue(ref this.repassword, value); }
        }



        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
        }

        private async void RegisterMethod()
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

            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebAPIkey));
                var auth = await authProvider.CreateUserWithEmailAndPasswordAsync(EmailTxt.ToString(), PasswordTxt.ToString());
                string gettoken = auth.FirebaseToken;
                await App.Current.MainPage.DisplayAlert("Create Account", "Create Success", "OK");
                Application.Current.MainPage = new AppShell();
                await Shell.Current.GoToAsync("//Main Page");





                await Application.Current.MainPage.DisplayAlert("Successfully", "Welcome ", "Ok");


            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Alert", ex.Message, "OK");
            }


        }





    }
}
