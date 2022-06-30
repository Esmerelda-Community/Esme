using System;

using Esme.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Esme.Views
{
    public sealed partial class LogInPage : Page
    {
        public LogInViewModel ViewModel { get; } = new LogInViewModel();

        public LogInPage()
        {
            InitializeComponent();
        }
    }
}
