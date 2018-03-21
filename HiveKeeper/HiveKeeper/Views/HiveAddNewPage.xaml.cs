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
	public partial class HiveAddNewPage : ContentPage
	{
        HiveNewViewModel viewModel;
        public HiveAddNewPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new HiveNewViewModel();
        }

        async private void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, Messages.HIVE_ADDED);
            await Navigation.PopModalAsync();
        }
    }
}