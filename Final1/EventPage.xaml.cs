using System;
using System.Collections.Generic;
using System.Net.Http;
using Final1.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Final1
{
    public partial class EventPage : ContentPage
    {
        public EventPage()
        {
            InitializeComponent();
        }
        async void GetEvents(object sender, System.EventArgs e)
        {
            var client = new HttpClient();
            var ApiUrl = "https://app.ticketmaster.com/discovery/v2/events.json?apikey=PJeGbONJHPxGuVvtDd3LfzXUxdFCOfBn\n&source=ticketmaster&latlong="
            + MainPage.latitude + "," + MainPage.longitude;
            var uri = new Uri(ApiUrl);

            TicketMaster ticketmasterevents = new TicketMaster();
            var response = await client.GetAsync(uri);
            var jsonContent = await response.Content.ReadAsStringAsync();
            ticketmasterevents = JsonConvert.DeserializeObject<TicketMaster>(jsonContent);
            var tme = ticketmasterevents.Embedded;
            TicketMasterList.ItemsSource = ticketmasterevents.Embedded.Events;
        }

        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            var selected = (Event)e.Item;
            string fixedurl = selected.Url.OriginalString;
            fixedurl.Replace("www.ticketmaster.com", "www1.ticketmaster.com");
            var fix = fixedurl.ToString();
            fix.Replace("www", "www1");
            await Navigation.PushAsync(new WebPage(fixedurl), true);

        }
    }
}
