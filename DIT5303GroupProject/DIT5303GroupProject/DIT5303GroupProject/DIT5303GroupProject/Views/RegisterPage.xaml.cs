using System;
using System.Collections.Generic;
using DIT5303GroupProject.ViewModels;
using Xamarin.Forms;

namespace DIT5303GroupProject.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();

        }


        private async void NavToLogin_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushModalAsync(new Login());
        }
    }
}
