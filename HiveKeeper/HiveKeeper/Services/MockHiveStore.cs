using HiveKeeper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiveKeeper.Services
{
    public class MockHiveStore : IDataStore<Hive>
    {
        List<Hive> items;
        public MockHiveStore()
        {
            items = new List<Hive>();
            var mockItems = new List<Hive>
            {
                new Hive { Id = 1, Name = "First item" },
                new Hive { Id = 2, Name = "Second item" },
                new Hive { Id = 3, Name = "Third item" },
                new Hive { Id = 4, Name = "Fourth item" },
                new Hive { Id = 5, Name = "Fifth item" },
                new Hive { Id = 6, Name = "Sixth item" },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Hive item)
        {
            items.Add(item);
            return await Task.FromResult(true);
        }

        public Task<bool> DeleteItemAsync(Hive item)
        {
            throw new NotImplementedException();
        }

        public async Task<Hive> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<Hive>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<bool> UpdateItemAsync(Hive item)
        {
            var _item = items.Where((Hive arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }
    }
}
