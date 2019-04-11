using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Services
{
    public class GolfScoreServices
    {
        public List<GolfScore> GetGolfScores()
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
    }
}
