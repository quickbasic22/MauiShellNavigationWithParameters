using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using MauiApp2.Messages;
using MauiApp2.Models;

namespace MauiApp2.ViewModel;

[QueryProperty("Text", "Text")]
[QueryProperty("Person", "Person")]
public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [ObservableProperty]
    Person person;

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    [RelayCommand]
    async Task Delete()
    {
        WeakReferenceMessenger.Default.Send(new DeleteItemMessage(Text));
        await GoBack();
    }

    public DetailViewModel()
    {
        Shell.Current.Navigated += Current_Navigated;
        Shell.Current.NavigatedFrom += Current_NavigatedFrom;
        Shell.Current.NavigatedTo += Current_NavigatedTo;
        Shell.Current.Navigating += Current_Navigating;
        Shell.Current.NavigatingFrom += Current_NavigatingFrom;

    }

    private void Current_NavigatingFrom(object sender, NavigatingFromEventArgs e)
    {
        
    }

    private void Current_Navigating(object sender, ShellNavigatingEventArgs e)
    {

        // THIS ONE e.Current.Location.Segments
    }

    private void Current_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        
    }

    private void Current_NavigatedFrom(object sender, NavigatedFromEventArgs e)
    {
       
    }

    private void Current_Navigated(object sender, ShellNavigatedEventArgs e)
    {
      // THIS ONE e.Current.Location.UserInfo
    }
}
