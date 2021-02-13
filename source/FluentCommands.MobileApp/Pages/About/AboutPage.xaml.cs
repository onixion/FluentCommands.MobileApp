using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluentCommands.MobileApp.Pages.About
{
    /// <summary>
    /// About page.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : AbstractContentPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public AboutPage()
        {
            InitializeComponent();
            BindingContext = new AboutViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}