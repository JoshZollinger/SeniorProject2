using App2.Models;
using App2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<GolfScore> golfScoresList;

        public List<GolfScore> GolfScoresList
        {
            get { return golfScoresList; }
            set
            {
                golfScoresList = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            var GolfScoreServices = new GolfScoreServices();

            GolfScoresList = GolfScoreServices.GetGolfScore();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
