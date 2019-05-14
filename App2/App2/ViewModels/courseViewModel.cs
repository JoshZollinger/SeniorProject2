using App2.Models;
using App2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App2.ViewModels
{
    public class courseViewModel : INotifyPropertyChanged
    {
        private List<GolfCourse> golfCoursesList;
        public List<GolfCourse> GolfCoursesList
        {
            get { return golfCoursesList; }
            set
            {
                golfCoursesList = value;
                OnPropertyChanged();
            }
        }
        public courseViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            var golfCourseServices = new GolfCourseServices();

            GolfCoursesList = await golfCourseServices.GetGolfCoursesAsync();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
