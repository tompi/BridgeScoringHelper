using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BridgeScoringHelper
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Calculator.Calculator();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            AppCenter.Start("ios=5dfaecc0-1d5c-4fc7-9ebb-474f72a851e5;" +
                              "android=b1ae3f6b-ce7c-4fdc-9741-b053c3b09c3d;",
                              typeof(Analytics), typeof(Crashes));
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
