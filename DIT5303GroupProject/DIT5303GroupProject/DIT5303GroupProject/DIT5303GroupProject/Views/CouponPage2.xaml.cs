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
    public partial class CouponPage2 : ContentPage
    {
        public CouponPage2(String data)
        {
            InitializeComponent();

            if (data == "1")
            {
                Pic.Source = "sasa_icon.jpg";
                Title.Text = "SaSa HK$20 Cash Coupon";
                Time.Text = "Valid until 31/12/2021";
                Detail.Text = "A maximum of 2 vouchers can be used per person per day";
            }

            else if (data == "2")
            {
                Pic.Source = "uniqlo_icon.jpg";
                Title.Text = "Uniqlo HK$30 off";
                Time.Text = "Valid from 05/11/2021 - 09/12/2021";
                Detail.Text = "Minimum HK$300 spending is required\nThis voucher can only be used once.";
            }

            else if (data == "3")
            {
                Pic.Source = "catalog_icon.jpg";
                Title.Text = "Catalog 5% off on regular priced items";
                Time.Text = "Valid from 01/01/2021 - 31/12/2021";
                Detail.Text = "NA";
            }

            else if (data == "4")
            {
                Pic.Source = "shu_uemura_shop.jpg";
                Title.Text = "Shu Uemura Brow Designer service at special price";
                Time.Text = "Valid unit 30/11/2021";
                Detail.Text = "3D brow styling service at special price HK$200 Booking fee is fully redeemable for shu uemura make-up products";
            }

            else if (data == "5")
            {
                Pic.Source = "pizza_hut_icon.jpg";
                Title.Text = "Pizza Hut A complimentary snack upon any spending";
                Time.Text = "Valid unit 31/12/2021";
                Detail.Text = "NA";
            }

            else if (data == "6")
            {
                Pic.Source = "doughnut_icon.jpg";
                Title.Text = "Doughnut 10% off upon spending of HK$500 on regular priced items";
                Time.Text = "Valid from 01/01/2021 - 31/12/2021";
                Detail.Text = "NA";
            }

            else if (data == "7")
            {
                Pic.Source = "chow_tai_fook_icon.jpg";
                Title.Text = "Chow Tai Fook 10% off on selected regular-priced jewellery items";
                Time.Text = "Valid from 01/01/2021 - 31/12/2021";
                Detail.Text = "NA";
            }
        }
    }
}