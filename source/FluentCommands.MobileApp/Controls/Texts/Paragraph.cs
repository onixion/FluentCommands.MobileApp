using Xamarin.Forms;

namespace FluentCommands.MobileApp.Controls.Texts
{
    /// <summary>
    /// Paragram.
    /// </summary>
    public class Paragraph : Label
    {
        #region IsTextJustifiedProperty

        public readonly static BindableProperty IsTextJustifiedProperty = BindableProperty.Create(
           nameof(IsTextJustified),
           typeof(bool),
           typeof(Paragraph),
           true);

        public bool IsTextJustified
        {
            get => (bool)GetValue(IsTextJustifiedProperty);
            set => SetValue(IsTextJustifiedProperty, value);
        }

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public Paragraph()
        {
            FontFamily = (OnPlatform<string>)Application.Current.Resources["Ubuntu-Light"];
            FontSize = 14;
            TextColor = Color.Black;
            CharacterSpacing = 0.25;
        }
    }
}
