using Esme.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Esme.Views;

public sealed partial class IntelligencePage : Page
{
    public IntelligenceViewModel ViewModel
    {
        get;
    }

    public IntelligencePage()
    {
        ViewModel = App.GetService<IntelligenceViewModel>();
        InitializeComponent();
    }
}
