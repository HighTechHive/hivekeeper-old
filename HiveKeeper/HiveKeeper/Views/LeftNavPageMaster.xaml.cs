using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HiveKeeper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeftNavPageMaster : ContentPage
    {
        public ListView ListView;

        public LeftNavPageMaster()
        {
            InitializeComponent();

            BindingContext = new LeftNavPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class LeftNavPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<LeftNavPageMenuItem> MenuItems { get; set; }
            
            public LeftNavPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<LeftNavPageMenuItem>(new[]
                {
                    new LeftNavPageMenuItem { Id = 0, Title = "My Apiaries", TargetType= typeof(ApiaryListPage) },
                    new LeftNavPageMenuItem { Id = 1, Title = "Map" },
                    new LeftNavPageMenuItem { Id = 2, Title = "Reminders" },
                    new LeftNavPageMenuItem { Id = 3, Title = "Reports" },
                    new LeftNavPageMenuItem { Id = 4, Title = "Strat Inspection" },

                    new LeftNavPageMenuItem { Id = 4, Title = "Log Out" },
                });
            }
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}