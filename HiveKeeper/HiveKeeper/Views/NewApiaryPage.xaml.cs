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
            // indicates wheter this is a newly apiary or edited/modified one
            bool isNew = true;
            // todo: don't send the object apiary here.. instead, just send an event and let the viewmodel collect and create the apiary object
            MessagingCenter.Send<NewApiaryPage, bool>(this, Messages.APIARY_SAVED, isNew);
            await Navigation.PopModalAsync();
        }


    }
}