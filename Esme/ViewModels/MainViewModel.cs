using System.Windows.Input;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Esme.Contracts.Services;

using Microsoft.UI.Xaml.Navigation;

namespace Esme.ViewModels;

public class MainViewModel : ObservableRecipient
{
    public MainViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
        NavigationService.Navigated += OnNavigated;
    }

    private bool _isBackEnabled;
    private object _selected;
    private ICommand _intelligenceCommand;
    
    public ICommand IntelligenceCommand => _intelligenceCommand ??= new RelayCommand(IntelligenceStart);

    public INavigationService NavigationService
    {
        get;
    }

    public bool IsBackEnabled
    {
        get => _isBackEnabled;
        set => SetProperty(ref _isBackEnabled, value);
    }

    public object Selected
    {
        get => _selected;
        set => SetProperty(ref _selected, value);
    }

    private void OnNavigated(object sender, NavigationEventArgs e) => IsBackEnabled = NavigationService.CanGoBack;

    private void IntelligenceStart() => NavigationService.NavigateTo(typeof(IntelligenceViewModel).FullName);

}
