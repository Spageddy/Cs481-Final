using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Final1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
            
            AppCenter.Start("ios=9b93ece5-2665-4107-9868-f79113c5861b;" +
                              "uwp={Your UWP App secret here};" +
                              "android={Your Android App secret here}",
                              typeof(Analytics), typeof(Crashes));
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
