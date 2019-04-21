using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Final1
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            GetWeather();
        }

        private void GetWeather()
        {
            var client = new HttpClient();
            var ApiUrl = "https://api.darksky.net/forecast/5db9e955b4cd33978f73d58a5169782f/"
            + MainPage.latitude + "," + MainPage.longitude;
            var uri = new Uri(ApiUrl);
        }
    }
}
