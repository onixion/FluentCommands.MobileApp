using Xamarin.Forms;

namespace FluentCommands.MobileApp.Controls.Texts
{
    /// <summary>
    /// Headline.
    /// </summary>
    public class Headline : Label
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Headline()
        {
            FontFamily = (OnPlatform<string>)Application.Current.Resources["Ubuntu-Regular"];
            FontSize = 16;
            TextColor = Color.Black;
        }
    }
}
