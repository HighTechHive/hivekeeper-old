using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using HiveKeeper.Models;

[assembly: Xamarin.Forms.Dependency(typeof(HiveKeeper.Services.MockDataStore))]
namespace HiveKeeper.Services
{
    public class MockApiaryStore : IDataStore<Apiary>
    {
        List<Apiary> items;

        public MockApiaryStore()
        {
            items = new List<Apiary>();
            var mockItems = new List<Apiary>
            {
                new Apiary { Id = 1, Name = "First item", HostName="This is an item description." },
                new Apiary { Id = 2, Name = "Second item", HostName="This is an item description." },
                new Apiary { Id = 3, Name = "Third item", HostName="This is an item description." },
                new Apiary { Id = 4, Name = "Fourth item", HostName="This is an item description." },
                new Apiary { Id = 5, Name = "Fifth item", HostName="This is an item description." },
                new Apiary { Id = 6, Name = "Sixth item", HostName="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Apiary item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Apiary item)
        {
            var _item = items.Where((Apiary arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Apiary item)
        {
            var _item = items.Where((Apiary arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Apiary> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<Apiary>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}