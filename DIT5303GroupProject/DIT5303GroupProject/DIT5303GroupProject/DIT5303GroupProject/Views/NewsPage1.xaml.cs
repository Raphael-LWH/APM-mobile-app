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
    public partial class NewsPage1 : ContentPage
    {
        public NewsPage1()
        {
            InitializeComponent();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var p = ((TappedEventArgs)e).Parameter;
            await Navigation.PushAsync(new NewsPage2(p.ToString()));
        }
    }
}