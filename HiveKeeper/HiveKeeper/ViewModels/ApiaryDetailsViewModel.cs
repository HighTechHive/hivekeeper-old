using HiveKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.ViewModels
{
    public class ApiaryDetailsViewModel : BaseViewModel
    {
        Apiary _apiary;
        public ApiaryDetailsViewModel(Apiary apiary)
        {
            _apiary = apiary;
        }
       
        public Apiary Apiary
        {
            get { return _apiary; }            
        }   
    }
}
