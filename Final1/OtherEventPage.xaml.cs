using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using Final1.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Final1
{
    public partial class OtherEventPage : ContentPage
    {
        static public EventBrite eventbriteresults;
        public OtherEventPage()
        {
            InitializeComponent();
            GetEvents();
        }

        void GetEvents()
        {
            var client = new HttpClient();
            var ApiUrl = "https://www.eventbriteapi.com/v3/events/search/?location.latitude="
            + MainPage.latitude + "&location.longitude=" + MainPage.longitude + "&sort_by=date";
            var uri = new Uri(ApiUrl);
            
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer PYLKTZX72QO7KKTSSSFX");
            request.Accept = "application/json";

            EventBrite eventBriteEvents = new EventBrite();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            var jsonContent = readStream.ReadToEnd();

            eventBriteEvents = JsonConvert.DeserializeObject<EventBrite>(jsonContent);
            eventbriteresults = eventBriteEvents;
            EventBriteList.ItemsSource = eventBriteEvents.Events;
        }

        void Handle_Completed(object sender, System.EventArgs e)
        {
            var client = new HttpClient();
            var ApiUrl = "https://www.eventbriteapi.com/v3/events/search/?location.latitude="
            + MainPage.latitude + "&location.longitude=" + MainPage.longitude + "&q=" + search.Text;
            var uri = new Uri(ApiUrl);

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer PYLKTZX72QO7KKTSSSFX");
            request.Accept = "application/json";

            EventBrite eventBriteEvents = new EventBrite();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //var response = await client.GetAsync(uri);
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
            var jsonContent = readStream.ReadToEnd();

            //var jsonContent = await response.Content.ReadAsStringAsync();
            eventBriteEvents = JsonConvert.DeserializeObject<EventBrite>(jsonContent);
            EventBriteList.ItemsSource = eventBriteEvents.Events;
        }

        async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {

            var selected = (Event)e.Item;
            string fixedurl = selected.Url.OriginalString;

            await Navigation.PushAsync(new WebPage(fixedurl), true);
                      
        }
    }
}
