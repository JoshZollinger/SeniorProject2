using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServicesApp3.Models
{
    public class GolfUser
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool isNewUser { get; set; }
    }
}