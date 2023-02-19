using MauiApp2.Models;
using MauiApp2.ViewModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{

	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        var person = new Person { Name = "John Doe", Age = 30 };
        Shell.Current.NavigatedTo += Current_NavigatedTo;
        Shell.Current.NavigatedFrom += Current_NavigatedFrom;
        Shell.Current.Navigating += Current_Navigating;

    }

    private void Current_Navigating(object sender, ShellNavigatingEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Current_NavigatedFrom(object sender, NavigatedFromEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Current_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
         var item = sender as Person;
        
    }
}

