using Xamarin.Forms;

namespace FluentCommands.MobileApp.Layouts
{
    /// <summary>
    /// Scroll content.
    /// </summary>
    public class ScrollContent : ScrollView
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ScrollContent()
        {
            HorizontalScrollBarVisibility = ScrollBarVisibility.Never;
            VerticalScrollBarVisibility = ScrollBarVisibility.Never;
        }
    }
}
