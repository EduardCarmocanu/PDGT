using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using PDGT.Models;

namespace PDGT.Services
{
    public class AuthenticationService
    {
        public static async void SetUserToken(string token)
        {
            var user = new User { Token = token };

            await BlobCache.Secure.InsertObject<User>(
                "CurrentUser", 
                user, 
                DateTimeOffset.Now.AddHours(168));
        }
    }
}
