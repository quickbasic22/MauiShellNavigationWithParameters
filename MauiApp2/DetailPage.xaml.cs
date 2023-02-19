using MauiApp2.Models;
using MauiApp2.ViewModel;
using Microsoft.Maui.Primitives;

namespace MauiApp2;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}