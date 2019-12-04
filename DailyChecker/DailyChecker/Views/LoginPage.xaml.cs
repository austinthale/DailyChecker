﻿using DailyChecker.Models;
using DailyChecker.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DailyChecker.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
            Lbl_Password.TextColor = Constants.MainTextColor;
            Lbl_Username.TextColor = Constants.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIcon.HeightRequest = Constants.LoginIconHeight;
            App.StartCheckIfInternet(lbl_NoInternet, this);

            Entry_Username.Completed += (s, e) => Entry_Password.Focus();
            Entry_Password.Completed += (s, e) => SignIn_Clicked(s,e);
        }

        private async void SignIn_Clicked(object sender, EventArgs e)
        {
            User user = new User(Entry_Username.Text, Entry_Password.Text);
            if (user.ValidateLogin())
            {
                DisplayAlert("Login", "Login Success", "OK");
                //var result = await App.RestService.Login(user);
                var result = new Token();
                if (result != null)
                {
                    //App.UserDatabase.SaveUser(user);
                    //App.TokenDatabase.SaveToken(result);
                    if(Device.RuntimePlatform == Device.Android)
                    {
                        Application.Current.MainPage = new NavigationPage(new Dashboard());
                    }
                    else if (Device.RuntimePlatform == Device.iOS)
                    {
                        await Navigation.PushModalAsync(new NavigationPage(new Dashboard()));
                    }
                }
            }
            else
            {
                DisplayAlert("Login", "Invalid Username or Password", "OK");
            }
        }
    }
}