using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace YoCity.Models
{
    /// <summary>
    /// Class that stores a location object that represents a location of area downtown 
    /// that will be fenced off with a geofence and give people points
    /// </summary>
    public class Location
    {
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int PointValue
        {
            get; set;
        }

        public Tuple<double,double> GPSCoordinates
        {
            get;
            set;
        }

        public Image Thumbnail { get; set; } = new Image() { Source = "location" };

        public Address LocationAddress { get; set; }
        public class Address
        {
            public string Street { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Zip { get; set; }
            public string Country { get; set; }
            public string CountryCode { get; set; }
        }


        public List<Image> ImageList { get; set; } =
            new List<Image>() {
             new Image() { Source = "profile" },
             new Image() { Source = "location" },
             new Image() { Source = "gift" },
            };
    }
}
