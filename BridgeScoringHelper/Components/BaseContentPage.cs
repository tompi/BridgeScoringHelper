using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace BridgeScoringHelper.Components
{
    public class BaseContentPage : ContentPage
    {
        public BaseContentPage()
        {
            // Make sure we dont get covered by notch
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Logger.Info($"Navigated to page {this.GetType().Name}");
        }
    }
}
