using Citicon.Data;
using System.Windows;

namespace Citicon.DesktopClient.Common
{
    public sealed class LoggedInEventArgs : RoutedEventArgs
    {
        public LoggedInEventArgs(User user)
        {
            User = user;
        }

        public User User { get; }
    }

    public delegate void LoggedInEventHandler(object sender, LoggedInEventArgs e);
}
