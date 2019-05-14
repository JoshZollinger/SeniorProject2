using App2.Models;
using App2.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App2.Services
{
    public class GolfCourseServices
    {
        GolfCourseRestClient<GolfCourse> restClient;

        public async Task<List<GolfCourse>> GetGolfCoursesAsync()
        {
            restClient = new GolfCourseRestClient<GolfCourse>();

            var golfCoursesList = await restClient.GetAsync();

            return golfCoursesList;
        }
    }
}
