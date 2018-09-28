using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using YoCity.Models;

namespace YoCity.Helpers
{
    /// <summary>
    /// Class that holds functions that deal with accessing the API and sending and recieving data from it
    /// </summary>
    class APIHelper
    {
        // Here are some static test variables I am using to develop UI while the API doesnt exist 
        private static User testUser= new User() { UserName = "UserJohn", FullName="John User", Email="userjohn@email.com", Points = 100, Rank = 10 };
        private static ObservableCollection<Location> testLocations = new ObservableCollection<Location>() {
            new Location() { Name="LeadBelly's", PointValue=8, GPSCoordinates=new Tuple<double, double>(40.816,-96.710),
                Description="A gourmet burger joint that brings the bur to burger.", Thumbnail=new Image(){ Source="city.jpg"},
                ImageList=new List<Image>() { new Image() { Source = "city.jpg" }, new Image() { Source = "location.png" } } },
            new Location() { Name="Ivana Cone", PointValue=5, GPSCoordinates=new Tuple<double, double>(0,0) },
            new Location() { Name="Hurt's Donuts", PointValue=3, GPSCoordinates=new Tuple<double, double>(0,0) },
            new Location() { Name="The Rail Yard", PointValue=7, GPSCoordinates=new Tuple<double, double>(0,0) },
            new Location() { Name="Pinicale", PointValue=10, GPSCoordinates=new Tuple<double, double>(0,0) },
        };
        private static ObservableCollection<Sawg> testSawgs = new ObservableCollection<Sawg>()
        {
            new Sawg() { Name="Cup", PointsCost=20 },
            new Sawg() { Name="Cards", PointsCost=15 },
            new Sawg() { Name="Shirt", PointsCost=50 },
            new Sawg() { Name="$20 Gift Card", PointsCost=100 },
            new Sawg() { Name="$50 Gift Card", PointsCost=300 },
        };

        /// <summary>
        /// Function that attempts a login
        /// </summary>
        /// <param name="UsernameText">Username of prospective user</param>
        /// <param name="PasswordText">Password of prospective user</param>
        /// <returns>User object if sucessful and null if not</returns>
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

        /// <summary>
        /// Function to call API and create a new user for the system
        /// </summary>
        /// <param name="newUser">User object that will be added to the system</param>
        /// <returns>User object that was added if successful and null if failed</returns>
        public static User CreateUser(User newUser)
        {
            //TODO: Actually hook this up when API is done
            return testUser;
        }

        /// <summary>
        /// Function that calls api with a PATCH on a User object and returns the edited User object if sucessful
        /// Null otherwise
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static User EditUser(User newUser)
        {
            return null;
        }

        /// <summary>
        /// Function that gets a list of all locations in the database 
        /// </summary>
        /// <returns>List of location objects</returns>
        public static ObservableCollection<Location> GetLocations()
        {
            //TODO: Actually hook this up to the API to get the real locations when the API exists
            return testLocations;
        }

        /// <summary>
        /// Function to get all the swag items from the database
        /// </summary>
        /// <returns>List of swag items</returns>
        public static ObservableCollection<Sawg> GetSwag()
        {
            //TODO: Actually hook this up to the API to get the real swag when the API exists
            return testSawgs;
        }
    }
}
