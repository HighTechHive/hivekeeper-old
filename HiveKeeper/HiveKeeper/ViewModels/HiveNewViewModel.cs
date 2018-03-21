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
