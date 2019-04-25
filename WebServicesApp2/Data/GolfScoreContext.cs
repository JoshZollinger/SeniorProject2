using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebServicesApp2.Models
{
    public class GolfScoreContext : DbContext
    {
        public GolfScoreContext (DbContextOptions<GolfScoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebServicesApp2.Models.GolfScore> GolfScore { get; set; }
    }
}
