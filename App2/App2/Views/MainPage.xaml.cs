using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using CustomEntry;
using App2.Models;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();
            

        }

        // This method is used to tab through the MyEntry objects
        void MyEntry_Completed(object sender, EventArgs e)
        {
            var entry = sender as MyEntry; // .. and check for null
            var list = (entry.Parent.Parent as StackLayout).Children; //assumes a StackLayout
            var index = list.IndexOf(entry.Parent as StackLayout); // what if IndexOf returns -1?
            var nextIndex = (index + 1) > list.Count ? 0 : index + 1; //first or next element?
            var next = list.ElementAt(nextIndex);
            var nextStackLayoutElements = (list.ElementAt(nextIndex) as StackLayout).Children;
            if (nextStackLayoutElements.Count > 1)
            {
                var nextEntry = nextStackLayoutElements.ElementAt(1);
                nextEntry?.Focus();
            }


        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            DateTime testDate = new DateTime(2005, 2, 3);
            GolfScore score = new GolfScore(Convert.ToInt32(Hole1Entry.Text), Convert.ToInt32(Hole2Entry.Text), Convert.ToInt32(Hole3Entry.Text), Convert.ToInt32(Hole4Entry.Text),
                Convert.ToInt32(Hole5Entry.Text), Convert.ToInt32(Hole6Entry.Text), Convert.ToInt32(Hole7Entry.Text), Convert.ToInt32(Hole8Entry.Text), Convert.ToInt32(Hole9Entry.Text),
                Convert.ToInt32(Hole10Entry.Text), Convert.ToInt32(Hole11Entry.Text), Convert.ToInt32(Hole12Entry.Text), Convert.ToInt32(Hole13Entry.Text), Convert.ToInt32(Hole14Entry.Text),
                Convert.ToInt32(Hole15Entry.Text), Convert.ToInt32(Hole16Entry.Text), Convert.ToInt32(Hole17Entry.Text), Convert.ToInt32(Hole18Entry.Text), 1, testDate, "Josh", "Zollinger", "TestCourse", "TestEvent");

        }
    }


}


