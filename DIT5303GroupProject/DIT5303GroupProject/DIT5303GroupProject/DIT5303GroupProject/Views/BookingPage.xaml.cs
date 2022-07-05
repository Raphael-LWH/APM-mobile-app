using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DIT5303GroupProject.Models;
using Firebase.Database;
using Xamarin.Forms;

namespace DIT5303GroupProject.Views
{
    public partial class BookingPage : ContentPage
    {
        public ObservableCollection<Product> Product
        { get; set; } = new ObservableCollection<Product>();
        public BookingPage()
        {
            InitializeComponent();
            BindingContext = this;
            var firebaseClient = new FirebaseClient("https://herny-769a8-default-rtdb.firebaseio.com/");

            var collection = firebaseClient.Child("Product").AsObservable<Product>().Subscribe((dbevent) =>
            {
                if (dbevent.Object != null)
                {

                    Product.Add(dbevent.Object);
                }
            });
        }
    }
}
