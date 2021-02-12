using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FluentCommands.MobileApp.Pages
{
    /// <summary>
    /// Abstract view model.
    /// </summary>
    public abstract class AbstractViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        /// <summary>
        /// Set property.
        /// </summary>
        /// <typeparam name="T">Type of the property.</typeparam>
        /// <param name="backendStore">Backend store.</param>
        /// <param name="value">Value.</param>
        /// <param name="propertyName">Property name.</param>
        protected void SetProperty<T>(ref T backendStore, T value, [CallerMemberName] string propertyName = null)
        {
            // TODO: missing equal check
            backendStore = value;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
