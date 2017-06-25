using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SalePage : ContentPage
    {
        SaleViewModel viewModel;
        public SalePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SaleViewModel(this);
        }
    }
}