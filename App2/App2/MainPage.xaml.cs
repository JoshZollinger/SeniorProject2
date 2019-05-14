using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using CustomEntry;
using App2.Models;
using App2.Services;
using App2.Views;
using Newtonsoft.Json;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
        }

        // This method is used to tab through the MyEntry objects
        void MyEntry_Completed(object sender, EventArgs e)
        {
            var entry = sender as MyEntry; 
            var list = (entry.Parent.Parent as StackLayout).Children; //assumes a StackLayout
            var index = list.IndexOf(entry.Parent as StackLayout); // what if IndexOf returns -1?
            var nextIndex = (index + 2) > list.Count ? 0 : index + 2; //Go to first or next element in list?
            var next = list.ElementAt(nextIndex);
            var nextStackLayoutElements = (list.ElementAt(nextIndex) as StackLayout).Children;
            if (nextStackLayoutElements.Count > 1)
            {
                var nextEntry = nextStackLayoutElements.ElementAt(1);
                nextEntry?.Focus();
            }
            
        }

        private async void SubmitButton_Clicked(object sender, EventArgs e)
        {
            GolfCourseServices golfCourseService = new GolfCourseServices();
            List<GolfCourse> courseList = await golfCourseService.GetGolfCoursesAsync();
            GolfScore score = new GolfScore(Convert.ToInt32(Hole1Entry.Text), Convert.ToInt32(Hole2Entry.Text), Convert.ToInt32(Hole3Entry.Text), Convert.ToInt32(Hole4Entry.Text),
                Convert.ToInt32(Hole5Entry.Text), Convert.ToInt32(Hole6Entry.Text), Convert.ToInt32(Hole7Entry.Text), Convert.ToInt32(Hole8Entry.Text), Convert.ToInt32(Hole9Entry.Text),
                Convert.ToInt32(Hole10Entry.Text), Convert.ToInt32(Hole11Entry.Text), Convert.ToInt32(Hole12Entry.Text), Convert.ToInt32(Hole13Entry.Text), Convert.ToInt32(Hole14Entry.Text),
                Convert.ToInt32(Hole15Entry.Text), Convert.ToInt32(Hole16Entry.Text), Convert.ToInt32(Hole17Entry.Text), Convert.ToInt32(Hole18Entry.Text));
            // Use DataOperator to calculate advanced stats such as Par3Avg
            DataOperator data = new DataOperator(courseList, coursePicker.Items[coursePicker.SelectedIndex], score);
            // Finish setting score values
            score.roundNum = Convert.ToInt32(roundPicker.Items[roundPicker.SelectedIndex]);
            score.scoreDate = datePicker.Date;
            score.firstName = Application.Current.Properties["CurrentFirstName"].ToString();
            score.lastName = Application.Current.Properties["CurrentLastName"].ToString();
            score.courseName = coursePicker.Items[coursePicker.SelectedIndex];
            score.eventName = eventPicker.Items[eventPicker.SelectedIndex];
            score.Par3Avg = Math.Round(data.par3Avg, 2, MidpointRounding.AwayFromZero);
            score.Par4Avg = Math.Round(data.par4Avg, 2, MidpointRounding.AwayFromZero);
            score.Par5Avg = Math.Round(data.par5Avg, 2, MidpointRounding.AwayFromZero);
            score.Par3Count = data.par3Count;
            score.Par4Count = data.par4Count;
            score.Par5Count = data.par5Count;
            score.eagleCount = data.eagleCount;
            score.birdieCount = data.birdieCount;
            score.parCount = data.parCount;
            score.bogeyCount = data.bogeyCount;
            score.otherCount = data.otherCount;
            score.GIR1 = GIR1Switch.IsToggled;
            score.GIR2 = GIR2Switch.IsToggled;
            score.GIR3 = GIR3Switch.IsToggled;
            score.GIR4 = GIR4Switch.IsToggled;
            score.GIR5 = GIR5Switch.IsToggled;
            score.GIR6 = GIR6Switch.IsToggled;
            score.GIR7 = GIR7Switch.IsToggled;
            score.GIR8 = GIR8Switch.IsToggled;
            score.GIR9 = GIR9Switch.IsToggled;
            score.GIR10 = GIR10Switch.IsToggled;
            score.GIR11 = GIR11Switch.IsToggled;
            score.GIR12 = GIR12Switch.IsToggled;
            score.GIR13 = GIR13Switch.IsToggled;
            score.GIR14 = GIR14Switch.IsToggled;
            score.GIR15 = GIR15Switch.IsToggled;
            score.GIR16 = GIR16Switch.IsToggled;
            score.GIR17 = GIR17Switch.IsToggled;
            score.GIR18 = GIR18Switch.IsToggled;
            score.fairway1 = FairwaySwitch1.IsToggled;
            score.fairway2 = FairwaySwitch2.IsToggled;
            score.fairway3 = FairwaySwitch3.IsToggled;
            score.fairway4 = FairwaySwitch4.IsToggled;
            score.fairway5 = FairwaySwitch5.IsToggled;
            score.fairway6 = FairwaySwitch6.IsToggled;
            score.fairway7 = FairwaySwitch7.IsToggled;
            score.fairway8 = FairwaySwitch8.IsToggled;
            score.fairway9 = FairwaySwitch9.IsToggled;
            score.fairway10 = FairwaySwitch10.IsToggled;
            score.fairway11 = FairwaySwitch11.IsToggled;
            score.fairway12 = FairwaySwitch12.IsToggled;
            score.fairway13 = FairwaySwitch13.IsToggled;
            score.fairway14 = FairwaySwitch14.IsToggled;
            score.fairway15 = FairwaySwitch15.IsToggled;
            score.fairway16 = FairwaySwitch16.IsToggled;
            score.fairway17 = FairwaySwitch17.IsToggled;
            score.fairway18 = FairwaySwitch18.IsToggled;
            
            

            
            GolfScoreServices service = new GolfScoreServices();
            await service.SaveGolfScoreAsync(score);
            
        }
    }


}


