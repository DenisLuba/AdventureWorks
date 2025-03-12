using AdventureWorks.EntityLayer.EntityClasses;

namespace AdventureWorks.Views;

public partial class UserDetailView : ContentPage
{
	public User UserObject { get; set; }
	public UserDetailView()
	{
		InitializeComponent();

		UserObject = (User)Resources["viewModel"];
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debugger.Break();
    }
}