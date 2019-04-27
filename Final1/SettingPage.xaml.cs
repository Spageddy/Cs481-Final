using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Final1
{
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        void Change_Location(object sender, System.EventArgs e)
        {

        }

        void Random(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int randomYNum = random.Next(0, YelpPage.yelpresults.Businesses.Count);
            int randomENum = random.Next(0, OtherEventPage.eventbriteresults.Events.Count);

            var yelprandom = YelpPage.yelpresults.Businesses[randomYNum];
            var eventrandom = OtherEventPage.eventbriteresults.Events[randomENum];

            yImage.Source = yelprandom.ImageUrl;
            yName.Text = yelprandom.Name;
            yDistance.Text = yelprandom.Distance.ToString() + " miles away";
            yCategory.Text = yelprandom.Categories[0].Title + " |";
            ySubcategory.Text = yelprandom.Categories[1].Title + " |";
            yPrice.Text = "Price: " + yelprandom.Price + " |";
            yRating.Text = "Rating: " + yelprandom.Rating.ToString();

            eImage.Source = eventrandom.Logo.Url.OriginalString;
            eName.Text = eventrandom.Name.Text;
            eSummary.Text = eventrandom.Summary;
            eDate.Text = String.Format("{0:ddd MMMM}-{0:dd}-{0:yyyy} @ {0:hh:mm tt}",
                         eventrandom.Start.Utc.DateTime);
        }
    }
}
