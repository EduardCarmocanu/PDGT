using System;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Akavache;
using PDGT.Models;
using PDGT.Models.Authentication;
using RestSharp;
using Newtonsoft.Json;

namespace PDGT.Services
{
    public class AuthenticationService
    {
        public static async void SetUserTokenAsync(string token)
        {
            var user = new User { Token = token };

            await BlobCache.Secure.InsertObject<User>(
                "CurrentUser", 
                user, 
                DateTimeOffset.Now.AddHours(168));
        }

        public static bool AuthenticateUser (UserLogin login)
        {
            var client = new RestClient("https://pdgtapiprod.azurewebsites.net/api/authenticate/");
            var request = new RestRequest(Method.POST);

            string Parameter = JsonConvert.SerializeObject(login);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", Parameter, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if(response.IsSuccessful)
            {
                SetUserTokenAsync(response.Content);
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
