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
            Browser.Source = url;
        }
    }
}
