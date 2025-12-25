// Services/NavigationService.cs
using Microsoft.UI.Xaml.Controls;
using System;

namespace NavGuiLib.Services
{
    public class NavigationService : INavigationService
    {
        private Frame? _frame;

        public void Initialize(Frame frame)
        {
            _frame = frame;
        }

        public void Navigate(Type pageType)
        {
            _frame?.Navigate(pageType);
        }
    }
}
