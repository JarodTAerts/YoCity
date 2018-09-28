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
            //Get locations, might move this to OnNavigatingTo or something when it is actually getting things from the API
            LocationList = APIHelper.GetLocations();
        }
        #endregion

        /// <summary>
        /// Function that will open up the display item page showing the location that is selected
        /// </summary>
        private async void ShowLocation()
        {
            if (SelectedLocation != null)
            {
                //Have to set the selected location to a temp and then null it so it isnt selected when user comes back to this page
                Location sendLocation = SelectedLocation;
                SelectedLocation = null;
                NavigationParameters navParams = new NavigationParameters();
                navParams.Add("LOCATION",sendLocation);
                await NavigationService.NavigateAsync("DisplayItemPage",navParams);
            }
        }

    }
}
