using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using YoCity.Models;

namespace YoCity.Helpers
{
    class APIHelper
    {
        private static User testUser= new User() { UserName = "UserJohn", FullName="John User", Email="userjohn@email.com", Points = 100, Rank = 10 };
        private static ObservableCollection<Location> testLocations = new ObservableCollection<Location>() {
            new Location() { Name="LeadBelly's", PointValue=8 },
            new Location() { Name="Ivana Cone", PointValue=5 },
            new Location() { Name="Hurt's Donuts", PointValue=3 },
            new Location() { Name="The Rail Yard", PointValue=7 },
            new Location() { Name="Pinicale", PointValue=10 },
        };
        private static ObservableCollection<Sawg> testSawgs = new ObservableCollection<Sawg>()
        {
            new Sawg() { Name="Cup", PointsCost=20 },
            new Sawg() { Name="Cards", PointsCost=15 },
            new Sawg() { Name="Shirt", PointsCost=50 },
            new Sawg() { Name="$20 Gift Card", PointsCost=100 },
            new Sawg() { Name="$50 Gift Card", PointsCost=300 },
        };

        public static User Login(string UsernameText, string PasswordText)
        {
            //TODO: Actually hook this up to the API to really login when the API exists
            if(!UsernameText.Equals("") && !PasswordText.Equals(""))
            {
                return testUser;
            }
            else
            {
                return null;
            }
        }

        public static User CreateUser(User newUser)
        {
            //TODO: Actually hook this up when API is done
            return testUser;
        }

        public static ObservableCollection<Location> GetLocations()
        {
            //TODO: Actually hook this up to the API to get the real locations when the API exists
            return testLocations;
        }

        public static ObservableCollection<Sawg> GetSwag()
        {
            //TODO: Actually hook this up to the API to get the real swag when the API exists
            return testSawgs;
        }
    }
}
