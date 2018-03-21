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
        ApiaryDetailsViewModel _viewModel;
        public ApiaryDetailsPage (ApiaryDetailsViewModel viewModel)
		{
			InitializeComponent ();

            BindingContext = _viewModel = viewModel;
		}

        async private void AddHive_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new HiveAddNewPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (_viewModel.Hives.Count == 0)
                _viewModel.LoadHivesCommand.Execute(null);
        }
    }
}