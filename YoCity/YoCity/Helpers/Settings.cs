using Newtonsoft.Json;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using YoCity.Models;

namespace YoCity.Helpers
{
    /// <summary>
    /// Class that holds persistant offline settings for the app
    /// </summary>
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

        /// <summary>
        /// Setting that stores the current user that is logged into the app
        /// </summary>
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

        /// <summary>
        /// Setting that stores whether the app should make the user log in each time they open the app
        /// </summary>
        public static bool StayLoggedIn
        {
            get { return AppSettings.GetValueOrDefault("StayLoggedIn", true); }
            set { AppSettings.AddOrUpdateValue("StayLoggedIn", value); }
        }

        public static bool DarkMode
        {
            get { return AppSettings.GetValueOrDefault("DarkMode", false); }
            set { AppSettings.AddOrUpdateValue("DarkMode", value); }
        }
    }
}
