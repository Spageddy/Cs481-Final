using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Final1
{
    public partial class SecondPage : TabbedPage
    {
        public SecondPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            Children.Add(new WeatherPage() { Title = "Weather" });
            Children.Add(new YelpPage() { Title = "Food" });
            Children.Add(new OtherEventPage() { Title = "Events" });
            Children.Add(new SettingPage() { Title = "Location" });

        }
    }
}
