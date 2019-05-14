using App2.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    class DataOperator
    {
        public double par3Avg { get; set; }
        public double par4Avg { get; set; }
        public double par5Avg { get; set; }
        public int par3Count { get; set; }
        public int par4Count { get; set; }
        public int par5Count { get; set; }
        public int eagleCount { get; set; }
        public int birdieCount { get; set; }
        public int parCount { get; set; }
        public int bogeyCount { get; set; }
        public int otherCount { get; set; }

        public DataOperator(List<GolfCourse> list, string selectedCourse, GolfScore score)
        {
            
            foreach(GolfCourse course in list)
            {
                if(course.courseName == selectedCourse)
                {
                    this.par3Avg = Par3AvgCalc(course, score);
                    this.par4Avg = Par4AvgCalc(course, score);
                    this.par5Avg = Par5AvgCalc(course, score);
                    this.par3Count = Par3CountCalc(course, score);
                    this.par4Count = Par4CountCalc(course, score);
                    this.par5Count = Par5CountCalc(course, score);
                    this.eagleCount = eagleCountCalc(course, score);
                    this.birdieCount = birdieCountCalc(course, score);
                    this.parCount = parCountCalc(course, score);
                    this.bogeyCount = bogeyCountCalc(course, score);
                    this.otherCount = otherCountCalc(course, score);
                    break;
                }
            }
        }

        public static double Par3AvgCalc(GolfCourse course, GolfScore score)
        {
            double sum = 0;
            if(course.Par1 == 3)
            {
                sum += score.Hole1;
            }
            if (course.Par2 == 3)
            {
                sum += score.Hole2;
            }
            if (course.Par3 == 3)
            {
                sum += score.Hole3;
            }
            if (course.Par4 == 3)
            {
                sum += score.Hole4;
            }
            if (course.Par5 == 3)
            {
                sum += score.Hole5;
            }
            if (course.Par6 == 3)
            {
                sum += score.Hole6;
            }
            if (course.Par7 == 3)
            {
                sum += score.Hole7;
            }
            if (course.Par8 == 3)
            {
                sum += score.Hole8;
            }
            if (course.Par9 == 3)
            {
                sum += score.Hole9;
            }
            if (course.Par10 == 3)
            {
                sum += score.Hole10;
            }
            if (course.Par11 == 3)
            {
                sum += score.Hole11;
            }
            if (course.Par12 == 3)
            {
                sum += score.Hole12;
            }
            if (course.Par13 == 3)
            {
                sum += score.Hole13;
            }
            if (course.Par14 == 3)
            {
                sum += score.Hole14;
            }
            if (course.Par15 == 3)
            {
                sum += score.Hole15;
            }
            if (course.Par16 == 3)
            {
                sum += score.Hole16;
            }
            if (course.Par17 == 3)
            {
                sum += score.Hole17;
            }
            if (course.Par18 == 3)
            {
                sum += score.Hole18;
            }
            double avg = (double) (sum / Par3CountCalc(course, score));
            return avg;
        }
        public static double Par4AvgCalc(GolfCourse course, GolfScore score)
        {
                double sum = 0;
                if (course.Par1 == 4)
                {
                    sum += score.Hole1;
                }
                if (course.Par2 == 4)
                {
                    sum += score.Hole2;
                }
                if (course.Par3 == 4)
                {
                    sum += score.Hole3;
                }
                if (course.Par4 == 4)
                {
                    sum += score.Hole4;
                }
                if (course.Par5 == 4)
                {
                    sum += score.Hole5;
                }
                if (course.Par6 == 4)
                {
                    sum += score.Hole6;
                }
                if (course.Par7 == 4)
                {
                    sum += score.Hole7;
                }
                if (course.Par8 == 4)
                {
                    sum += score.Hole8;
                }
                if (course.Par9 == 4)
                {
                    sum += score.Hole9;
                }
                if (course.Par10 == 4)
                {
                    sum += score.Hole10;
                }
                if (course.Par11 == 4)
                {
                    sum += score.Hole11;
                }
                if (course.Par12 == 4)
                {
                    sum += score.Hole12;
                }
                if (course.Par13 == 4)
                {
                    sum += score.Hole13;
                }
                if (course.Par14 == 4)
                {
                    sum += score.Hole14;
                }
                if (course.Par15 == 4)
                {
                    sum += score.Hole15;
                }
                if (course.Par16 == 4)
                {
                    sum += score.Hole16;
                }
                if (course.Par17 == 4)
                {
                    sum += score.Hole17;
                }
                if (course.Par18 == 4)
                {
                    sum += score.Hole18;
                }
                double avg = (double)(sum / Par4CountCalc(course, score));
                return avg;
            }
        public static double Par5AvgCalc(GolfCourse course, GolfScore score)
        {
                double sum = 0;
                if (course.Par1 == 5)
                {
                    sum += score.Hole1;
                }
                if (course.Par2 == 5)
                {
                    sum += score.Hole2;
                }
                if (course.Par3 == 5)
                {
                    sum += score.Hole3;
                }
                if (course.Par4 == 5)
                {
                    sum += score.Hole4;
                }
                if (course.Par5 == 5)
                {
                    sum += score.Hole5;
                }
                if (course.Par6 == 5)
                {
                    sum += score.Hole6;
                }
                if (course.Par7 == 5)
                {
                    sum += score.Hole7;
                }
                if (course.Par8 == 5)
                {
                    sum += score.Hole8;
                }
                if (course.Par9 == 5)
                {
                    sum += score.Hole9;
                }
                if (course.Par10 == 5)
                {
                    sum += score.Hole10;
                }
                if (course.Par11 == 5)
                {
                    sum += score.Hole11;
                }
                if (course.Par12 == 5)
                {
                    sum += score.Hole12;
                }
                if (course.Par13 == 5)
                {
                    sum += score.Hole13;
                }
                if (course.Par14 == 5)
                {
                    sum += score.Hole14;
                }
                if (course.Par15 == 5)
                {
                    sum += score.Hole15;
                }
                if (course.Par16 == 5)
                {
                    sum += score.Hole16;
                }
                if (course.Par17 == 5)
                {
                    sum += score.Hole17;
                }
                if (course.Par18 == 5)
                {
                    sum += score.Hole18;
                }
                double avg = (double) (sum / Par5CountCalc(course, score));
                return avg;
            }
        public static int Par3CountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if (course.Par1 == 3)
            {
                count++;
            }
            if (course.Par2 == 3)
            {
                count++;
            }
            if (course.Par3 == 3)
            {
                count++;
            }
            if (course.Par4 == 3)
            {
                count++;
            }
            if (course.Par5 == 3)
            {
                count++;
            }
            if (course.Par6 == 3)
            {
                count++;
            }
            if (course.Par7 == 3)
            {
                count++;
            }
            if (course.Par8 == 3)
            {
                count++;
            }
            if (course.Par9 == 3)
            {
                count++;
            }
            if (course.Par10 == 3)
            {
                count++;
            }
            if (course.Par11 == 3)
            {
                count++;
            }
            if (course.Par12 == 3)
            {
                count++;
            }
            if (course.Par13 == 3)
            {
                count++;
            }
            if (course.Par14 == 3)
            {
                count++;
            }
            if (course.Par15 == 3)
            {
                count++;
            }
            if (course.Par16 == 3)
            {
                count++;
            }
            if (course.Par17 == 3)
            {
                count++;
            }
            if (course.Par18 == 3)
            {
                count++; 
            }
            return count;
        }
        public static int Par4CountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if (course.Par1 == 4)
            {
                count++;
            }
            if (course.Par2 == 4)
            {
                count++;
            }
            if (course.Par3 == 4)
            {
                count++;
            }
            if (course.Par4 == 4)
            {
                count++;
            }
            if (course.Par5 == 4)
            {
                count++;
            }
            if (course.Par6 == 4)
            {
                count++;
            }
            if (course.Par7 == 4)
            {
                count++;
            }
            if (course.Par8 == 4)
            {
                count++;
            }
            if (course.Par9 == 4)
            {
                count++;
            }
            if (course.Par10 == 4)
            {
                count++;
            }
            if (course.Par11 == 4)
            {
                count++;
            }
            if (course.Par12 == 4)
            {
                count++;
            }
            if (course.Par13 == 4)
            {
                count++;
            }
            if (course.Par14 == 4)
            {
                count++;
            }
            if (course.Par15 == 4)
            {
                count++;
            }
            if (course.Par16 == 4)
            {
                count++;
            }
            if (course.Par17 == 4)
            {
                count++;
            }
            if (course.Par18 == 4)
            {
                count++;
            }
            return count;
        }
        public static int Par5CountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if (course.Par1 == 5)
            {
                count++;
            }
            if (course.Par2 == 5)
            {
                count++;
            }
            if (course.Par3 == 5)
            {
                count++;
            }
            if (course.Par4 == 5)
            {
                count++;
            }
            if (course.Par5 == 5)
            {
                count++;
            }
            if (course.Par6 == 5)
            {
                count++;
            }
            if (course.Par7 == 5)
            {
                count++;
            }
            if (course.Par8 == 5)
            {
                count++;
            }
            if (course.Par9 == 5)
            {
                count++;
            }
            if (course.Par10 == 5)
            {
                count++;
            }
            if (course.Par11 == 5)
            {
                count++;
            }
            if (course.Par12 == 5)
            {
                count++;
            }
            if (course.Par13 == 5)
            {
                count++;
            }
            if (course.Par14 == 5)
            {
                count++;
            }
            if (course.Par15 == 5)
            {
                count++;
            }
            if (course.Par16 == 5)
            {
                count++;
            }
            if (course.Par17 == 5)
            {
                count++;
            }
            if (course.Par18 == 5)
            {
                count++;
            }
            return count;
        }
        public static int eagleCountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if ((course.Par1 - score.Hole1) == 2)
            {
                count++;
            }
            if ((course.Par2 - score.Hole2) == 2)
            {
                count++;
            }
            if ((course.Par3 - score.Hole3) == 2)
            {
                count++;
            }
            if ((course.Par4 - score.Hole4) == 2)
            {
                count++;
            }
            if ((course.Par5 - score.Hole5) == 2)
            {
                count++;
            }
            if ((course.Par6 - score.Hole6) == 2)
            {
                count++;
            }
            if ((course.Par7 - score.Hole7) == 2)
            {
                count++;
            }
            if ((course.Par8 - score.Hole8) == 2)
            {
                count++;
            }
            if ((course.Par9 - score.Hole9) == 2)
            {
                count++;
            }
            if ((course.Par10 - score.Hole10) ==2)
            {
                count++;
            }
            if ((course.Par11 - score.Hole11) == 2)
            {
                count++;
            }
            if ((course.Par12 - score.Hole12) == 2)
            {
                count++;
            }
            if ((course.Par13 - score.Hole13) == 2)
            {
                count++;
            }
            if ((course.Par14 - score.Hole14) == 2)
            {
                count++;
            }
            if ((course.Par15 - score.Hole15) == 2)
            {
                count++;
            }
            if ((course.Par16 - score.Hole16) == 2)
            {
                count++;
            }
            if ((course.Par17 - score.Hole17) == 2)
            {
                count++;
            }
            if ((course.Par18 - score.Hole18) == 2)
            {
                count++;
            }
            return count;
        }
        public static int birdieCountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if ((course.Par1 - score.Hole1) == 1)
            {
                count++;
            }
            if ((course.Par2 - score.Hole2) == 1)
            {
                count++;
            }
            if ((course.Par3 - score.Hole3) == 1)
            {
                count++;
            }
            if ((course.Par4 - score.Hole4) == 1)
            {
                count++;
            }
            if ((course.Par5 - score.Hole5) == 1)
            {
                count++;
            }
            if ((course.Par6 - score.Hole6) == 1)
            {
                count++;
            }
            if ((course.Par7 - score.Hole7) == 1)
            {
                count++;
            }
            if ((course.Par8 - score.Hole8) == 1)
            {
                count++;
            }
            if ((course.Par9 - score.Hole9) == 1)
            {
                count++;
            }
            if ((course.Par10 - score.Hole10) == 1)
            {
                count++;
            }
            if ((course.Par11 - score.Hole11) == 1)
            {
                count++;
            }
            if ((course.Par12 - score.Hole12) == 1)
            {
                count++;
            }
            if ((course.Par13 - score.Hole13) == 1)
            {
                count++;
            }
            if ((course.Par14 - score.Hole14) == 1)
            {
                count++;
            }
            if ((course.Par15 - score.Hole15) == 1)
            {
                count++;
            }
            if ((course.Par16 - score.Hole16) == 1)
            {
                count++;
            }
            if ((course.Par17 - score.Hole17) == 1)
            {
                count++;
            }
            if ((course.Par18 - score.Hole18) == 1)
            {
                count++;
            }
            return count;
            
        }
        public static int parCountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if((course.Par1 - score.Hole1) == 0)
            {
                count++;
            }
            if ((course.Par2 - score.Hole2) == 0)
            {
                count++;
            }
            if ((course.Par3 - score.Hole3) == 0)
            {
                count++;
            }
            if ((course.Par4 - score.Hole4) == 0)
            {
                count++;
            }
            if ((course.Par5 - score.Hole5) == 0)
            {
                count++;
            }
            if ((course.Par6 - score.Hole6) == 0)
            {
                count++;
            }
            if ((course.Par7 - score.Hole7) == 0)
            {
                count++;
            }
            if ((course.Par8 - score.Hole8) == 0)
            {
                count++;
            }
            if ((course.Par9 - score.Hole9) == 0)
            {
                count++;
            }
            if ((course.Par10 - score.Hole10) == 0)
            {
                count++;
            }
            if ((course.Par11 - score.Hole11) == 0)
            {
                count++;
            }
            if ((course.Par12 - score.Hole12) == 0)
            {
                count++;
            }
            if ((course.Par13 - score.Hole13) == 0)
            {
                count++;
            }
            if ((course.Par14 - score.Hole14) == 0)
            {
                count++;
            }
            if ((course.Par15 - score.Hole15) == 0)
            {
                count++;
            }
            if ((course.Par16 - score.Hole16) == 0)
            {
                count++;
            }
            if ((course.Par17 - score.Hole17) == 0)
            {
                count++;
            }
            if ((course.Par18 - score.Hole18) == 0)
            {
                count++;
            }
            return count;
        }
        public static int bogeyCountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if ((course.Par1 - score.Hole1) == -1)
            {
                count++;
            }
            if ((course.Par2 - score.Hole2) == -1)
            {
                count++;
            }
            if ((course.Par3 - score.Hole3) == -1)
            {
                count++;
            }
            if ((course.Par4 - score.Hole4) == -1)
            {
                count++;
            }
            if ((course.Par5 - score.Hole5) == -1)
            {
                count++;
            }
            if ((course.Par6 - score.Hole6) == -1)
            {
                count++;
            }
            if ((course.Par7 - score.Hole7) == -1)
            {
                count++;
            }
            if ((course.Par8 - score.Hole8) == -1)
            {
                count++;
            }
            if ((course.Par9 - score.Hole9) == -1)
            {
                count++;
            }
            if ((course.Par10 - score.Hole10) == -1)
            {
                count++;
            }
            if ((course.Par11 - score.Hole11) == -1)
            {
                count++;
            }
            if ((course.Par12 - score.Hole12) == -1)
            {
                count++;
            }
            if ((course.Par13 - score.Hole13) == -1)
            {
                count++;
            }
            if ((course.Par14 - score.Hole14) == -1)
            {
                count++;
            }
            if ((course.Par15 - score.Hole15) == -1)
            {
                count++;
            }
            if ((course.Par16 - score.Hole16) == -1)
            {
                count++;
            }
            if ((course.Par17 - score.Hole17) == -1)
            {
                count++;
            }
            if ((course.Par18 - score.Hole18) == -1)
            {
                count++;
            }
            return count;
        }
        public static int otherCountCalc(GolfCourse course, GolfScore score)
        {
            int count = 0;
            if ((course.Par1 - score.Hole1) <= -2)
            {
                count++;
            }
            if ((course.Par2 - score.Hole2) <= -2)
            {
                count++;
            }
            if ((course.Par3 - score.Hole3) <= -2)
            {
                count++;
            }
            if ((course.Par4 - score.Hole4) <= -2)
            {
                count++;
            }
            if ((course.Par5 - score.Hole5) <= -2)
            {
                count++;
            }
            if ((course.Par6 - score.Hole6) <= -2)
            {
                count++;
            }
            if ((course.Par7 - score.Hole7) <= -2)
            {
                count++;
            }
            if ((course.Par8 - score.Hole8) <= -2)
            {
                count++;
            }
            if ((course.Par9 - score.Hole9) <= -2)
            {
                count++;
            }
            if ((course.Par10 - score.Hole10) <= -2)
            {
                count++;
            }
            if ((course.Par11 - score.Hole11) <= -2)
            {
                count++;
            }
            if ((course.Par12 - score.Hole12) <= -2)
            {
                count++;
            }
            if ((course.Par13 - score.Hole13) <= -2)
            {
                count++;
            }
            if ((course.Par14 - score.Hole14) <= -2)
            {
                count++;
            }
            if ((course.Par15 - score.Hole15) <= -2)
            {
                count++;
            }
            if ((course.Par16 - score.Hole16) <= -2)
            {
                count++;
            }
            if ((course.Par17 - score.Hole17) <= -2)
            {
                count++;
            }
            if ((course.Par18 - score.Hole18) <= -2)
            {
                count++;
            }
            return count;
        }
    }
}
