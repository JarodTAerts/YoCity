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
            //Test location 1: LeadBelly's
            new Location() { Name="LeadBelly's", PointValue=8, GPSCoordinates=new Tuple<double, double>(40.816,-96.710),
                Description="A gourmet burger joint that brings the bur to burger. Come here to get truly yo burgers at any hour. " +
                "You can get egg burgers and yo burgers. Really any type of burgers. You could say its a burger bonanza or something like that. Yo Yo Yo. Yo!",
                Thumbnail =new Image(){ Source="city.jpg"},
                LocationAddress=new Location.Address() { City="Lincoln", State="Nebraska", Street="301 N 8th St", Zip="68508", Country="USA", CountryCode="USA" },
                ImageList=new List<Image>(){ new Image() { Source="city"}, new Image(){ Source="location" } } },
            // Test location 2: Ivan Cone
            new Location() { Name="Ivana Cone", PointValue=5, GPSCoordinates=new Tuple<double, double>(0,0),
                Description ="It's fucking ice cream. Of course you will enjoy it. You really don't have a choice at this joint. When you spend $10 on like 1 tiny scoop of ice cream you are gonna say you enjoy it whether you do or not.", },
            //Test location 3: Hurt's Donuts
            new Location() { Name="Hurt's Donuts", PointValue=3, GPSCoordinates=new Tuple<double, double>(0,0),
                Description="Is it a bird? No. Is it a plane? No. Its a fucking donut you dumbass. They are super sugary and they keep in a fridge for like 6 months. What do you expect."},
            // Test location 4: Rail Yard
            new Location() { Name="The Rail Yard", PointValue=7, GPSCoordinates=new Tuple<double, double>(0,0),
                Description="Once long ago people used to use this place to go other places. Weird, they should've just used cars. Now though people mostly just use it to get drunk and ice skate."},
            // Test location 5: Pinicale
            new Location() { Name="Pinicale", PointValue=10, GPSCoordinates=new Tuple<double, double>(0,0),
                Description="Big stadium boi where lots of people can gather to watch some big YoSports with their yos."},
        };
        private static ObservableCollection<Sawg> testSawgs = new ObservableCollection<Sawg>()
        {
            new Sawg() { Name="Cup", PointsCost=20, Description="I mean its a fucking cup. What do you expect. You use it to drink things." },
            new Sawg() { Name="Cards", PointsCost=15, Description="Cards. WOO so fun. You can gamble and shit. Cool. All the kids do it these days." },
            new Sawg() { Name="Shirt", PointsCost=50, Description="So you are naked less than you normally would be." },
            new Sawg() { Name="$20 Gift Card", PointsCost=100, Description="Use this gift card to buy things in places your great grandparents never would've imagened you would go." },
            new Sawg() { Name="$50 Gift Card", PointsCost=300, Description="See twenty dollar gift card but add $30 to the image in your head when you read it."  },
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
