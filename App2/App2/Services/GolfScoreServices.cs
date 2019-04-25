using App2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App2.Services
{
    public class GolfScoreServices
    {
         
        public List<GolfScore> GetGolfScore()
        {
            
            var list = new List<GolfScore>
            {
                new GolfScore
                {
                    Hole1 = 3,
                    Hole2 = 4
                }
            };
            return list;
        }

        public async Task SaveGolfScoreAsync(GolfScore score, bool isNewItem = false)
        {
            HttpClient client = new HttpClient();
            var RestUrl = "http://localhost:60080/api/GolfScore/";
            var uri = new Uri(string.Format(RestUrl, string.Empty));

            try
            {
                var json = JsonConvert.SerializeObject(score);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await client.PostAsync(uri, content);
                }
                else
                {
                    response = await client.PutAsync(uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"				TodoItem successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
        }
    }
}
