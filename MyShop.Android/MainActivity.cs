using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using Android.Graphics.Drawables;
using Xamarin.Forms.Platform.Android;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Android.Webkit;

namespace MyShop.Droid
{
	[Activity (Label = "My Shoppe", Icon = "@drawable/ic_launcher", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : FormsAppCompatActivity
    {
        //// Define a authenticated user.
        //private MobileServiceUser user;
        //AzureDataStore idatafavourite;

        protected override void OnCreate (Bundle bundle)
		{

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;
            base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			global::Xamarin.FormsMaps.Init (this, bundle);

			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
			
			LoadApplication (new App ());
			ImageCircleRenderer.Init();

		}

        //public async Task<bool> AuthenticateAsync()
        //{
        //    var success = false;
        //    var message = string.Empty;

        //    try
        //    {
        //        if (user == null)
        //        {
        //            // The authentication provider could also be Facebook, Twitter, or Microsoft
        //            user = await idatafavourite.MobileService.LoginAsync(this, MobileServiceAuthenticationProvider.Facebook);//TodoItemManager.DefaultManager.CurrentClient.LoginAsync(this, MobileServiceAuthenticationProvider.Facebook);
        //            if (user != null)
        //            {
        //                CreateAndShowDialog(string.Format("You are now logged in - {0}", user.UserId), "Logged in!");
        //            }
        //        }
        //        success = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        CreateAndShowDialog(ex.Message, "Authentication failed");
        //    }
        //    return success;
        //}

        //public async Task<bool> LogoutAsync()
        //{
        //    bool success = false;
        //    try
        //    {
        //        if (user != null)
        //        {
        //            CookieManager.Instance.RemoveAllCookie();
        //            await idatafavourite.MobileService.LogoutAsync();//TodoItemManager.DefaultManager.CurrentClient.LogoutAsync();
        //            CreateAndShowDialog(string.Format("You are now logged out - {0}", user.UserId), "Logged out!");
        //        }
        //        user = null;
        //        success = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        CreateAndShowDialog(ex.Message, "Logout failed");
        //    }

        //    return success;
        //}

        //void CreateAndShowDialog(string message, string title)
        //{
        //    var builder = new AlertDialog.Builder(this);
        //    builder.SetMessage(message);
        //    builder.SetTitle(title);
        //    builder.SetNeutralButton("OK", (sender, args) => {
        //    });
        //    builder.Create().Show();
        //}
    }
}

