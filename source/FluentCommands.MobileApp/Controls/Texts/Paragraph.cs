using Xamarin.Forms;

namespace FluentCommands.MobileApp.Controls.Texts
{
    /// <summary>
    /// Paragram.
    /// </summary>
    public class Paragraph : Label
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Paragraph()
        {
            FontFamily = (OnPlatform<string>)Application.Current.Resources["Ubuntu-Light"];
            FontSize = 14;
            TextColor = Color.Black;
        }
    }
}
