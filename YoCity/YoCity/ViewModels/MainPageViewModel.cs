using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region Delegates and Bindable Properties
        public DelegateCommand LoginButtonClickedCommand { get; set; }
        public DelegateCommand CreateAccountButtonClickedCommand { get; set; }

        private string _usernameText;
        public string UsernameText
        {
            get { return _usernameText; }
            set { SetProperty(ref _usernameText, value); }

        }

        private string _passwordText;
        public string PasswordText
        {
            get { return _passwordText; }
            set { SetProperty(ref _passwordText, value); }
        }

        private bool _showError;
        public bool ShowError
        { 
            get { return _showError; }
            set { SetProperty(ref _showError, value); }
        }

        private bool _autoLogin;
        public bool AutoLogin
        {
            get { return _autoLogin; }
            set { Settings.StayLoggedIn = value; SetProperty(ref _autoLogin, value); }
        }
        #endregion

        #region Constructor
        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            LoginButtonClickedCommand = new DelegateCommand(LoginButtonClicked);
            CreateAccountButtonClickedCommand = new DelegateCommand(CreateAccountButtonClicked);
            ShowError = false;
            UsernameText = "";
            PasswordText = "";
            AutoLogin = Settings.StayLoggedIn;
        }
        #endregion

        #region Command Functions
        /// <summary>
        /// Function that goes to the create account page when the create account button is hit
        /// </summary>
        private void CreateAccountButtonClicked()
        {
            NavigationService.NavigateAsync("CreateAccountPage", useModalNavigation: true);
        }

        /// <summary>
        /// Function that handles the login process when that button is hit
        /// </summary>
        private void LoginButtonClicked()
        {
            // Attempt login through API
            User attemptedLogin = APIHelper.Login(UsernameText, PasswordText);
            // If successful go into main part of app, otherwise show error
            if ( attemptedLogin != null)
            {
                Settings.CurrentUser = attemptedLogin;
                NavigationService.NavigateAsync("MasterTabbedPage");
            }
            else
            {
                ShowError = true;
            }
        }
        #endregion
    }
}
