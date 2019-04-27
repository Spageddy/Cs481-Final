using System;
using System.Collections.Generic;
using System.Net.Http;
using Xamarin.Forms;
using Final1.Models;
using Newtonsoft.Json;

namespace Final1
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();

            GetWeather();
        }

        async void GetWeather()
        {
            var client = new HttpClient();
            var ApiUrl = "https://api.darksky.net/forecast/5db9e955b4cd33978f73d58a5169782f/"
            + MainPage.latitude + "," + MainPage.longitude;
            var uri = new Uri(ApiUrl);

            Weather weather = new Weather();
            var response = await client.GetAsync(uri);
            var jsonContent = await response.Content.ReadAsStringAsync();
            weather = JsonConvert.DeserializeObject<Weather>(jsonContent);
            for (int i = 0; i < weather.Daily.Data.Count; i++)
            {
                double timestamp = weather.Daily.Data[i].Time;
                System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                dateTime = dateTime.AddSeconds(timestamp);
                weather.Daily.Data[i].Day = dateTime;
                weather.Daily.Data[i].Icon = weather.Daily.Data[i].Icon + ".json";
                //weather.Daily.Data[i].Day = new DateTime(weather.Daily.Data[i].Time);
            }
    
            WeeklyWeatherListview.ItemsSource = weather.Daily.Data;
            SetCurrent(weather);
        }

        private void SetCurrent(Weather weather)
        {
            currentanimationView.Animation = weather.Currently.Icon + ".json";
            Condtion.Text = weather.Currently.Summary.ToString();
            Temperature.Text = weather.Currently.Temperature.ToString() + "°";
            humidty.Text = (weather.Currently.Humidity * 100).ToString() + "%";
            Wind.Text = weather.Currently.WindSpeed.ToString() + "m/s";
            UV.Text = weather.Currently.UvIndex.ToString();
            Pressure.Text = weather.Currently.Pressure.ToString() + " hPa";

        }
    }
}
