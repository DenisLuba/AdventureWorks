using AdventureWorks.MAUI.CommandClasses;
using System.Runtime.Serialization;

namespace AdventureWorks.Views;

public partial class UserListView : ContentPage
{
	public UserListView(UserViewModelCommands viewModel)
	{
		InitializeComponent();

		ViewModel = viewModel;
	}

	private readonly UserViewModelCommands ViewModel;

    protected override void OnAppearing()
    {
        base.OnAppearing();

		BindingContext = ViewModel;

		ViewModel.Get();
    }
}