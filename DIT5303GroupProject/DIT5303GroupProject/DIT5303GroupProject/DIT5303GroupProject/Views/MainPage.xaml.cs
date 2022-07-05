using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT5303GroupProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class MainPage : ContentPage
    {
        public class Image
        {

            public ImageSource MainImage { get; set; }

        }
        private ObservableCollection<Image> image;
        public ObservableCollection<Image> CImage
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            CImage = new ObservableCollection<Image>

            {
                new Image{MainImage = "image1.jpg"},
                new Image{MainImage = "image2.jpg"},
                new Image{MainImage = "image3.jpg"},
                new Image{MainImage = "image4.jpg"},
                new Image{MainImage = "image5.jpg"},
            };
            Carousel.ItemsSource = CImage;

            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {

                Carousel.Position = (Carousel.Position + 1) % CImage.Count;
                return true;
            }));
        }

        private async void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            var p = ((TappedEventArgs)e).Parameter;
            await Navigation.PushAsync(new NewsPage2(p.ToString()));
        }

        private async void TapGestureRecognizer_tapped(object sender, EventArgs e)
        {
            var p = ((TappedEventArgs)e).Parameter;
            await Navigation.PushAsync(new ShopInforPage(p.ToString()));
        }

    }
}