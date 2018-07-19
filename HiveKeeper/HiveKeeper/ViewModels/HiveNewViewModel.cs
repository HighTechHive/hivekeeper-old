using HiveKeeper.Models;
using HiveKeeper.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HiveKeeper.ViewModels
{
    public class HiveNewViewModel : BaseViewModel
    {
        public HiveNewViewModel()
        {
            MessagingCenter.Subscribe<HiveAddNewPage>(this, Messages.HIVE_ADDED, async (sender) =>
            {
                var _item = GetHiveModel();
                MessagingCenter.Send<HiveNewViewModel, Hive>(this, Messages.HIVE_ADDED, _item);
            });
        }

        
        public List<HiveType> AvailableHiveTypes
        {
            get
            { 
                // replace with a service/moq call
                return new List<HiveType>
                {
                    new HiveType { Name = "Langstroth", Id = 1},
                    new HiveType{ Name = "Warre", Id = 2},
                    new HiveType { Name = "TopBar", Id = 3 },
                    new HiveType { Name = "FlowHive", Id = 4 }
                };
            }
        }

        private State _selectedHiveType;
        public State SelectedHiveType
        {
            get { return _selectedHiveType; }
            set
            {
                _selectedHiveType = value;
                // todo: raise property changed event here
            }
        }

        public int Id { get; set; }

        public string Name { get; set; }

        private Hive GetHiveModel()
        {
            return new Hive
            {
                Id = Id,
                Name = Name,
            };
        }
    }
}
