using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyShop.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegionsPage : ContentPage
    {
        public RegionsPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            // DisplayAlert("Alert", "(TO BE IMPLEMENTED) OnAppearing  is clicked", "OK");
            base.OnAppearing();

            if (!Settings.InitFavSet && Settings.InitRegSet)
            {
                //Navigation.InsertPageBefore(new RegionsPage(), this);
                //await Navigation.PushAsync(new RegionsPage());
                //Settings.InitRegSet = false;
            }
        }

        protected override void OnDisappearing()
        {
            // DisplayAlert("Alert", "(TO BE IMPLEMENTED) OnAppearing  is clicked", "OK");
            base.OnAppearing();


            Settings.InitRegSet = false;
            //if (!Settings.InitFavSet && Settings.InitRegSet)
            //{
            //    //Navigation.InsertPageBefore(new RegionsPage(), this);
            //    //await Navigation.PushAsync(new RegionsPage());
            //    //Settings.InitRegSet = false;
            //}
        }
    }
}