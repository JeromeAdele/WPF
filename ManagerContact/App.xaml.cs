
using ManagerContact.View;
using System.Windows;

namespace ManagerContact
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            ContactView win = new ContactView();

            win.Width = 300;
            win.MinWidth = 300;
            win.Height = 300;
            win.MinHeight = 300;
            win.WindowState = WindowState.Normal;
            win.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            win.Show();

        }
    }
}