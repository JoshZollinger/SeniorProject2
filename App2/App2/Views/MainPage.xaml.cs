using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Xamarin.Forms;
using CustomEntry;


namespace App2
{
    public partial class MainPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");

        public MainPage()
        {
            InitializeComponent();
            

        }

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
    }


}


