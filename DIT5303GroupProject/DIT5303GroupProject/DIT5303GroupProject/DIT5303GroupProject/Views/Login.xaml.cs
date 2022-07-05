using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIT5303GroupProject.Models;
using DIT5303GroupProject.ViewModels;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT5303GroupProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            BindingContext = new LoginViewModel();

            if (Loginned.login == "no")
            {
                unlogined.IsVisible = true;
                logined.IsVisible = false;
            }
            else
            {
                unlogined.IsVisible = false;
                logined.IsVisible = true;
            }

        }
    
        private async void SignUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterPage());

        }
        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Loginned.login = "no";
            unlogined.IsVisible = true;
            logined.IsVisible = false;
            await Shell.Current.GoToAsync("//Main Page");
        }

      
      
    }
}