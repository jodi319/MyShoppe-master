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
    public partial class FavouritePage : ContentPage
    {
        public FavouritePage()
        {
            InitializeComponent();
        }

        private void Switches_OnToggled(object sender, ToggledEventArgs e)
        {
            //DisplayAlert("Alert", switch03.ClassId + " Status is " + e.Value.ToString(), "OK");
            LblStatus.Text = "";
            LblStatus.Text = LblStatus.Text + ", " + ((Switch)sender).ClassId + " = " + e.Value.ToString();
        }

        public void Save_Activated(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Alert", "Save is clicked", "OK");
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