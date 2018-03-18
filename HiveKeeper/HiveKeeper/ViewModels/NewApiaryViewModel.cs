using HiveKeeper.Models;
using HiveKeeper.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace HiveKeeper.ViewModels
{
    public class NewApiaryViewModel : BaseViewModel
    {
        public NewApiaryViewModel()
        {
            
            MessagingCenter.Subscribe<NewApiaryPage, bool>(this, Messages.APIARY_SAVED, async (sender, isNew) =>
            {
                var _item = GetApiaryModel();
                MessagingCenter.Send<NewApiaryViewModel, Apiary>(this, Messages.APIARY_SAVED, _item);
            });           
        }        

        public List<State> AvailableStates
        {
            get
            {
                return new List<State>
                {
                    new State{ Name = "California", Abbreviation = "CA"},
                    new State{ Name = "Washington", Abbreviation = "WA"}
                };
            }
        }

        private State _selectedState;
        public State SelectedState
        {
            get { return _selectedState; }
            set {
                _selectedState = value;
                // todo: raise property changed event here
            }
        }

        public List<Country> AvailableCountries
        {
            get
            {
                return new List<Country>
                {
                    new Country{ Name = "United States", Abbreviation = "USA"},
                    new Country{ Name = "Great Britain", Abbreviation = "GB"}
                };
            }
        }

        Country _selectedCountry;
        public Country SelectedCountry
        {
            get { return _selectedCountry; }
            set {
                _selectedCountry = value;
                // raise property changed event
            }
        }

        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address1 { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }        

        public string Zip { get; set; }       

        public string HostName { get; set; }

        public string HostPhone { get; set; }

        public string HostEmail { get; set; }

        public string GateCode { get; set; }


        private Apiary GetApiaryModel()
        {
            return new Apiary
            {
                Id = Id,
                Name = Name,
                HostName = HostName,
                Address = new Address
                {
                    Address1 = Address1,
                    Address2 = Address2,
                    City = City,

                    //todo: use stateId
                    State = SelectedState.Abbreviation,
                    Zip = Zip,

                    //todo: use countryId
                    Country = SelectedCountry.Abbreviation
                },
                HostPhone = HostPhone,
                HostEmail = HostEmail,
                GateCode = GateCode
            };
        }
    }
}
