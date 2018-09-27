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

        public Image Thumbnail { get; set; } = new Image() { Source = "location.png" };

        public List<Image> ImageList { get; set; } =
            new List<Image>() {
             new Image() { Source = "profile.png" },
             new Image() { Source = "location.png" },
             new Image() { Source = "gift.png" },
            };
    }
}
