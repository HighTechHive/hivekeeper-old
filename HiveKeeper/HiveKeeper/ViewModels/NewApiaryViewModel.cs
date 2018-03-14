using HiveKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.ViewModels
{
    public class NewApiaryViewModel : BaseViewModel
    {
        public NewApiaryViewModel()
        {
            Apiary = new Apiary
            {
                Name = "Apiary Name",
                HostName = "Host Name"
            };
        }

        public Apiary Apiary { get; set; }

        public List<State> States
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

        public List<Country> Countries
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
    }
}
