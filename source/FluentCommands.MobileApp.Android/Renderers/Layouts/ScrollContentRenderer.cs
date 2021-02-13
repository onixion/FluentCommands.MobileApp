using Android.Content;
using FluentCommands.MobileApp.Droid.Renderers.Controls.Layouts;
using FluentCommands.MobileApp.Layouts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ScrollContent), typeof(ScrollContentRenderer))]
namespace FluentCommands.MobileApp.Droid.Renderers.Controls.Layouts
{
    /// <summary>
    /// Custom renderer for <see cref="ScrollConent"/>.
    /// </summary>
    public class ScrollContentRenderer : ScrollViewRenderer
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context">Context</param>
        public ScrollContentRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                if (e.NewElement is ScrollContent)
                {
                    VerticalFadingEdgeEnabled = false;
                    HorizontalFadingEdgeEnabled = false;
                }
            }
        }
    }
}