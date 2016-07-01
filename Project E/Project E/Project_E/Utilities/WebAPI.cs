using Newtonsoft.Json;
using Project_E.Interfaces;
using Project_E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project_E.Utilities
{
    class WebAPI
    {
        private string baseAdress = "http://enqtrapi.azurewebsites.net/api/";

        public async void Post(string adressExtension, object myObject)
        {
            
            string message = JsonConvert.SerializeObject(myObject);
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "", message }
                };

                var content = new FormUrlEncodedContent(values);

                var response = await client.PostAsync(baseAdress + adressExtension, content);

                var responseString = await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<string> Login (string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = client.GetAsync(baseAdress + "account/login?email=" + username + "&password=" + password);

                var responseString = await response.Result.Content.ReadAsStringAsync();

                
                //JsonConvert.PopulateObject(response.Result, user);
                return responseString;
            }
        }

        public string Get(string adressExtension, int surveyId = 0, int questionId=0, string userId=null)
        {
            using (var client = new HttpClient())
            {
                var db = DependencyService.Get<ISQLite>().GetConnection();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var token = db.Table<User>().FirstOrDefault().Token;
                client.DefaultRequestHeaders.Add("x-auth-token", token);
                string adressVariables = "";
                if (surveyId != 0)
                {
                    adressVariables += "surveyid=" + surveyId;
                }
                if (questionId != 0 && userId != null)
                {
                    adressVariables += "&questionid=" + questionId + "&userid=" + userId;
                }
                var response = client.GetAsync(baseAdress + adressExtension).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                return responseString;
            }
        }


    }
}
