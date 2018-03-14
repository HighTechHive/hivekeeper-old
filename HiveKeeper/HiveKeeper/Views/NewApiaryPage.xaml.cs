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
	public partial class NewApiaryPage : ContentPage
	{
        private NewApiaryViewModel viewModel;

        public NewApiaryPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new NewApiaryViewModel();
        }
               

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", viewModel.Apiary);
            await Navigation.PopModalAsync();
        }


    }
}