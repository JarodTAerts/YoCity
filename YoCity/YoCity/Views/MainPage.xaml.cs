using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace YoCity.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            
		}

        //Override back button so use cannot go back from this page
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}