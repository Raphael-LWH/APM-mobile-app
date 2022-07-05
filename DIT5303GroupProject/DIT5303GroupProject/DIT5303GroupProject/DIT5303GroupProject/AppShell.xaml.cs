using DIT5303GroupProject.Views;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace DIT5303GroupProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public ICommand TakePhotoCommand => new Command(GoToCamera);

        public AppShell()
        {
            InitializeComponent();
          
            var isLoogged = Xamarin.Essentials.SecureStorage.GetAsync("isLogged").Result;
            if (isLoogged == "1")
            {
                LoginClick.IsVisible = false;
                LoginTitle.IsVisible = false;
            }
            else
            {
                LoginClick.IsVisible = true;
                LoginTitle.IsVisible = true;
            }
        }

        void GoToCamera()
        {
            Shell.Current.GoToAsync("//photo?payload=2.x", true);
            Shell.Current.FlyoutIsPresented = false;
        }
    }
}
