using Microsoft.UI.Xaml;
using NavGuiLib.Services;

namespace NavGuiLib
{
    public partial class App : Application
    {
        public static INavigationService NavigationService { get; private set; }

        public App()
        {
            this.InitializeComponent();
            NavigationService = new NavigationService();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            MainWindow window = new MainWindow();
            window.Activate();
        }
    }
}
