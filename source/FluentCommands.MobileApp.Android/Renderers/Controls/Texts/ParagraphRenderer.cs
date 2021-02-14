using Android.Content;
using FluentCommands.MobileApp.Controls.Texts;
using FluentCommands.MobileApp.Droid.Renderers.Controls.Texts;
using System.ComponentModel;
using Xamarin.Forms;

[assembly: ExportRenderer(typeof(Paragraph), typeof(ParagraphRenderer))]
namespace FluentCommands.MobileApp.Droid.Renderers.Controls.Texts
{
    /// <summary>
    /// Custom renderer for <see cref="Paragraph"/>.
    /// </summary>
    public class ParagraphRenderer : Xamarin.Forms.Platform.Android.FastRenderers.LabelRenderer
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="context">Context</param>
        public ParagraphRenderer(Context context) : base(context)
        {
        }

        /// <summary>
        /// On element property changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (Element is Paragraph paragraph)
            {
                if (paragraph.IsTextJustified)
                {
                    if (Android.OS.Build.VERSION.SdkInt >= Android.OS.BuildVersionCodes.O)
                    {
                        Control.JustificationMode = Android.Text.JustificationMode.InterWord;
                    }
                }
            }
        }
    }
}