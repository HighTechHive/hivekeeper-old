using HiveKeeper.Models;
using HiveKeeper.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace HiveKeeper.ViewModels
{
    public class ApiaryDetailsViewModel : BaseViewModel
    {
        public IDataStore<Hive> DataStore => DependencyService.Get<IDataStore<Hive>>() ?? new MockHiveStore();

        Apiary _apiary;

        public ObservableCollection<Hive> Hives { get; set; }

        public ApiaryDetailsViewModel(Apiary apiary)
        {
            _apiary = apiary;

            MessagingCenter.Subscribe<HiveNewViewModel, Hive>(this, Messages.HIVE_ADDED, async (sender, obj) =>
            {
                var _item = obj as Hive;
                Hives.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
        }
       
        public Apiary Apiary
        {
            get { return _apiary; }            
        }   
    }
}
