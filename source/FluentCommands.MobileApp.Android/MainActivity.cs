using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Xamarin.Forms.Platform.Android;

namespace FluentCommands.MobileApp.Droid
{
    /// <summary>
    /// Main activity.
    /// </summary>
    [Activity(Label = "FluentCommands", Icon = "@drawable/Icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : FormsAppCompatActivity
    {
        /// <summary>
        /// On create.
        /// </summary>
        /// <param name="savedInstanceState"></param>
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            Xamarin.Forms.Forms.Init(this, savedInstanceState);

            Window.SetStatusBarColor(ColorConstants.YellowColor.ToAndroid());
            Window.SetTitleColor(Xamarin.Forms.Color.Black.ToAndroid());
            Window.SetNavigationBarColor(ColorConstants.YellowColor.ToAndroid());

            LoadApplication(new App());
        }

        /// <summary>
        /// On request permissions result.
        /// </summary>
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}