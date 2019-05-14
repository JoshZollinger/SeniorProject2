using System;
using System.Collections.Generic;
using System.Text;
using App2.RestClient;
using App2.Models;
using System.Threading.Tasks;

namespace App2.Services
{
    public class GolfUserServices
    {
        GolfUsersRestClient<GolfUser> restClient;
        public async Task<List<GolfUser>> GetGolfUsersAsync()
        {
            restClient = new GolfUsersRestClient<GolfUser>();

            var golfUser = await restClient.GetAsync();

            return golfUser;
        }
        public async Task<bool> SaveGolfUserAsync(GolfUser user, bool isNewItem = false)
        {
            restClient = new GolfUsersRestClient<GolfUser>();

            var success = await restClient.PostAsync(user);

            return true;
        }

        public async Task<bool> EditGolfUserAsync(int id, GolfUser user)
        {
            restClient = new GolfUsersRestClient<GolfUser>();

            var success = await restClient.PutAsync(id, user);

            return success;
        }
    }
}
