using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Final1
{
    public partial class YelpPage : ContentPage
    {
        public YelpPage()
        {
            InitializeComponent();
            SearchYelp();

        }

        async void SearchYelp()
        {
            string apiKey = "nkM6iyU8QrPv-_ExXt7_bDRVT8yxSEmvPXBMs7d9zO8f8ZrFmervQr9dI3jBVTLBQrnfG9x6yiCsL40ebj9D7Slr7KnothJLWPCvUDO4m_P_ZZQZ7i-errcNguyyXHYx";
            var client = new Yelp.Api.Client(apiKey);
            var results = await client.SearchBusinessesAllAsync("food", MainPage.latitude, MainPage.longitude);
            YelpList.ItemsSource = results.Businesses;
        }

        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
           

            var selected =(Yelp.Api.Models.BusinessResponse)e.Item;
            string fixedurl = selected.Url.ToString();
            await Navigation.PushAsync(new WebPage(fixedurl), true);

        }
    }
}
