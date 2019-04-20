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
            Children.Add(new WeatherPage() { Title = "weather" });

        }
    }
}
