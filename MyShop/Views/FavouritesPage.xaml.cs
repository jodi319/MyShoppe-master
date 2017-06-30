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
    public partial class FavouritesPage : ContentPage
    {
        Favourites Favourite { get; set; }

        IDataStore iDataFavourite;

        public FavouritesPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            // DisplayAlert("Alert", "(TO BE IMPLEMENTED) OnAppearing  is clicked", "OK");
            base.OnAppearing();

            if (Settings.InitRegSet)
            {
                Navigation.InsertPageBefore(new RegionsPage(), this);
                //await Navigation.PushAsync(new RegionsPage());
                //Settings.InitRegSet = false;
                
            }
        }

        private void Switches_OnToggled(object sender, ToggledEventArgs e)
        {
            //DisplayAlert("Alert", switch03.ClassId + " Status is " + e.Value.ToString(), "OK");
            //LblStatus.Text = "";
            //LblStatus.Text = LblStatus.Text + ", " + ((Switch)sender).ClassId + " = " + e.Value.ToString();
        }

        public void Save_Activated(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "(TO BE IMPLEMENTED) Save  is clicked", "OK");


            iDataFavourite = DependencyService.Get<IDataStore>();

            Favourites favourites = new Favourites()
            {
                UserId = 001,
                FashionAndBeauty = Convert.ToInt32(FashionAndBeauty.IsToggled),
                SportsAndOutdoor = Convert.ToInt32(SportsAndOutdoorName.IsToggled),
                Pets = Convert.ToInt32(Pets.IsToggled),
                Vehicles = Convert.ToInt32(Vehicles.IsToggled),
                HomeImprovement = Convert.ToInt32(HomeImprovement.IsToggled),
                BabiesChildren = Convert.ToInt32(BabiesChildren.IsToggled),
                HobbiesInterests = Convert.ToInt32(HobbiesInterests.IsToggled),
                MobilePhonesAndAccessories = Convert.ToInt32(MobilePhonesAndAccessories.IsToggled),
                HomeAppliances = Convert.ToInt32(HomeAppliances.IsToggled),
                Gaming = Convert.ToInt32(Gaming.IsToggled),
                Books = Convert.ToInt32(Books.IsToggled),
                Music = Convert.ToInt32(Music.IsToggled),
            };

            iDataFavourite.AddFavouriteAsync(favourites);
        }

        public void SelectAll_Activated(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "(TO BE IMPLEMENTED) Select All  is clicked", "OK");
        }

        public void SelectNone_Activated(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "(TO BE IMPLEMENTED) Select None is clicked", "OK");
        }
    }
}