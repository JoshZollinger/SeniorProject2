using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class GolfUser
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool isNewUser { get; set; }

        public GolfUser(int id, string firstName, string lastName, string userName, string password, bool isNewUser)
        {
            this.Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.password = password;
            this.isNewUser = isNewUser;
        }
    }

    
}
