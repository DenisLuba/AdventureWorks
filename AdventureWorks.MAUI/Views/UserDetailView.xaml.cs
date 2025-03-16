using AdventureWorks.MAUI.CommandClasses;
using AdventureWorks.ViewModelLayer;

namespace AdventureWorks.Views;

public partial class UserDetailView : ContentPage
{
	public UserViewModel ViewModel { get; set; }
	public UserDetailView(UserViewModelCommands viewModel)
	{
		InitializeComponent();

        ViewModel = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Set the Page BindingContext
        BindingContext = ViewModel;

        // Get the Phone Types
        ViewModel.GetPhoneTypes();

        // Retrieve a User
        ViewModel.Get(3);
    }
}