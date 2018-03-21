using HiveKeeper.Models;
using HiveKeeper.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HiveKeeper.ViewModels
{
    public class ApiaryDetailsViewModel : BaseViewModel
    {
        public IDataStore<Hive> DataStore => DependencyService.Get<IDataStore<Hive>>() ?? new MockHiveStore();

        Apiary _apiary;
        public Command LoadHivesCommand { get; set; }
        public ObservableCollection<Hive> Hives { get; set; }

        public ApiaryDetailsViewModel(Apiary apiary)
        {
            _apiary = apiary;
            LoadHivesCommand = new Command(async () => await ExecuteLoadHivesCommand());
            Hives = new ObservableCollection<Hive>();

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


        private async Task ExecuteLoadHivesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Hives.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Hives.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
