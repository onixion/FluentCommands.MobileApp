using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Xamarin.Forms.Platform.Android;

namespace FluentCommands.MobileApp.Droid
{
    /// <summary>
    /// Splash activity.
    /// </summary>
    [Activity(
        Label = "FluentCommands", 
        Icon = "@drawable/Icon", 
        Theme = "@style/SplashTheme", 
        MainLauncher = true, 
        ScreenOrientation = ScreenOrientation.Portrait,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class SplashActivity : FormsAppCompatActivity
    {
        /// <summary>
        /// On start.
        /// </summary>
        protected override void OnStart()
        {
            base.OnStart();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}