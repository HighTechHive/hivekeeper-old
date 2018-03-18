using HiveKeeper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HiveKeeper.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApiaryDetailsPage : ContentPage
	{
        ApiaryDetailsViewModel viewModel;

        public ApiaryDetailsPage (ApiaryDetailsViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = viewModel;
		}

        async private void AddHive_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HiveAddNewPage()));
        }
    }
}