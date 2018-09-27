using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class ListMapPageViewModel : ViewModelBase
	{
        #region Delegates and Bindable Properties
        //Attempt at making proper font size, failed
        public static double Heading = Device.GetNamedSize(NamedSize.Large, typeof(Label))*1.2;

        private ObservableCollection<Location> _locationList;
        public ObservableCollection<Location> LocationList
        {
            get { return _locationList; }
            set { SetProperty(ref _locationList, value); }
        }

        private Location _selectedLocation;
        public Location SelectedLocation
        {
            get => _selectedLocation;
            set
            {
                SetProperty(ref _selectedLocation,value);
                ShowLocation();
            }
        }
        #endregion

        #region Constructor
        public ListMapPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            LocationList = APIHelper.GetLocations();
        }
        #endregion

        private async void ShowLocation()
        {
            if (SelectedLocation != null)
            {
                Location sendLocation = SelectedLocation;
                SelectedLocation = null;
                NavigationParameters navParams = new NavigationParameters();
                navParams.Add("LOCATION",sendLocation);
                await NavigationService.NavigateAsync("DisplayItemPage",navParams);
            }
        }

    }
}
