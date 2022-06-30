using System;

using Esme.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Esme.Views
{
    public sealed partial class IntelligencePage : Page
    {
        public IntelligenceViewModel ViewModel { get; } = new IntelligenceViewModel();

        public IntelligencePage()
        {
            InitializeComponent();
        }
    }
}
