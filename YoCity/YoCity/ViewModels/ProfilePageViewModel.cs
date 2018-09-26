using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using YoCity.Helpers;
using YoCity.Models;

namespace YoCity.ViewModels
{
	public class ProfilePageViewModel : BindableBase
	{
        private User _currentUser;
        public User CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }


        public ProfilePageViewModel()
        {
            CurrentUser = Settings.CurrentUser;
        }
	}
}
