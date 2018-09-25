using System;
using System.Collections.Generic;
using System.Text;
using YoCity.Models;

namespace YoCity.Helpers
{
    class APIHelper
    {
        public static User Login(string UsernameText, string PasswordText)
        {
            if(!UsernameText.Equals("") && !PasswordText.Equals(""))
            {
                return new User() { UserName="User John", Points=100, Rank=10 };
            }
            else
            {
                return null;
            }
        }
    }
}
