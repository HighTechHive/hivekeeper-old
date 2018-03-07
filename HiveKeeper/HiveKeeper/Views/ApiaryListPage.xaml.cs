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
		}


        public IEnumerable<Apiary> Apiaries
        {
            get
            {
                return new List<Apiary>
                {
                    new Apiary
                    {
                        Name = "Backyard",
                        HostName = "Zohrab Broyan",
                        HostPhone = "(818) 424-8561",
                        HostEmail = "zohrab.broyan@gmail.com"                        
                    }
                };
            }

        }

    }
}