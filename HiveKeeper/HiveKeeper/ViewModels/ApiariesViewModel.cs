using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using HiveKeeper.Models;
using HiveKeeper.Views;
using HiveKeeper.Services;
using System.Diagnostics;

namespace HiveKeeper.ViewModels
{
    public class ApiariesViewModel : BaseViewModel
    {
        public IDataStore<Apiary> DataStore => DependencyService.Get<IDataStore<Apiary>>() ?? new MockApiaryStore();

        public ObservableCollection<Apiary> Apiaries { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ApiariesViewModel()
        {
            Title = "Apiaries";
            Apiaries = new ObservableCollection<Apiary>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewApiaryPage, Apiary>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Apiary;
                Apiaries.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
        }


        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Apiaries.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Apiaries.Add(item);
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
