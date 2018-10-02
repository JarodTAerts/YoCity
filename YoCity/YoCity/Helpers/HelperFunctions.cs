using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using YoCity.Models;

namespace YoCity.Helpers
{
    /// <summary>
    /// Class that holder functions that help throughout the app
    /// </summary>
    class HelperFunctions
    {
        /// <summary>
        /// Function that determines if a string is in a valid email format
        /// </summary>
        /// <param name="email">string representing an email</param>
        /// <returns>boolean of whether the format is valid</returns>
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Function that will look at the setting value for dark mode and set the system colors based on that
        /// </summary>
        public static void SetDarkMode()
        {
            if (Settings.DarkMode)
            {
                Application.Current.Resources["colorPrimary"] = Color.FromHex("#494949");
                Application.Current.Resources["buttonColor"] = Color.FromHex("#42C0FB");
                Application.Current.Resources["buttonTextColor"] = Color.FromHex("#F5F5F5");
            }
            else
            {
                Application.Current.Resources["colorPrimary"] = Color.FromHex("#42C0FB");
                Application.Current.Resources["buttonColor"] = Color.FromHex("#F5F5F5");
                Application.Current.Resources["buttonTextColor"] = Color.FromHex("#42C0FB");
            }
        }

        public static bool AddPoints(int points)
        {
            User currentUser = Settings.CurrentUser;
            currentUser.Points += points;

            // Call API with call to update user with point value if the return is not null then keep the point change else take it away
            bool returnValue = true; // Call to the API Add points function
            if (returnValue)
            {
                Settings.CurrentUser = currentUser;
            }
            else
            {
                currentUser.Points -= points;
            }


            return returnValue;
        }
    }
}
