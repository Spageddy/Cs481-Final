﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Essentials;

namespace Final1
{
    public partial class MainPage : ContentPage
    {
        public static double latitude;
        public static double longitude;

        public MainPage()
        {
            InitializeComponent();
            
        }

        async void Location_Entered(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Entered location in location entry box");

            try
            {
                var address = locationEntry.Text;
                var locations = await Geocoding.GetLocationsAsync(address);

                var location = locations?.FirstOrDefault();
                if (location != null)
                {
                    latitude = location.Latitude;
                    longitude = location.Longitude;
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    //await Navigation.PushAsync(new SecondPage(), true);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
            await Navigation.PushAsync(new SecondPage(), true);
        }

        async void GetLocation_Clicked(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("Clicked Get location Button");
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    latitude = location.Latitude;
                    longitude = location.Longitude;
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    //await Navigation.PushAsync(new SecondPage(), true);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Handle not supported on device exception
            }
            catch (FeatureNotEnabledException fneEx)
            {
                // Handle not enabled on device exception
            }
            catch (PermissionException pEx)
            {
                // Handle permission exception
            }
            catch (Exception ex)
            {
                // Unable to get location
            }

            await Navigation.PushAsync(new SecondPage(), true);
        }

    }
}

