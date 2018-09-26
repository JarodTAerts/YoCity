using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class ListMapPageViewModel : BindableBase
	{
        private ObservableCollection<Location> _locationList;
        public ObservableCollection<Location> LocationList
        {
            get { return _locationList; }
            set { SetProperty(ref _locationList, value); }
        }

        public ListMapPageViewModel()
        {
            LocationList = APIHelper.GetLocations();
        }
	}
}
