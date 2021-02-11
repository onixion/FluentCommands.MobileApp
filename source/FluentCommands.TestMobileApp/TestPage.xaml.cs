using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluentCommands.TestMobileApp
{
    /// <summary>
    /// Test page.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public TestPage()
        {
            InitializeComponent();
            BindingContext = new TestViewModel();
        }
    }
}