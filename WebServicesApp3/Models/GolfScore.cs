using System;
using System.Collections.Generic;
using System.Text;

namespace WebServicesApp3.Models
{
    public class GolfScore
    {
        public int Id { get; set; }
        public int Hole1 { get; set; }
        public int Hole2 { get; set; }
        public int Hole3 { get; set; }
        public int Hole4 { get; set; }
        public int Hole5 { get; set; }
        public int Hole6 { get; set; }
        public int Hole7 { get; set; }
        public int Hole8 { get; set; }
        public int Hole9 { get; set; }
        public int Hole10 { get; set; }
        public int Hole11 { get; set; }
        public int Hole12 { get; set; }
        public int Hole13 { get; set; }
        public int Hole14 { get; set; }
        public int Hole15 { get; set; }
        public int Hole16 { get; set; }
        public int Hole17 { get; set; }
        public int Hole18 { get; set; }
        public int roundNum { get; set; }
        public DateTime scoreDate { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string courseName { get; set; }
        public string eventName { get; set; }

        public GolfScore()
        {
               
        }

        public GolfScore(int hole1, int hole2, int hole3, int hole4, int hole5, int hole6, int hole7, int hole8, int hole9, int hole10, int hole11, int hole12, int hole13, int hole14, int hole15, int hole16, int hole17, int hole18, int roundNum, DateTime scoreDate, string firstName, string lastName, string courseName, string eventName)
        {
            Hole1 = hole1;
            Hole2 = hole2;
            Hole3 = hole3;
            Hole4 = hole4;
            Hole5 = hole5;
            Hole6 = hole6;
            Hole7 = hole7;
            Hole8 = hole8;
            Hole9 = hole9;
            Hole10 = hole10;
            Hole11 = hole11;
            Hole12 = hole12;
            Hole13 = hole13;
            Hole14 = hole14;
            Hole15 = hole15;
            Hole16 = hole16;
            Hole17 = hole17;
            Hole18 = hole18;
            this.roundNum = roundNum;
            this.scoreDate = scoreDate; 
            this.firstName = firstName;
            this.lastName = lastName;
            this.courseName = courseName;
            this.eventName = eventName;
        }
    }
}
