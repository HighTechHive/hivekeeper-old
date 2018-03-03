using HiveKeeper.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HiveKeeper.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public bool AreCredentialsCorrect(User user)
        {
            return user.Username == "zbroyan" && user.Password == "test123";
        }
    }
}
