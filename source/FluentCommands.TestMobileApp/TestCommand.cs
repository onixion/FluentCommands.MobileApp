using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FluentCommands.TestMobileApp
{
    public class TestCommand : AbstractFluentCommand
    {
        readonly TestViewModel viewModel;

        public TestCommand(TestViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        bool canExecute = false;

        public void SetCanExecute(bool enable)
        {
            canExecute = enable;
            RaiseCanExecuteChanged();
        }

        public override bool CanExecute(object parameter = null)
        {
            return canExecute;
        }

        int counter = 0;

        public override async Task ExecuteAsync(object parameter = null)
        {
            viewModel.Text = $"F {counter} (4s) [LockThis]";
            counter++;

            await Task.Delay(4000);
        }
    }
}
