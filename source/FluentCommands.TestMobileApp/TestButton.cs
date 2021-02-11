using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace FluentCommands.TestMobileApp
{
    /// <summary>
    /// Test button.
    /// </summary>
    public class TestButton : Button
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public TestButton()
        {
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            if (propertyName == nameof(Command))
            {
                if (Command == null)
                {
                    Command.CanExecuteChanged -= OnCanExecutedChanged;
                }
                else
                {
                    Command.CanExecuteChanged -= OnCanExecutedChanged;
                    Command.CanExecuteChanged += OnCanExecutedChanged;
                }
            }
        }

        void OnCanExecutedChanged(object sender, EventArgs e)
        {
            var canExecute = Command?.CanExecute(CommandParameter) ?? false;

            if (canExecute)
            {
                TextColor = Color.White;
                BackgroundColor = Color.Green;
            }
            else
            {
                TextColor = Color.White;
                BackgroundColor = Color.Red;
            }
        }
    }
}
