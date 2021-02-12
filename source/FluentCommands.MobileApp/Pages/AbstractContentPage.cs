using Xamarin.Forms;

namespace FluentCommands.MobileApp.Pages
{
    /// <summary>
    /// Abstract page.
    /// </summary>
    public abstract class AbstractContentPage : ContentPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AbstractContentPage()
        {
            BackgroundColor = ColorConstants.YellowColor;
        }
    }
}
