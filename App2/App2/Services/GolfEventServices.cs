using App2.Models;
using App2.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App2.Services
{
    public class GolfEventServices
    {
        GolfEventRestClient<GolfEvent> restClient;

        public async Task<List<GolfEvent>> GetGolfEventsAsync()
        {
            restClient = new GolfEventRestClient<GolfEvent>();

            var golfEventsList = await restClient.GetAsync();

            return golfEventsList;
        }
    }
}
