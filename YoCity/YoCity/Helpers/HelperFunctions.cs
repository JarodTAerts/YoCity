using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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
    }
}
