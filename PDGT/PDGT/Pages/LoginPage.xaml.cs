using System;
using Xamarin.Forms;
using PDGT.Models.Authentication;
using PDGT.Stores;
using PDGT.Models;
using Akavache;
using PDGT.Services;

namespace PDGT.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }


        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new UserLogin
            {
                Email = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            bool Authenticate = AuthenticationService.AuthenticateUser(user);

            if(Authenticate == true)
            {
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }
    }
}