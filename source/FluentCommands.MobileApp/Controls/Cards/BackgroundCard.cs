using Xamarin.Forms;

namespace FluentCommands.MobileApp.Controls.Cards
{
    /// <summary>
    /// Background card.
    /// </summary>
    public class BackgroundCard : Frame
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public BackgroundCard()
        {
            Padding = 0;
            CornerRadius = 50;
            BackgroundColor = Color.FromHex("#E0E0E0");
            HasShadow = false;
        }
    }
}
