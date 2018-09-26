using Xamarin.Forms;

namespace YoCity.Views
{
    public partial class MasterTabbedPage : TabbedPage
    {
        public MasterTabbedPage()
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
