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
    public class eventViewModel : INotifyPropertyChanged
    {
        private List<GolfEvent> golfEventsList;

        public List<GolfEvent> GolfEventsList
        {
            get { return golfEventsList; }
            set
            {
                golfEventsList = value;
                OnPropertyChanged();
            }
        }

        public eventViewModel()
        {
            InitializeDataAsync();
        }

        private async Task InitializeDataAsync()
        {

            var golfEventServices = new GolfEventServices();

            GolfEventsList = await golfEventServices.GetGolfEventsAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
