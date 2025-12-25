// Services/INavigationService.cs
using Microsoft.UI.Xaml.Controls;
using System;

namespace NavGuiLib.Services
{
    public interface INavigationService
    {
        void Initialize(Frame frame);
        void Navigate(Type pageType);
    }
}
