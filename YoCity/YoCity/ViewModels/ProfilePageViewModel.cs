using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class ProfilePageViewModel : ViewModelBase
    {
        public DelegateCommand LogoutButtonClickedCommand { get; set; }
        public DelegateCommand SettingsButtonClickedCommand { get; set; }

        private User _currentUser;
        public User CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }


        public ProfilePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            CurrentUser = Settings.CurrentUser;
            LogoutButtonClickedCommand = new DelegateCommand(LogoutButtonClicked);
            SettingsButtonClickedCommand = new DelegateCommand(SettingsButtonClicked);
        }

        private void SettingsButtonClicked()
        {
            Console.WriteLine("Settings Button Clicked");
        }

        private void LogoutButtonClicked()
        {
            Settings.CurrentUser = null;          
            NavigationService.NavigateAsync("MainPage"); 
        }
    }
}
