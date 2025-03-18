using AdventureWorks.MAUI.CommandClasses;
using AdventureWorks.EntityLayer;

namespace AdventureWorks.Views;

[QueryProperty(nameof(UserId), "id")]
public partial class UserDetailView : ContentPage
{
	public UserViewModelCommands ViewModel { get; set; }
    public int UserId { get; set; }

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
        ViewModel.Get(UserId);
    }
}