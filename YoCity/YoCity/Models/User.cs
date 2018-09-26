using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace YoCity.Models
{
    public class User
    {
        public string UserName
        {
            get; set;
        }

        public string FullName
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public int Points
        {
            get; set;
        }

        public int Rank
        {
            get; set;
        }
        public Image ProfilePic { get; set; } = new Image() { Source = "profile.png" };
    }
}
