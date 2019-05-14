using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PDGT.Pages;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PDGT
{
	public partial class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }
        public App()
		{
            IsUserLoggedIn = false;
            InitializeComponent();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {

                MainPage = new NavigationPage(new MainPage());
            }
		}

        protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
