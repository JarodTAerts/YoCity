using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
