﻿using Plugin.ExternalMaps;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class DisplayItemPageViewModel : ViewModelBase
	{
        public DelegateCommand BackButtonClickedCommand { get; set; }
        public DelegateCommand ActionButtonClickedCommand { get; set; }

        private bool showingLocation = false;
        private Location currentLocation = null;
        private Sawg currentSwag = null;


        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name,value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private int _points;
        public int Points
        {
            get => _points;
            set => SetProperty(ref _points,value);
        }

        private string _buttonText;
        public string ButtonText
        {
            get => _buttonText;
            set => SetProperty(ref _buttonText,value);
        }

        public DisplayItemPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            BackButtonClickedCommand = new DelegateCommand(BackButtonClicked);
            ActionButtonClickedCommand = new DelegateCommand(ActionButtonClicked);
        }

        private async void ActionButtonClicked()
        {
            if (showingLocation)
            {
                if (currentLocation != null && currentLocation.GPSCoordinates!=null)
                {
                    await CrossExternalMaps.Current.NavigateTo(currentLocation.Name, currentLocation.GPSCoordinates.Item1, currentLocation.GPSCoordinates.Item2);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Problem","Unable To open location.","Ok");
                }
            }
            else
            {
                Console.WriteLine("Redeem Points Here!");
            }
        }

        private void BackButtonClicked()
        {
            NavigationService.GoBackAsync();
        }

        public override void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("LOCATION"))
            {
                Location location = (Location)parameters.SingleOrDefault(p => p.Key.Equals("LOCATION")).Value;
                Name = location.Name;
                Description = location.Description;
                Points = location.PointValue;
                ButtonText = "Open in Maps";
                currentLocation = location;
                showingLocation = true;
            }

            if (parameters.ContainsKey("SWAG"))
            {
                Sawg swag = (Sawg)parameters.SingleOrDefault(p => p.Key.Equals("SWAG")).Value;
                Name = swag.Name;
                Description = swag.Description;
                Points = swag.PointsCost;
                ButtonText = "Redeem Points";
                currentSwag = swag;
            }
        }
    }
}