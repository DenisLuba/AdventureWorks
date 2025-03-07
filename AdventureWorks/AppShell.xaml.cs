namespace AdventureWorks
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Register a route
            Routing.RegisterRoute(nameof(Views.UserDetailView), typeof(Views.UserDetailView));
        }
    }
}
