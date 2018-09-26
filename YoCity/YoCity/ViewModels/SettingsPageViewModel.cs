using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using YoCity.Helpers;

namespace YoCity.ViewModels
{
	public class SettingsPageViewModel : ViewModelBase
	{
        #region Delegates and Bindable Properties
        public DelegateCommand BackButtonClickedCommand { get; set; }

        private bool _autoLogin;
        public bool AutoLogin
        {
            get { return _autoLogin; }
            set { Settings.StayLoggedIn = value; SetProperty(ref _autoLogin, value); }
        }
        #endregion

        #region Constructor
        public SettingsPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            BackButtonClickedCommand = new DelegateCommand(BackButtonClicked);
        }
        #endregion

        #region Command Functions
        private void BackButtonClicked()
        {
            NavigationService.GoBackAsync();
        }
        #endregion
    }
}
