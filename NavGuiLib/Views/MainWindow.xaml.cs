using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using NavGuiLib.Views;

namespace NavGuiLib
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            App.NavigationService.Initialize(ContentFrame);
            App.NavigationService.Navigate(typeof(HomePage));
        }

        private void NavView_SelectionChanged(
            NavigationView sender,
            NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "Home":
                        App.NavigationService.Navigate(typeof(HomePage));
                        break;

                    case "EnumToBrush":
                        App.NavigationService.Navigate(typeof(EnumToBrushPage));
                        break;

                    case "Tab2":
                        App.NavigationService.Navigate(typeof(Tab2Page));
                        break;
                }
            }
        }
    }
}
