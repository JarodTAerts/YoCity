using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace YoCity.Models
{
    /// <summary>
    /// Class incorrectly spelt that represents swag items that points can be redeemed for
    /// </summary>
    public class Sawg
    {
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public int PointsCost
        {
            get; set;
        }

        public Image Thumbnail { get; set; } = new Image() { Source = "gift" };

        public List<Image> ImageList { get; set; } =
            new List<Image>() {
             new Image() { Source = "profile" },
             new Image() { Source = "location" },
             new Image() { Source = "gift" },
            };
    }
}
