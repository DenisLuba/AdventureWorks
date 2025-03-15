using AdventureWorks.ViewModelLayer;

namespace AdventureWorks.Views;

public partial class UserDetailView : ContentPage
{
	public UserViewModel? ViewModel { get; set; }
	public UserDetailView()
	{
		InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        // Create a new instance of UserViewModel
        ViewModel = new();

        // Set the Page BindingContext
        BindingContext = ViewModel;

        // Retrieve a User
        ViewModel.Get(1);
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debugger.Break();
    }
}