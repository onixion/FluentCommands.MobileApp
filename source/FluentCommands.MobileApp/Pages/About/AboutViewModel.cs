using System.Threading.Tasks;
using System.Windows.Input;

namespace FluentCommands.MobileApp.Pages.About
{
    /// <summary>
    /// About view model.
    /// </summary>
    public class AboutViewModel : AbstractViewModel
    {
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

        public AboutViewModel()
        {
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
        }

        int e1c0Counter = 1;
        int e1c1Counter = 1;
        int e1c2Counter = 1;
        int e1c3Counter = 1;

        async Task E1C0Async(object parameter = null)
        {
            E1C0Text = $"{e1c0Counter}";
            e1c0Counter++;

            await Task.Delay(500);
        }


        async Task E1C1Async(object parameter = null)
        {
            E1C1Text = $"{e1c1Counter}";
            e1c1Counter++;

            await Task.Delay(500);
        }

        async Task E1C2Async(object parameter = null)
        {
            E1C2Text = $"{e1c2Counter}";
            e1c2Counter++;
            
            await Task.Delay(500);
        }

        async Task E1C3Async(object parameter = null)
        {
            E1C3Text = $"{e1c3Counter}";
            e1c3Counter++;

            await Task.Delay(500);
        }
    }
}
