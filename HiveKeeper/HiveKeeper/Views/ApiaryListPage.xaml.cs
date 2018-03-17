using HiveKeeper.Models;
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
	public partial class ApiaryListPage : ContentPage
	{
        ApiariesViewModel viewModel;

        public ApiaryListPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new ApiariesViewModel();
        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewApiaryPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Apiaries.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }

        private async void ApiaryView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Apiary;
            if (item == null)
                return;

            await Navigation.PushAsync(new ApiaryDetailsPage(new ApiaryDetailsViewModel(item)));

            // Manually deselect item.
            ApiaryView.SelectedItem = null;
        }
    }
}