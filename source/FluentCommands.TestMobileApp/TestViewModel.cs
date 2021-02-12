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
        /// Text.
        /// </summary>
        public bool CanExecuteForF
        {
            get => canExecuteForF;
            set
            {
                SetProperty(ref canExecuteForF, value);
                fCommand.SetCanExecute(value);
            }
        }
        private bool canExecuteForF;

        TestCommand fCommand;

        /// <summary>
        /// Constructor.
        /// </summary>
        public TestViewModel()
        {
            fCommand = new TestCommand(this);

            FluentCommandManager
                .New()
                .LockAll(eg =>
                {
                    CommandA = eg.Register(FluentCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandA));

                    CommandD = eg.Register(FluentCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandD));
                })
                .LockOthers(eg =>
                {
                    CommandB = eg.Register(FluentCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandB));

                    CommandE = eg.Register(FluentCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandE));
                })
                .LockThis(eg =>
                {
                    CommandC = eg.Register(FluentCommand
                        .New()
                        .OnExecuteAsync(OnAsyncCommandC));

                    CommandF = eg.Register(fCommand);
                });
        }

        int counterA = 0;
        int counterB = 0;
        int counterC = 0;
        int counterD = 0;
        int counterE = 0;

        async Task OnAsyncCommandA(object parameter)
        {
            Text = $"A {counterA} (1s) [LockAll]";
            counterA++;

            await Task.Delay(1000);
        }

        async Task OnAsyncCommandB(object parameter)
        {
            Text = $"B {counterB} (2s) [LockOthers]";
            counterB++;

            await Task.Delay(2000);
        }

        async Task OnAsyncCommandC(object parameter)
        {
            Text = $"C {counterC} (3s) [LockThis]";
            counterC++;

            await Task.Delay(3000);
        }

        async Task OnAsyncCommandD(object parameter)
        {
            Text = $"D {counterD} (2s) [LockAll]";
            counterD++;

            await Task.Delay(2000);
        }

        async Task OnAsyncCommandE(object parameter)
        {
            Text = $"E {counterE} (5s) [LockOthers]";
            counterE++;

            await Task.Delay(5000);
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
