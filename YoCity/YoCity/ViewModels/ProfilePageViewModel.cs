using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class ProfilePageViewModel : ViewModelBase
    {
        #region Delegates and Bindable Properties
        public DelegateCommand LogoutButtonClickedCommand { get; set; }
        public DelegateCommand SettingsButtonClickedCommand { get; set; }

        private User _currentUser;
        public User CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }
        #endregion

        #region Constructor
        public ProfilePageViewModel(INavigationService navigationService) : base(navigationService)
        {
            LogoutButtonClickedCommand = new DelegateCommand(LogoutButtonClicked);
            SettingsButtonClickedCommand = new DelegateCommand(SettingsButtonClicked);
        }
        #endregion

        #region Command Functions
        /// <summary>
        /// Functiono to go to setting page when the settings button is hit
        /// </summary>
        private void SettingsButtonClicked()
        {
            NavigationService.NavigateAsync("SettingsPage", useModalNavigation: true);
        }

        /// <summary>
        /// Function to logout of the app when the button is hit
        /// </summary>
        private async void LogoutButtonClicked()
        {
            Settings.CurrentUser = null;
            bool logout=await Application.Current.MainPage.DisplayAlert("Logout","Are you sure you want to log out?","Yes","No");
            if (logout)
            {
                HelperFunctions.SetDarkMode();
                await NavigationService.NavigateAsync("MainPage");
            }
        }
        #endregion



        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            base.OnNavigatingTo(parameters);
            CurrentUser = Settings.CurrentUser;
        }

        
    }
}
