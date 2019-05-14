using System;
using System.Collections.Generic;
using System.Text;

namespace WebServicesApp3.Models
{
    public class GolfCourse
    {
        public int Id { get; set; }
        public int Par1 { get; set; }
        public int Par2 { get; set; }
        public int Par3 { get; set; }
        public int Par4 { get; set; }
        public int Par5 { get; set; }
        public int Par6 { get; set; }
        public int Par7 { get; set; }
        public int Par8 { get; set; }
        public int Par9 { get; set; }
        public int Par10 { get; set; }
        public int Par11 { get; set; }
        public int Par12 { get; set; }
        public int Par13 { get; set; }
        public int Par14 { get; set; }
        public int Par15 { get; set; }
        public int Par16 { get; set; }
        public int Par17 { get; set; }
        public int Par18 { get; set; }
        public string courseName { get; set; }

        public GolfCourse()
        {
        }

        public GolfCourse(int par1, int par2, int par3, int par4, int par5, int par6, int par7, int par8, int par9, int par10, int par11, int par12, int par13, int par14, int par15, int par16, int par17, int par18, string courseName)
        {
            Par1 = par1;
            Par2 = par2;
            Par3 = par3;
            Par4 = par4;
            Par5 = par5;
            Par6 = par6;
            Par7 = par7;
            Par8 = par8;
            Par9 = par9;
            Par10 = par10;
            Par11 = par11;
            Par12 = par12;
            Par13 = par13;
            Par14 = par14;
            Par15 = par15;
            Par16 = par16;
            Par17 = par17;
            Par18 = par18;
            this.courseName = courseName;
        }
    }
}
