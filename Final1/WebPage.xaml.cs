using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Final1
{
    public partial class WebPage : ContentPage
    {
        public WebPage()
        {
            InitializeComponent();
        }
        public WebPage(string url)
        {
            InitializeComponent();
            url.Replace("www.","www1.");
            Browser.Source = "https://www1.ticketmaster.com/metallica-with-the-san-francisco-symphony-san-francisco-california-09-08-2019/event/1C00568CD03F87EE";
        }
    }
}
