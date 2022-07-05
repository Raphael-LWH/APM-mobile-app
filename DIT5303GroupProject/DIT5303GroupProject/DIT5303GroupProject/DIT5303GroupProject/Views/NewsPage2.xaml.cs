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
    public partial class NewsPage2 : ContentPage
    {
        public NewsPage2(String data)
        {
            InitializeComponent();

            if (data == "1")
            {
                Pic.Source = "application_20190903_TPKv7_02.jpg";
                Title.Text = "5 Hours Free Parking";
                Time.Text = "Date of event: From 01/07/2021 onwards\n" + "Location: UC Redemption Counter";
                Detail.Text = "Customer can enjoy 1 hour free parking as reach the purchase $200 at stores or dinging" +
                    "or enjoy up to 3 hours free parking by reach the purchase $400" +
                    "The Point by SHKP member can redeem 1 hour to 3 hours free parking by bouns points." +
                    "Each customer can only enjoy a maximum of 5 hours free parking per entry.";
            }
            else if (data == "2")
            {
                Pic.Source = "application_20210727_8JOcY_02.jpg";
                Title.Text = "Digital Sportcation Hub";
                Time.Text = "Date of event: 08/11/2021 - 29/12/2021(Mon to Fri)\n"+"Time: 1pm-2pm/3pm-4pm/5pm-6pm\n"+"Location: L7";
                Detail.Text = "The Point by SHKP member can enjoy indoor glamping by earning 1000 points to redeem enter pass.";
            }
            else if (data == "3")
            {
                Pic.Source = "application_20211101_OqvxC.jpg";
                Title.Text = "Beauty Offers";
                Time.Text = "Date of event: 08/11/2021 - 29/12/2021(Mon & Wed)\n" + "Time: 1pm - 11pm" + "Location: UC Redemption Counter";
                Detail.Text = "The Point by SHKP member can redeem cosmetics coupon by spending amount payment.";
            }
            else if (data == "4")
            {
                Pic.Source = "application_20210811_ibl4g.jfif";
                Title.Text = "Dining Rewards with Octopus card";
                Time.Text = "Date of event: From now until 31/12/2021\n" + "Time: 1pm - 11pm\n" + "Location: UC Redemption Counter";
                Detail.Text = "The Point by SHKP member redeem $30 coupon, as reach the purchase $$00 at dinging by Octopus card" + "Daily quota： 60";
            }
            else if (data == "5")
            {
                Pic.Source = "application_20211028_aJmB5.jpg";
                Title.Text = "Winter Rewards";
                Time.Text = "Date of event: 1/11/2021 - 31/12/2021\n" + "Time: 1pm - 11pm\n" + "Location: UC Redemption Counter";
                Detail.Text = "The Point by SHKP member can redeem shopping coupon upon spending designated amount. While stock lasts.(a maximum of 2 payment slips from different shops paid by same Member)" +
                    "Speding $1000 - shopping coupon $200" +
                    "Speding $2000 - shopping coupon $400" +
                    "Speding $3000 - shopping coupon $600";
            }
            else if (data == "6")
            {
                Pic.Source = "application_20211101_CDWsY.jpg";
                Title.Text = "Member Exclusive Offer";
                Time.Text = "Date of event: 30/10/2021 - 31/12/2021\n" + "Time: 1pm - 11pm\n" + "Location: UC Redemption Counter";
                Detail.Text = "Eligible customer can receive the folloing rewards" +
                    "Register as a new The Point by SHKP member - rewards S20 coupon & 500 points" +
                    "Member upon spending S250 -  rewards $50 dining coupon & shopping points.";
            }
        }
    }
}