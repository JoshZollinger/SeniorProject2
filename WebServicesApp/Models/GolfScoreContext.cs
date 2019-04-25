using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebServicesApp.Models;

namespace WebServicesApp.Models
{
    public class GolfScoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GolfScoreContext() : base("name=MainDatabase")
        {
            Database.SetInitializer<GolfScoreContext>(null);
        }

        public System.Data.Entity.DbSet<App2.Models.GolfScore> GolfScore { get; set; }
    }
}
