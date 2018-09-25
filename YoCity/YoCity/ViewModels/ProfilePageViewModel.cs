using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using YoCity.Helpers;

namespace YoCity.ViewModels
{
	public class ProfilePageViewModel : BindableBase
	{
        private int _pointsValue;
        public int PointsValue
        {
            get { return _pointsValue; }
            set { SetProperty(ref _pointsValue, value); }
        }

        private string _rankText;
        public string RankText
        {
            get { return _rankText; }
            set { SetProperty(ref _rankText, value); }
        }

        private string _usernameText;
        public string UsernameText
        {
            get { return _usernameText; }
            set { SetProperty(ref _usernameText, value); }
        }

        public ProfilePageViewModel()
        {
            PointsValue = Settings.CurrentUser.Points;
            RankText = Settings.CurrentUser.Rank+"th";
            UsernameText = Settings.CurrentUser.UserName;
        }
	}
}
