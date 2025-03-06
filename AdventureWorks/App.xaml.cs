using System.Diagnostics;

namespace AdventureWorks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Проверка загруженных ресурсов
            if (Resources.TryGetValue("ApplicationTitle", out var title))
            {
                Debug.WriteLine("Resource found: ApplicationTitle");
            }
            else
            {
                Debug.WriteLine("Resource NOT found: ApplicationTitle");
            }
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}