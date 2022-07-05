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
    public partial class ShopInforPage : ContentPage
    {
        public ShopInforPage(String data)
        {
            InitializeComponent();

            if (data == "1")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20160929_UWAuz.jpg";
                Title.Text = "Imperial Bird's Nest";
                Detail.Text = "Shop ID: LG-01\n" + "Tel: 3955 1820\n" + "Open Hour: 1000 - 2300";
            }
            if (data == "2")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20161004_TXON2.jpg";
                Title.Text = "YATA Supermarke";
                Detail.Text = "Shop ID: LG-02\n" + "Tel: 3955 1821\n" + "Open Hour: 1000 - 2300";
            }
            if (data == "3")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20191025_Dy6jU.jpg";
                Title.Text = "Twinkle Baker Décor";
                Detail.Text = "Shop ID: LG-03\n" + "Tel: 3955 1821\n" + "Open Hour: 1000 - 2300";
            }
            if (data == "4")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20200325_TZvI3.jpg";
                Title.Text = "LUCULLUS";
                Detail.Text = "Shop ID: LG-04\n" + "Tel: 3955 1809\n" + "Open Hour: 1000 - 2300";
            }
            if (data == "5")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20161007_pjmXj.jpg";
                Title.Text = "Catalog";
                Detail.Text = "Shop ID: LG-05\n" + "Tel: 3955 1815\n" + "Open Hour: 1000 - 2300";
            }
            if (data == "6")
            {
                Pic.Source = "https://www.hkapm.com.hk/cccms/lib/uploads/system/application_20161007_hKfBA.jpg";
                Title.Text = "Chow Tai Fook";
                Detail.Text = "Shop ID: LG-06\n" + "Tel: 3955 1800\n" + "Open Hour: 1000 - 2300";
            }
        }
    }
}