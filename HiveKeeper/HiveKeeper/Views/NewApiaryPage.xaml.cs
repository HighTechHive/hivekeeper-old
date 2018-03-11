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
	public partial class NewApiaryPage : ContentPage
	{
        public Apiary Apiary { get; set; }
        
		public NewApiaryPage ()
		{
			InitializeComponent ();

            Apiary = new Apiary
            {
                Name = "Apiary Name",
                HostName = "Host Name"
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Apiary);
            await Navigation.PopModalAsync();
        }


    }
}