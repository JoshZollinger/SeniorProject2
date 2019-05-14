using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class GolfScore
    {   
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
        public double Par3Avg { get; set; }
        public double Par4Avg { get; set; }
        public double Par5Avg { get; set; }
        public int Par3Count { get; set; }
        public int Par4Count { get; set; }
        public int Par5Count { get; set; }
        public int eagleCount { get; set; }
        public int birdieCount { get; set; }
        public int parCount { get; set; }
        public int bogeyCount { get; set; }
        public int otherCount { get; set; }
        public bool GIR1 { get; set; }
        public bool GIR2 { get; set; }
        public bool GIR3 { get; set; }
        public bool GIR4 { get; set; }
        public bool GIR5 { get; set; }
        public bool GIR6 { get; set; }
        public bool GIR7 { get; set; }
        public bool GIR8 { get; set; }
        public bool GIR9 { get; set; }
        public bool GIR10 { get; set; }
        public bool GIR11 { get; set; }
        public bool GIR12 { get; set; }
        public bool GIR13 { get; set; }
        public bool GIR14 { get; set; }
        public bool GIR15 { get; set; }
        public bool GIR16 { get; set; }
        public bool GIR17 { get; set; }
        public bool GIR18 { get; set; }
        public bool fairway1 { get; set; }
        public bool fairway2 { get; set; }
        public bool fairway3 { get; set; }
        public bool fairway4 { get; set; }
        public bool fairway5 { get; set; }
        public bool fairway6 { get; set; }
        public bool fairway7 { get; set; }
        public bool fairway8 { get; set; }
        public bool fairway9 { get; set; }
        public bool fairway10 { get; set; }
        public bool fairway11 { get; set; }
        public bool fairway12 { get; set; }
        public bool fairway13 { get; set; }
        public bool fairway14 { get; set; }
        public bool fairway15 { get; set; }
        public bool fairway16 { get; set; }
        public bool fairway17 { get; set; }
        public bool fairway18 { get; set; }
        public int Putts1 { get; set; }
        public int Putts2 { get; set; }
        public int Putts3 { get; set; }
        public int Putts4 { get; set; }
        public int Putts5 { get; set; }
        public int Putts6 { get; set; }
        public int Putts7 { get; set; }
        public int Putts8 { get; set; }
        public int Putts9 { get; set; }
        public int Putts10 { get; set; }
        public int Putts11 { get; set; }
        public int Putts12 { get; set; }
        public int Putts13 { get; set; }
        public int Putts14 { get; set; }
        public int Putts15 { get; set; }
        public int Putts16 { get; set; }
        public int Putts17 { get; set; }
        public int Putts18 { get; set; }
        public int totalStrokes { get; set; }

        public GolfScore()
        {
               
        }

        public GolfScore(int hole1, int hole2, int hole3, int hole4, int hole5, int hole6, int hole7, int hole8, int hole9, int hole10, int hole11, int hole12, int hole13, int hole14, int hole15, int hole16, int hole17, int hole18)
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
        }

        public GolfScore(int hole1, int hole2, int hole3, int hole4, int hole5, int hole6, int hole7, int hole8, int hole9, int hole10, int hole11, int hole12,
            int hole13, int hole14, int hole15, int hole16, int hole17, int hole18, int roundNum, DateTime scoreDate, string firstName, string lastName, string courseName, 
            string eventName, double par3Avg, double par4Avg, double par5Avg, int par3Count, int par4Count, int par5Count, int eagleCount, int birdieCount, int parCount, 
            int bogeyCount, int otherCount, bool gIR1, bool gIR2, bool gIR3, bool gIR4, bool gIR5, bool gIR6, bool gIR7, bool gIR8, bool gIR9, bool gIR10, bool gIR11, 
            bool gIR12, bool gIR13, bool gIR14, bool gIR15, bool gIR16, bool gIR17, bool gIR18, bool fairway1, bool fairway2, bool fairway3, bool fairway4, bool fairway5, 
            bool fairway6, bool fairway7, bool fairway8, bool fairway9, bool fairway10, bool fairway11, bool fairway12, bool fairway13, bool fairway14, bool fairway15, 
            bool fairway16, bool fairway17, bool fairway18, int putts1, int putts2, int putts3, int putts4, int putts5, int putts6, int putts7, int putts8, int putts9, 
            int putts10, int putts11, int putts12, int putts13, int putts14, int putts15, int putts16, int putts17, int putts18)
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
            Par3Avg = par3Avg;
            Par4Avg = par4Avg;
            Par5Avg = par5Avg;
            Par3Count = par3Count;
            Par4Count = par4Count;
            Par5Count = par5Count;
            this.eagleCount = eagleCount;
            this.birdieCount = birdieCount;
            this.parCount = parCount;
            this.bogeyCount = bogeyCount;
            this.otherCount = otherCount;
            GIR1 = gIR1;
            GIR2 = gIR2;
            GIR3 = gIR3;
            GIR4 = gIR4;
            GIR5 = gIR5;
            GIR6 = gIR6;
            GIR7 = gIR7;
            GIR8 = gIR8;
            GIR9 = gIR9;
            GIR10 = gIR10;
            GIR11 = gIR11;
            GIR12 = gIR12;
            GIR13 = gIR13;
            GIR14 = gIR14;
            GIR15 = gIR15;
            GIR16 = gIR16;
            GIR17 = gIR17;
            GIR18 = gIR18;
            this.fairway1 = fairway1;
            this.fairway2 = fairway2;
            this.fairway3 = fairway3;
            this.fairway4 = fairway4;
            this.fairway5 = fairway5;
            this.fairway6 = fairway6;
            this.fairway7 = fairway7;
            this.fairway8 = fairway8;
            this.fairway9 = fairway9;
            this.fairway10 = fairway10;
            this.fairway11 = fairway11;
            this.fairway12 = fairway12;
            this.fairway13 = fairway13;
            this.fairway14 = fairway14;
            this.fairway15 = fairway15;
            this.fairway16 = fairway16;
            this.fairway17 = fairway17;
            this.fairway18 = fairway18;
            Putts1 = putts1;
            Putts2 = putts2;
            Putts3 = putts3;
            Putts4 = putts4;
            Putts5 = putts5;
            Putts6 = putts6;
            Putts7 = putts7;
            Putts8 = putts8;
            Putts9 = putts9;
            Putts10 = putts10;
            Putts11 = putts11;
            Putts12 = putts12;
            Putts13 = putts13;
            Putts14 = putts14;
            Putts15 = putts15;
            Putts16 = putts16;
            Putts17 = putts17;
            Putts18 = putts18;
        }
    }
}
