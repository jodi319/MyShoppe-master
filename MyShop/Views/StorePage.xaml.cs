using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MyShop
{
	public partial class StorePage : ContentPage
	{
		StoreViewModel viewModel;

        bool authenticated = false;
        bool setRegions = false;
        bool setFavourites = false;

        public StorePage (Store store)
		{
			InitializeComponent ();
            
			BindingContext = viewModel = new StoreViewModel (store, this);
		
		}

		protected override void OnAppearing ()
		{
            base.OnAppearing();

            if (authenticated == true)
            {
                #region FavouritesAndRegionCaptured
                if (setFavourites && setRegions)
                {
                    //messageLabel.Text = "";

                    #region setSelectedFavourites
                    //var favouriteAnswers = multiPage.GetSelection();
                    //foreach (var a in favouriteAnswers)
                    //{
                    //    messageLabel.Text += a.Name + ", ";
                    //    //ADD CODE HERE - set integer values = 1 for a.Name = Favourites Class
                    //    SetFavouriteValue(a.Name);

                    //}
                    #endregion
                }
                #endregion

                #region FavouritesCapturedNotRegion
                if (setFavourites && (setRegions == false)) 
                {

                }
                else
                {

                }
                #endregion

                #region Map
                var position = new Position(viewModel.Store.Latitude, viewModel.Store.Longitude); // Latitude, Longitude
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position,
                    Label = viewModel.Store.Name,
                    Address = viewModel.Store.StreetAddress
                };
                MyMap.Pins.Add(pin);

                MyMap.MoveToRegion(
                    MapSpan.FromCenterAndRadius(
                        position, Distance.FromKilometers(.2))); 
                #endregion
            }
            else
            {

            }
		}
	}
}

