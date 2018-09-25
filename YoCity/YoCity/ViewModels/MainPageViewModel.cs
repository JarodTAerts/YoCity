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
        public DelegateCommand LoginButtonClickedCommand { get; set; }

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
       

        public MainPageViewModel(INavigationService navigationService) 
            : base (navigationService)
        {
            Title = "Main Page";
            LoginButtonClickedCommand = new DelegateCommand(LoginButtonClicked);
            ShowError = false;
            UsernameText = "";
            PasswordText = "";
        }

        private void LoginButtonClicked()
        {
            User attemptedLogin = APIHelper.Login(UsernameText, PasswordText);
            if ( attemptedLogin != null)
            {
                Settings.CurrentUser = attemptedLogin;
                NavigationService.NavigateAsync("NavigationPage/MasterTabbedPage");
            }
            else
            {
                ShowError = true;
            }
        }
    }
}
