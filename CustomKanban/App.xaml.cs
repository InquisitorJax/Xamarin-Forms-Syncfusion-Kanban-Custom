using Xamarin.Forms;

namespace CustomKanban
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var basicPage = new CustomKanbanPage(); //basic example
            var workItemPage = new WorkDashboardPage(); //alternative example

            MainPage = new NavigationPage(workItemPage);
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }
    }
}