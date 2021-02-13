using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;

namespace FluentCommands.MobileApp.Pages.About
{
    /// <summary>
    /// About view model.
    /// </summary>
    public class AboutViewModel : AbstractViewModel
    {
        /// <summary>
        /// Open repository command.
        /// </summary>
        public ICommand OpenRepositoryCommand { get; private set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public AboutViewModel()
        {
            FluentCommandManager
                .New()
                .LockAll(eg =>
                {
                    OpenRepositoryCommand = eg.Register(FluentCommand
                        .New()
                        .OnExecuteAsync(_ => Launcher.OpenAsync("https://github.com/onixion/FluentCommands")));
                });

            // Example 1
            FluentCommandManager
                .New()
                .LockAll(eg =>
                {
                    E1C0Command = eg.Register(FluentCommand.New().OnExecuteAsync(E1C0Async));
                })
                .LockOthers(eg =>
                {
                    E1C1Command = eg.Register(FluentCommand.New().OnExecuteAsync(E1C1Async));
                })
                .LockThis(eg =>
                {
                    E1C2Command = eg.Register(FluentCommand.New().OnExecuteAsync(E1C2Async));
                })
                .LockNothing(eg =>
                {
                    E1C3Command = eg.Register(FluentCommand.New().OnExecuteAsync(E1C3Async));
                });

            // Example 2
            FluentCommandManager
                .New()
                .LockAll(eg =>
                {
                    E2C0Command = eg.Register(FluentCommand.New().OnExecuteAsync(E2C0Async));
                    E2C1Command = eg.Register(FluentCommand.New().OnExecuteAsync(E2C1Async));
                })
                .LockOthers(eg =>
                {
                    E2C2Command = eg.Register(FluentCommand.New().OnExecuteAsync(E2C2Async));
                });
        }

        #region Example 1

        public ICommand E1C0Command { get; private set; }
        public ICommand E1C1Command { get; private set; }
        public ICommand E1C2Command { get; private set; }
        public ICommand E1C3Command { get; private set; }

        public string E1C0Text
        {
            get => e1c0Text;
            set => SetProperty(ref e1c0Text, value);
        }
        string e1c0Text;

        public string E1C1Text
        {
            get => e1c1Text;
            set => SetProperty(ref e1c1Text, value);
        }
        string e1c1Text;

        public string E1C2Text
        {
            get => e1c2Text;
            set => SetProperty(ref e1c2Text, value);
        }
        string e1c2Text;

        public string E1C3Text
        {
            get => e1c3Text;
            set => SetProperty(ref e1c3Text, value);
        }
        string e1c3Text;

        public string E1NotificationText
        {
            get => e1NotificationText;
            set => SetProperty(ref e1NotificationText, value);
        }
        string e1NotificationText;

        int e1c0Counter = 0;
        int e1c1Counter = 0;
        int e1c2Counter = 0;
        int e1c3Counter = 0;

        async Task E1C0Async(object parameter = null)
        {
            E1NotificationText = $"Button 1 pressed ...";

            e1c0Counter++;
            E1C0Text = $"{e1c0Counter}";

            await Task.Delay(2000);
            E1NotificationText = $"Button 1 finished.";
        }

        async Task E1C1Async(object parameter = null)
        {
            E1NotificationText = $"Button 2 pressed ...";

            e1c1Counter++;
            E1C1Text = $"{e1c1Counter}";

            await Task.Delay(2000);
            E1NotificationText = $"Button 2 finished.";

        }

        async Task E1C2Async(object parameter = null)
        {
            E1NotificationText = $"Button 3 pressed ...";

            e1c2Counter++;
            E1C2Text = $"{e1c2Counter}";

            await Task.Delay(2000);
            E1NotificationText = $"Button 3 finished.";
        }

        async Task E1C3Async(object parameter = null)
        {
            E1NotificationText = $"Button 4 pressed ...";

            e1c3Counter++;
            E1C3Text = $"{e1c3Counter}";

            await Task.Delay(2000);
            E1NotificationText = $"Button 4 finished.";
        }

        #endregion

        #region Example 2


        public ICommand E2C0Command { get; private set; }
        public ICommand E2C1Command { get; private set; }
        public ICommand E2C2Command { get; private set; }

        public string E2NotificationText
        {
            get => e2NotificationText;
            set => SetProperty(ref e2NotificationText, value);
        }
        string e2NotificationText;

        async Task E2C0Async(object parameter = null)
        {
            E2NotificationText = $"Loading data ...";
            await Task.Delay(2000);
            E2NotificationText = $"Loaded data.";
        }

        async Task E2C1Async(object parameter = null)
        {
            E2NotificationText = $"Saving data ...";
            await Task.Delay(2000);
            E2NotificationText = $"Saved data.";
        }

        async Task E2C2Async(object parameter = null)
        {
            E2NotificationText = $"Searching ...";
            await Task.Delay(500);
            E2NotificationText = $"Searched.";
        }

        #endregion
    }
}
