
using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FluentCommands.MobileApp.Controls.Buttons
{
    /// <summary>
    /// Indicator button.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IndicatorButton : ContentView
    {
        #region CommandProperty

        public readonly static BindableProperty CommandProperty = BindableProperty.Create(
            nameof(Command),
            typeof(ICommand),
            typeof(IndicatorButton),
            propertyChanged: OnCommandPropertyChanged);

        private static void OnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (IndicatorButton)bindable;

            control.Button.Command = control.Command;

            if (control.Command == null)
            {
                control.Command.CanExecuteChanged -= control.OnCanExecutedChanged;
            }
            else
            {
                control.Command.CanExecuteChanged -= control.OnCanExecutedChanged;
                control.Command.CanExecuteChanged += control.OnCanExecutedChanged;

                control.OnCanExecutedChanged(null, null);
            }
        }

        private void OnCanExecutedChanged(object sender, EventArgs e)
        {
            var canExecute = Command?.CanExecute(null) ?? false;

            if (canExecute)
            {
                Frame.BackgroundColor = Color.Green;
                Frame.Opacity = 1.0;
            }
            else
            {
                Frame.BackgroundColor = Color.Red;
                Frame.Opacity = 0.5;
            }

            Button.Text = "";
            Button.Text = Text;
        }

        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        #endregion

        #region TextProperty

        public readonly static BindableProperty TextProperty = BindableProperty.Create(
           nameof(Text),
           typeof(string),
           typeof(IndicatorButton),
           propertyChanged: OnTextPropertyChanged);

        private static void OnTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (IndicatorButton)bindable;
            control.Button.Text = control.Text;
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        #endregion

        /// <summary>
        /// Constructor.
        /// </summary>
        public IndicatorButton()
        {
            InitializeComponent();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (Button != null)
            {
                Button.Text = "";
                Button.Text = Text;
            }
        }
    }
}