using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIT5303GroupProject.Models;
using Firebase.Database;
using Firebase.Database.Query;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DIT5303GroupProject.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestaurantInfor : ContentPage
    {
        public ObservableCollection<Product> Product
        { get; set; } = new ObservableCollection<Product>();
        public RestaurantInfor(String data)
        {
            
            InitializeComponent();

            if (data == "1")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20181109_oJKvo.jpg";
                Title.Text = "Pizza Hut";
                Detail.Text = "Shop ID: L2-01\n" + "Tel: 2592 9368\n" + "Open Hour: 1100 - 2300";
            }
            if (data == "2")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20210204_xgO6y.jpeg";
                Title.Text = "HATTRNDO";
                Detail.Text = "Shop ID: L2 - 08\n" + "Tel: --N / A--\n" + "Open Hour: 1000 - 2300";
            }
            if (data == "3")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20160929_1XlnF.JPG";
                Title.Text = "Pizza Hut";
                Detail.Text = "Shop ID: L5-01\n" + "Tel: 3542 5788\n" + "Open Hour: 1100 - 2300";
            }
            if (data == "4")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20170929_k284l.JPG";
                Title.Text = "Kanzan Menya";
                Detail.Text = "Shop ID: L2-1b\n" + "Tel: 6333 8050\n" + "Open Hour: 1100 - 2300";
            }
            if (data == "5")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20211021_0YBYE.jpg";
                Title.Text = "Meet Fresh";
                Detail.Text = "Shop ID: C-41\n" + "Tel: 2881 8891\n" + "Open Hour: 1200 - 2200";
            }
            if (data == "6")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20190611_8fQvT.JPG";
                Title.Text = "Tsukada Nojo";
                Detail.Text = "Shop ID: L3-13\n" + "Tel: 3596 3909\n" + "Open Hour: 1100 - 2300";
            }
        }

       async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            if (Number.Text != "")
            {
                FirebaseClient client = new FirebaseClient("https://herny-769a8-default-rtdb.firebaseio.com/");
                var date = DateTime.Now;
                string date_str = date.ToString("dd/MM/yyyy HH:mm:ss");

        await client.Child("Product").PostAsync(new Product() { Number = Number.Text,Tel=Tel.Text ,Date = date_str ,Name=Title.Text});
              
                await Application.Current.MainPage.DisplayAlert(
                   "Susses",
                   "Booked at "+date,
                   "Ok");
                Number.Text = "";
                Tel.Text = "";
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert(
                     "ERROR",
                     "You Must Enter All Value",
                     "Ok");


            }
        }
    }
}