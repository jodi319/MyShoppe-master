using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyShop.Helpers;
using MyShop.Views;

namespace MyShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel viewModel;
        public LoginPage()
        {
            InitializeComponent ();
            BindingContext = viewModel = new LoginViewModel(this);
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new HomePage());

            //DELETE THIS------------------------------
            Settings.InitFavSet = true;
            Settings.InitRegSet = true;
            //-----------------------------------------

            if (Settings.InitFavSet)
            {
                await Navigation.PushAsync(new FavouritePage());
                //Settings.InitFavSet = false;
            }
            else
            {
                await Navigation.PushAsync(new StoresPage());

                //Settings.InitFavSet = false;
            }


            if (Settings.InitRegSet)
            {
                await Navigation.PushAsync(new RegionPage());
                //Settings.InitRegSet = false;
            }
            else
            {
                await Navigation.PushAsync(new StoresPage());

                //Settings.InitFavSet = false;
            }

            //await Navigation.PushAsync(new StoresPage());
        }
    }
}