using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FluentCommands.TestMobileApp
{
    /// <summary>
    /// Test view model.
    /// </summary>
    public class TestViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Command A.
        /// </summary>
        public ICommand CommandA { get; private set; }

        /// <summary>
        /// Command B.
        /// </summary>
        public ICommand CommandB { get; private set; }

        /// <summary>
        /// Command C.
        /// </summary>
        public ICommand CommandC { get; private set; }

        /// <summary>
        /// Command D.
        /// </summary>
        public ICommand CommandD { get; private set; }

        /// <summary>
        /// Command E.
        /// </summary>
        public ICommand CommandE { get; private set; }

        /// <summary>
        /// Command F.
        /// </summary>
        public ICommand CommandF { get; private set; }

        /// <summary>
        /// Text.
        /// </summary>
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }
        private string text;

        /// <summary>
        /// Constructor.
        /// </summary>
        public TestViewModel()
        {
            FluentCommandManager
                .New()
                .LockAll(eg =>
                {
                    CommandA = eg.RegisterCommand(FluentAsyncCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandA));

                    CommandB = eg.RegisterCommand(FluentAsyncCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandB));
                })
                .LockOthers(eg =>
                {
                    CommandC = eg.RegisterCommand(FluentAsyncCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandC));

                    CommandD = eg.RegisterCommand(FluentAsyncCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandD));
                })
                .LockThis(eg =>
                {
                    CommandE = eg.RegisterCommand(FluentAsyncCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandE));

                    CommandF = eg.RegisterCommand(FluentAsyncCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandF));
                });
        }

        int counterA = 0;
        int counterB = 0;
        int counterC = 0;
        int counterD = 0;
        int counterE = 0;
        int counterF = 0;

        async Task OnAsyncCommandA(object parameter)
        {
            Text = $"A {counterA}";
            counterA++;

            await Task.Delay(5000);
        }

        async Task OnAsyncCommandB(object parameter)
        {
            Text = $"B {counterB}";
            counterB++;

            await Task.Delay(1500);
        }

        async Task OnAsyncCommandC(object parameter)
        {
            Text = $"C {counterC}";
            counterC++;

            await Task.Delay(1500);
        }

        async Task OnAsyncCommandD(object parameter)
        {
            Text = $"D {counterD}";
            counterD++;

            await Task.Delay(1500);
        }

        async Task OnAsyncCommandE(object parameter)
        {
            Text = $"E {counterE}";
            counterE++;

            await Task.Delay(10000);
        }

        async Task OnAsyncCommandF(object parameter)
        {
            Text = $"F {counterF}";
            counterF++;

            await Task.Delay(1500);
        }

        #region INotifyPropertyChanged

        /// <summary>
        /// Property changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void SetProperty<T>(ref T backendStore, T value, [CallerMemberName]string propertyName = null)
        {
            if (propertyName == null)
                return;

            backendStore = value;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
