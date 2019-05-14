using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class GolfEvent
    {
        public int Id { get; set; }
        public string eventName { get; set; }
        public DateTime startDate { get; set; }    
        public DateTime endDate { get; set; }
        public int numRounds { get; set; }

        public GolfEvent()
        {

        }
        
        public GolfEvent(int id, string eventName, DateTime startDate, DateTime endDate, int numRounds)
        {
            Id = id;
            this.eventName = eventName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.numRounds = numRounds;
        }

        public GolfEvent(string eventName, DateTime startDate, DateTime endDate, int numRounds)
        {
            this.eventName = eventName;
            this.startDate = startDate;
            this.endDate = endDate;
            this.numRounds = numRounds;
        }

        // Ctor without Id

    }
}
