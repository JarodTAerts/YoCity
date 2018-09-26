using System;
using System.Collections.Generic;
using System.Text;


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

        public int PointValue
        {
            get; set;
        }

        public Tuple<int,int> GPSCoordinates
        {
            get;
            set;
        }
    }
}
