using DIT5303GroupProject.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT5303GroupProject
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
