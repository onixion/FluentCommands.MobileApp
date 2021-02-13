using Xamarin.Forms;

namespace FluentCommands.MobileApp.Controls.Texts
{
    /// <summary>
    /// Logo.
    /// </summary>
    public class LogoText : Label
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public LogoText()
        {
            FontFamily = (OnPlatform<string>)Application.Current.Resources["Lobster"];
            TextColor = Color.Black;
        }
    }
}
