using System;

using Esme.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Esme.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
