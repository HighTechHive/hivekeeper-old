using HiveKeeper.Models;
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
		public ApiaryListPage ()
		{
			InitializeComponent ();

            ApiaryView.ItemsSource = new List<Apiary>
            {
                new Apiary{ Name = "Blah", HostName = "Bla Bla Bla"},
                new Apiary{ Name = "skdhasj", HostName=" dasda" }
            };

        }


        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }



    }
}