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
    public class scoreViewModel : INotifyPropertyChanged
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

        public scoreViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {
            var golfScoreServices = new GolfScoreServices();

            GolfScoresList = await golfScoreServices.GetGolfScoresAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
