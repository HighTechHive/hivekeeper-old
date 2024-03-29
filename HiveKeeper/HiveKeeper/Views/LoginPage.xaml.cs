﻿using HiveKeeper.Models;
using HiveKeeper.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HiveKeeper.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        LoginViewModel viewModel;

        public LoginPage ()
		{
			InitializeComponent ();

            BindingContext = viewModel = new LoginViewModel();            
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = viewModel.AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;

                MessagingCenter.Send<LoginPage>(this, Messages.USER_LOGGED_IN);

                //App.MainPage = new NavigationPage(new LeftNavPage());
                //Navigation.InsertPageBefore(new LeftNavPage(), this);
                //await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

    }
}