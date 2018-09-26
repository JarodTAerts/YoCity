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
            NavigationService.NavigateAsync("SettingsPage", useModalNavigation: true);
        }

        private void LogoutButtonClicked()
        {
            //TODO: Make this actually clear the navigation stack somehow so there is no residual pages left 
            Settings.CurrentUser = null;          
            NavigationService.NavigateAsync("MainPage"); 
        }
    }
}
