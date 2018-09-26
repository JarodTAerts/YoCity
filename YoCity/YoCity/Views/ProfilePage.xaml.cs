using Xamarin.Forms;

namespace YoCity.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        //Override back button so use cannot go back from this page
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
