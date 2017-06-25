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
    public partial class RegionPage : ContentPage
    {
        Region Region { get; set; }

        public RegionPage()
        {
            InitializeComponent();
        }

        private void Switches_OnToggled(object sender, ToggledEventArgs e)
        {
            //DisplayAlert("Alert", switch03.ClassId + " Status is " + e.Value.ToString(), "OK");
            LblStatus.Text = "";
            LblStatus.Text = LblStatus.Text + ", " + ((Switch)sender).ClassId + " = " + e.Value.ToString();

            //DisplayAlert("Alert", ((Switch)sender).ClassId + " Status is " + easterncape.IsToggled.ToString(), "OK");
            

            //Region.EasternCape = Convert.ToInt32(easterncape.IsToggled);
            //Region.FreeState = Convert.ToInt32(freestate.IsToggled);
            //Region.Gauteng = Convert.ToInt32(gauteng.IsToggled);
            //Region.KwaZuluNatal = Convert.ToInt32(kwazulunatal.IsToggled);
            //Region.Limpopo = Convert.ToInt32(limpopo.IsToggled);
            //Region.Mpumalanga = Convert.ToInt32(mpumalanga.IsToggled);
            //Region.NorthernCape = Convert.ToInt32(northerncape.IsToggled);
            //Region.NorthWest = Convert.ToInt32(northwest.IsToggled);
            //Region.WesternCape = Convert.ToInt32(westerncape.IsToggled);
        }

        public void OnSaveRegion(object sender, ToggledEventArgs e)
        {
            
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