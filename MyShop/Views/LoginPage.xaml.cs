using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyShop.Helpers;
using MyShop.Views;
using Plugin.Connectivity;

namespace MyShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        //LoginViewModel viewModel;
        //UsersViewModel userViewModel;

        // Track whether the user has authenticated.
        bool authenticated = false;

        public LoginPage()
        {
            InitializeComponent ();
            //BindingContext = viewModel = new LoginViewModel(this);
        }

        protected async override void OnAppearing()
        {
            // DisplayAlert("Alert", "(TO BE IMPLEMENTED) OnAppearing  is clicked", "OK");
            base.OnAppearing();

            //CrossConnectivity.Current.ConnectivityChanged += ConnecitvityChanged;
            //OfflineStack.IsVisible = !CrossConnectivity.Current.IsConnected;


            //if (authenticated == true)
            //{
            //    await Navigation.PushModalAsync(new FavouritePage());
            //    Settings.InitFavSet = false;
            //}
            //else
            //{
            //    //await vm.LoginAsync();
            //    //if (Settings.IsLoggedIn)
            //    //    vm.LoadCoffeesCommand.Execute(null);
            //}
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());

            //DELETE THIS------------------------------
            Settings.InitFavSet = true;
            Settings.InitRegSet = true;
            //-----------------------------------------

            if (Settings.InitFavSet)
            {
                await Navigation.PushAsync(new FavouritesPage());
                Settings.InitFavSet = false;

                //if (!Settings.InitFavSet && Settings.InitRegSet)
                //{
                //    await Navigation.PushAsync(new RegionsPage());
                //    Settings.InitRegSet = false;
                //}
            }


            //else
            //{
            //    await Navigation.PushAsync(new StoresPage());

            //    //Settings.InitFavSet = false;
            //}
            //await Navigation.PushAsync(new StoresPage());
        }

        async void OnFacebookLoginButtonClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "(TO BE IMPLEMENTED) OnAppearing  is clicked", "OK");
            //try
            //{

            //    if (App.Authenticator != null)
            //        authenticated = await App.Authenticator.AuthenticateAsync();

            //    //if (authenticated)
            //    if (authenticated)
            //    {
            //        Navigation.InsertPageBefore(new FavouritePage(), this);
            //        await Navigation.PopAsync();
            //    }

            //    //    if (Settings.InitFavSet)
            //    //    {
            //    //        await Navigation.PushModalAsync(new FavouritePage());
            //    //        Settings.InitFavSet = false;

            //    //        if (!Settings.InitFavSet && Settings.InitRegSet)
            //    //        {
            //    //            await Navigation.PushModalAsync(new RegionPage());
            //    //            Settings.InitRegSet = false;
            //    //        }
            //    //    }
            //    //}
            //}
            //catch (InvalidOperationException ex)
            //{
            //    if (ex.Message.Contains("Authentication was cancelled"))
            //    {
            //        messageLabel.Text = "Authentication cancelled by the user";
            //    }
            //}
            //catch (Exception)
            //{
            //    messageLabel.Text = "Authentication failed";
            //}
        }
    }
}