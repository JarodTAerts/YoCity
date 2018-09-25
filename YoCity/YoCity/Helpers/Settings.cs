using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using YoCity.Models;

namespace YoCity.Helpers
{
    class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        #endregion


        public static User CurrentUser
        {
            get
            {
                return JsonConvert.DeserializeObject<User>(AppSettings.GetValueOrDefault("CurrentUser", ""));
            }
            set
            {
                AppSettings.AddOrUpdateValue("CurrentUser", JsonConvert.SerializeObject(value));
            }
        }

        public static bool StayLoggedIn
        {
            get { return AppSettings.GetValueOrDefault("StayLoggedIn", true); }
            set { AppSettings.AddOrUpdateValue("StayLoggedIn", value); }
        }
    }
}
