using System;
using HiveKeeper.ViewModels;
using HiveKeeper.Views;
using Xamarin.Forms;

namespace HiveKeeper
{
	public partial class App : Application
	{
        public static bool IsUserLoggedIn { get; set; }

        public App ()
		{
            // Initialize Live Reload.
#if DEBUG
            LiveReload.Init();
#endif

            InitializeComponent();

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new LeftNavPage();
            }

            MessagingCenter.Subscribe<LoginPage>(this, Messages.USER_LOGGED_IN, async (sender) =>
            {
                MainPage = new LeftNavPage();
            });
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}


	}
}
