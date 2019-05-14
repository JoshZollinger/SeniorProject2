using App2.Models;
using App2.RestClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace App2.Services
{
    public class GolfScoreServices
    {
        GolfScoresRestClient<GolfScore> restClient;

        public async Task<List<GolfScore>> GetGolfScoresAsync()
        {
            restClient = new GolfScoresRestClient<GolfScore>();

            var golfScoresList = await restClient.GetAsync();

            return golfScoresList;
        }
        
        public async Task<bool> SaveGolfScoreAsync(GolfScore score, bool isNewItem = false)
        {
            restClient = new GolfScoresRestClient<GolfScore>();

            var success = await restClient.PostAsync(score);

            return true;
         }
        
    }
}
