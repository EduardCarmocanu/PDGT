using System;
using Akavache;
using System.Reactive.Linq;
using PDGT.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using PDGT.Services;
using PDGT.Models.Authentication;

namespace PDGT.Stores
{
    public class TokenStore
    {
        public static User GetUserToken()
        {
            User CurrentUser = new User();

            try
            {
                CurrentUser = BlobCache.Secure.GetObject<User>("CurrentUser").Wait();
            }
            catch (KeyNotFoundException)
            {
                //UserLogin newLogin = new UserLogin();
                //newLogin.Email = "patient@email.com";
                //newLogin.Password = "Password123!";

                //AuthenticationService.AuthenticateUser(newLogin);
                //Console.WriteLine("Logged in - or something, try to see");
            }
            return CurrentUser;
        }
    }
}
