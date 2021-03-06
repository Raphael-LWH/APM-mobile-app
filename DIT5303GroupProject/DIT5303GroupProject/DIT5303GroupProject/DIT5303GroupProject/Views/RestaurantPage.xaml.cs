using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT5303GroupProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantPage : ContentPage
    {
        public RestaurantPage()
        {
            InitializeComponent();
        }
        private async void TapGestureRecognizer_tapped(object sender, EventArgs e)
        {
            var p = ((TappedEventArgs)e).Parameter;
            await Navigation.PushAsync(new RestaurantInfor(p.ToString()));
        }
    }
}