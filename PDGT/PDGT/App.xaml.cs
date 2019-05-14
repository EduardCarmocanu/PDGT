using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDGT.Stores;
using PDGT.Models;

using PDGT.Pages;
using Akavache;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PDGT
{
	public partial class App : Application
	{
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());

		}

        protected override void OnStart()
        {

            User LoggedInUser = TokenStore.GetUserToken();

            if (LoggedInUser.Token == null)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
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
