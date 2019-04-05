
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace BridgeScoringHelper.Droid
{
    [Activity(Label = "BridgeScoringHelper", 
        Icon = "@mipmap/icon", Theme = "@style/Launcher", 
        MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            var screenHeight = (int)(Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);
            var screenWidth = (int)(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density);
            App.SizeManager = new SizeManager(screenHeight, screenWidth);

            // Remove splash screen-theme
            SetTheme(Resource.Style.MainTheme);

            LoadApplication(new App());
        }
    }
}