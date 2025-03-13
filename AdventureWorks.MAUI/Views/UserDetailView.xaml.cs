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

    protected override void OnAppearing()
    {
        base.OnAppearing();

        UserObject.LoginId = "PeterPiper384";
        UserObject.FirstName = "Peter";
        UserObject.LastName = "Piper";
        UserObject.Email = "Peter@pipering.com";
    }

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
		System.Diagnostics.Debugger.Break();
    }
}