using System;
using MyShop.Views;
using Xamarin.Forms;

namespace MyShop
{
	public class App : Application
	{
        //public static IAuthenticate Authenticator { get; private set; }

        public App ()
		{
            // The root page of your application
            //MainPage = new NavigationPage(new HomePage());
            MainPage = new NavigationPage(new LoginPage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#2B84D3")
            };
        }

        //public static void Init(IAuthenticate authenticator)
        //{
        //    Authenticator = authenticator;
        //}

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

