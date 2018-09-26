using System;
using System.Collections.Generic;
using System.Text;


namespace YoCity.Models
{
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
